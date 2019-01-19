using GWT.ApiRequestMenager;
using GWT.Client.Views;
using GWT.Logger;
using GWT.Model;
using GWT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GWT.Client
{
    public class MainViewViewModel
    {
        private ContextGwt _context;
        private ApiRequestManager _requestManager;
        private readonly ControlContainer _controlContainer;
        private ItemViewControl _selectedControl;

        public List<ItemViewControl> SelectedListOfControls { get; set; }

        public ItemViewControl SelectedControl
        {
            get { return _selectedControl; }
            set
            {
                _selectedControl = value;
                OnSelectedControlChanged();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewViewModel"/> class.
        /// </summary>
        public MainViewViewModel()
        {
            _requestManager = new ApiRequestManager();
            _context = new ContextGwt();
            _controlContainer = new ControlContainer();
        }

        /// <summary>
        /// Loads the data from API.
        /// </summary>
        public void LoadDataFromApi(bool forceDownload = false)
        {
            if (_context.Items.Count < 1 || forceDownload)
            {
                #region GetAllExistingObjectsInApi

                DialogResult mboxResult = forceDownload ? DialogResult.Yes : MessageBox.Show("Brak wpisów w bazie! Czy chcesz pobrać je z API?", "Brak danych!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (mboxResult == DialogResult.Yes)
                {
                    ItemDTO[] list = _requestManager.GetAllExistingObjectsInApi();

                    Log.LogInfo("Pobrano '{0}' obiektów!", list.Length.ToString());

                    try
                    {
                        _context.Items = new List<ItemDTO>(list);
                        _context.Save();
                    }
                    catch (Exception e)
                    {
                        Log.LogFatalAndShowMessageBox("Błąd podczas pobierania danych z API:\n{0}\n{1}\n{2}", e.GetType(), e.Message, e.StackTrace);
                    }
                    Log.LogInfoAndShowMessageBox("Pobrano '{0}' obiektów!", list.Length.ToString());
                }

                #endregion
            }
        }

        /// <summary>
        /// Gets the data grouped by categories.
        /// </summary>
        /// <returns></returns>
        internal Dictionary<string, List<ItemViewControl>> GetDataGroupedByCategories()
        {
            var groupedItemViewControls = new Dictionary<string, List<ItemViewControl>>();
            var groupedItems = _context.Items.GroupBy(x => x.CategoryName);

            foreach (var group in groupedItems)
            {
                List<ItemViewControl> itemViewControls = new List<ItemViewControl>();
                foreach (var itemDto in group.Where(x => x.IsSellable))
                {
                    itemViewControls.Add(_controlContainer.RegisterControl(itemDto));
                }
                groupedItemViewControls.Add(group.Key, itemViewControls);
            }
            return groupedItemViewControls;
        }

        /// <summary>
        /// Called when [selected control changed].
        /// </summary>
        private void OnSelectedControlChanged()
        {
            if (SelectedControl != null)
            {
                _requestManager.GetItemListings(SelectedControl.ItemDto);
            }
        }

        public void RefreshSelectedTab()
        {
            Log.LogInfo("RefreshSelectedTab");
            _requestManager.SetGw2AppCommerceDtoForItemList(SelectedListOfControls.Select(x => x.ItemDto).ToArray());

            ColorTop10BestProfits();
        }

        /// <summary>
        /// Refreshes the selected control.
        /// </summary>
        /// <param name="control">The control.</param>
        public void RefreshSelectedControl(ItemViewControl control)
        {
            ItemDTO item = control.ItemDto;
            if (item == null)
            {
                Log.LogFatal("Okno nie ma obiektu!");
            }
            else
            {
                Log.LogInfo("RefreshSelectedControl: {0} - {1}", item.Id, item.Name);
                _requestManager.GetGw2AppCurrentPriceForItem(item);
                control.Refresh();
            }
        }

        private void ColorTop10BestProfits()
        {
            var top10Items = SelectedListOfControls.Where(x => x.ItemDto != null).OrderByDescending(x => x.ItemDto.ProfitUnitPrice).ToList();
            top10Items = top10Items.Take(Math.Min(top10Items.Count, 10)).ToList();
            foreach (var itemViewControl in top10Items)
            {
                itemViewControl.SetBackColorToTopColor();
            }

            foreach (var itemViewControl in SelectedListOfControls.Where(x => top10Items.All(c => c != x)))
            {
                itemViewControl.SetBackColorToDefaultColor();
            }
        }

        /// <summary>
        /// Saves all data.
        /// </summary>
        public void SaveAllData()
        {
            _context.Save();
        }
    }
}
