using System;
using GWT.Logger;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GWT.Model;

namespace GWT.Client.Views
{
    public partial class GwtMainForm : Form
    {
        private MainViewViewModel ViewModel { get; set; }
        private Dictionary<TabPage, List<ItemViewControl>> _tabAndItsControlsDictionary;
        private bool _suspended;

        /// <summary>
        /// Initializes a new instance of the <see cref="GwtMainForm"/> class.
        /// </summary>
        public GwtMainForm()
        {
            InitializeComponent();
            tabControl.AutoSize = true;
            ViewModel = new MainViewViewModel();
            _tabAndItsControlsDictionary = new Dictionary<TabPage, List<ItemViewControl>>();
        }

        /// <summary>
        /// Handles the Load event of the GwtMainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void GwtMainForm_Load(object sender, System.EventArgs e)
        {
            ViewModel.LoadDataFromApi();

            PrepareTabControlsWithItemViews(ViewModel.GetDataGroupedByCategories());
        }

        /// <summary>
        /// Prepares the tab controls with item views.
        /// </summary>
        /// <param name="controlsToPrepare">The controls to prepare.</param>
        private void PrepareTabControlsWithItemViews(Dictionary<string, List<ItemViewControl>> controlsToPrepare)
        {
            SuspendAllLeyouts();

            foreach (var controlGroup in controlsToPrepare)
            {
                TabPage tp = new TabPage(controlGroup.Key)
                {
                    Name = "tp" + controlGroup.Key.Replace(" ", ""),
                    BackColor = Color.DeepSkyBlue
                };

                FlowLayoutPanel flp = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoScroll = true, BorderStyle = BorderStyle.FixedSingle};
                tp.Controls.Add(flp);
                tp.VerticalScroll.Enabled = true;

                _tabAndItsControlsDictionary.Add(tp, new List<ItemViewControl>());
                foreach (var itemViewControl in controlGroup.Value.OrderBy(s => s.ItemDto.Name))
                {
                    PinOnClickToUpdateSelectedControlEvent(itemViewControl);
                    flp.Controls.Add(itemViewControl);
                    _tabAndItsControlsDictionary[tp].Add(itemViewControl);
                }
                tabControl.TabPages.Add(tp);
            }

            PrepareStartingData();

            ResumeAllLeyouts();
        }

        private void PrepareStartingData()
        {
            var tab = _tabAndItsControlsDictionary[tabControl.SelectedTab];
            if (tab != null)
            {
                ViewModel.SelectedListOfControls = tab;
                ViewModel.SelectedControl = tab.FirstOrDefault();
                LinksUpdate();
                ShowListingData(ViewModel.SelectedControl);
            }
        }

        #region LINKS

        /// <summary>
        /// Linkses the update.
        /// </summary>
        public void LinksUpdate()
        {
            linkGW2tp.Links.Clear();
            linkWiki.Links.Clear();

            if (ViewModel.SelectedControl != null)
            {
                ItemDTO item = ViewModel.SelectedControl.ItemDto;
                if (item != null)
                {
                    linkGW2tp.Text = "GW2TP: " + item.Name;
                    linkGW2tp.Links.Add(0, 0, String.Format("https://www.gw2tp.com/item/{0}-{1}", item.Id, item.Name.Replace(" ", "-")));
                    linkWiki.Text = "Wiki: " + item.Name;
                    linkWiki.Links.Add(0, 0, "https://wiki.guildwars2.com/wiki/" + item.Name.Replace(" ", "_"));
                }
            }
        }

        /// <summary>
        /// Handles the LinkClicked event of the linkGW2tp control.
        /// Opens http://gw2tp.com webside for selected item
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void linkGW2tp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        /// <summary>
        /// Handles the LinkClicked event of the linkWiki control.
        /// Opens gw2 wiki weside for selected item
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void linkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        #endregion

        #region Custom Events pin & unpin

        /// <summary>
        /// Pins the on click to update selected control event.
        /// </summary>
        /// <param name="control">The control.</param>
        private void PinOnClickToUpdateSelectedControlEvent(Control control)
        {
            foreach (Control subControl in control.Controls)
            {
                PinOnClickToUpdateSelectedControlEvent(subControl);
            }
            control.Click += itemViewControl_Click;
            control.Disposed += control_Disposed;
        }

        /// <summary>
        /// Handles the Disposed event of the control control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void control_Disposed(object sender, System.EventArgs e)
        {
            UnpinAllEvents(sender as Control);
            if (sender is ItemViewControl)
            {
                (sender as ItemViewControl).Disposed -= control_Disposed;
            }
        }

        /// <summary>
        /// Unpins all events.
        /// </summary>
        /// <param name="control">The control.</param>
        private void UnpinAllEvents(Control control)
        {
            foreach (Control subControl in control.Controls)
            {
                UnpinAllEvents(subControl);
            }
            control.Click -= itemViewControl_Click;
        }

        /// <summary>
        /// Handles the Click event of the itemViewControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void itemViewControl_Click(object sender, System.EventArgs e)
        {
            ItemViewControl ivc = GetParentItemViewControl(sender as Control);
            if (ivc != null)
            {
                ViewModel.SelectedControl = ivc;
                LinksUpdate();
                ShowListingData(ivc);
            }
        }

        /// <summary>
        /// Gets the parent item view control.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns></returns>
        private ItemViewControl GetParentItemViewControl(Control control)
        {
            if (control == null || control.Parent == null)
            {
                return null;
            }
            if (control is ItemViewControl)
            {
                return control as ItemViewControl;
            }
            if (control.Parent is ItemViewControl)
            {
                return control.Parent as ItemViewControl;
            }
            return GetParentItemViewControl(control.Parent);
        }


        #endregion

        /// <summary>
        /// Handles the Click event of the closeToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            BeforeDisposing();
            this.Dispose();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the tabControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            TabControl tc = sender as TabControl;
            if (tc != null)
            {
                if (tc.SelectedTab != null)
                {
                    Log.LogDebug("GwtMainView.tabControlMain_SelectedIndexChanged: Changing tab to '{0}'", tc.SelectedTab.Name);
                    var tab = _tabAndItsControlsDictionary[tc.SelectedTab];
                    if (tab != null)
                    {
                        ViewModel.SelectedListOfControls = tab;
                    }
                }
            }
            else
                Log.LogError("GwtMainView.tabControlMain_SelectedIndexChanged: selected page is NULL!");

        }

        #region Listings

        /// <summary>
        /// Shows the <see cref="ListingsDTO"/> data return by Gw2Api on both grids.
        /// </summary>
        public void ShowListingData(ItemViewControl itemControl)
        {
            if (itemControl != null && itemControl.ItemDto != null)
            {
                ItemDTO item = itemControl.ItemDto;
                Log.LogDebug("ShowListingData: item Id: {0}", item.Id);
                ShowSellers(item.Listings);
                ShowBuyers(item.Listings);
            }
            else
                Log.LogError("ShowListingData: item is NULL");
        }

        /// <summary>
        /// Creates and adds new rows to dgBuyers based on <see cref="ListingsDTO"/> Sells list
        /// </summary>
        private void ShowSellers(ListingsDTO listings)
        {
            dgSellers.Rows.Clear();
            if (listings != null && listings.Sells != null)
                for (int i = 0; cbSellers.Checked ? (i < listings.Sells.Length && i < 10) : i < listings.Sells.Length; i++)
                {
                    var sellListing = listings.Sells[i];
                    dgSellers.Rows.Add(sellListing.Unit_Price, sellListing.Quantity, sellListing.Listings);
                }
        }

        /// <summary>
        /// Creates and adds new rows to dgBuyers based on <see cref="ListingsDTO"/> BUYS list
        /// </summary>
        private void ShowBuyers(ListingsDTO listings)
        {
            dgBuyers.Rows.Clear();
            if (listings != null && listings.Buys != null)
                for (int i = 0; cbBuyers.Checked ? (i < listings.Buys.Length && i < 10) : i < listings.Buys.Length; i++)
                {
                    var buyListing = listings.Buys[i];
                    dgBuyers.Rows.Add(buyListing.Unit_Price, buyListing.Quantity, buyListing.Listings);
                }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the TOP10 checkbox buyers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cbBuyers_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewModel.SelectedControl != null &&
                ViewModel.SelectedControl.ItemDto != null &&
                ViewModel.SelectedControl.ItemDto.Listings != null)
            {
                ShowBuyers(ViewModel.SelectedControl.ItemDto.Listings);
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the TOP10 checkbox sellers control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSellers_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewModel.SelectedControl != null &&
                ViewModel.SelectedControl.ItemDto != null &&
                ViewModel.SelectedControl.ItemDto.Listings != null)
            {
                ShowSellers(ViewModel.SelectedControl.ItemDto.Listings);
            }
        }


        #endregion

        #region Leyout

        /// <summary>
        /// Suspends all leyouts.
        /// </summary>
        private void SuspendAllLeyouts()
        {
            if (!_suspended)
            {
                _suspended = true;
                this.panelForTabs.SuspendLayout();
                this.panel1.SuspendLayout();
                this.menuStrip1.SuspendLayout();
                this.panel2.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.dgBuyers)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.dgSellers)).BeginInit();
                this.pGW2TPLink.SuspendLayout();
                this.pWikiLink.SuspendLayout();
                this.SuspendLayout();
            }
        }

        /// <summary>
        /// Resumes all leyouts.
        /// </summary>
        private void ResumeAllLeyouts()
        {
            if (_suspended)
            {
                this.panelForTabs.ResumeLayout(false);
                this.panel1.ResumeLayout(false);
                this.panel1.PerformLayout();
                this.menuStrip1.ResumeLayout(false);
                this.menuStrip1.PerformLayout();
                this.panel2.ResumeLayout(false);
                this.panel2.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.dgBuyers)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.dgSellers)).EndInit();
                this.pGW2TPLink.ResumeLayout(false);
                this.pGW2TPLink.PerformLayout();
                this.pWikiLink.ResumeLayout(false);
                this.pWikiLink.PerformLayout();
                this.ResumeLayout(false);
                this.PerformLayout();
                _suspended = false;
            }
        }

        #endregion

        /// <summary>
        /// Handles the Click event of the refreshToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void refreshToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ViewModel.RefreshSelectedTab();
        }

        /// <summary>
        /// Befores the disposing.
        /// </summary>
        private void BeforeDisposing()
        {
            ViewModel.SaveAllData();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuspendAllLeyouts();

            while (tabControl.TabPages.Count > 0)
            {
                TabPage tabPage = tabControl.TabPages[0];
                tabControl.TabPages.Remove(tabPage);
                tabPage.Dispose();
            }

            ViewModel.LoadDataFromApi(true);

            PrepareTabControlsWithItemViews(ViewModel.GetDataGroupedByCategories());
        }
    }
}
