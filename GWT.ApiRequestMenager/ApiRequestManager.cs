using GWT.Logger;
using GWT.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GWT.ApiRequestMenager
{
    public class ApiRequestManager
    {
        /// <summary>
        /// Gets the and store materials.
        /// </summary>
        /// <returns></returns>
        public ItemDTO[] GetAllExistingObjectsInApi()
        {
            DateTime startTime = DateTime.Now;
            Log.LogInfo("GetAllExistingObjectsInApi: StartTime - {0}", startTime);

            List<ItemDTO> listOfMaterials = new List<ItemDTO>();
            int[] categoriesList = GetListOfCategories();

            try
            {
                foreach (int category in categoriesList)
                {
                    CategoryItemsListDTO categoryItemsList = GetListOfItemsForCategory(category);
                    ItemDTO[] items = GetGw2AppItemList(categoryItemsList.Items);

                    if (items != null)
                    {
                        foreach (var item in items)
                        {
                            item.CategoryId = category;
                            item.CategoryName = categoryItemsList.Name;

                            listOfMaterials.Add(item);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Log.LogErrorAndShowMessageBox(string.Format("Error during getting all objects in API:" + Environment.NewLine + e.Message));
            }

            Log.LogInfo("GetAllExistingObjectsInApi: Endntime: " + DateTime.Now.Subtract(startTime));
            return listOfMaterials.ToArray();
        }

        /// <summary>
        /// Gets the list of categories.
        /// </summary>
        /// <returns></returns>
        public int[] GetListOfCategories()
        {
            var json = GetGW2AppData("/materials");
            var data = ConvertFromJSONToObject<int[]>(json);
            return data;
        }

        /// <summary>
        /// Gets the list of items for category.
        /// </summary>
        /// <param name="categoryId">The category identifier.</param>
        /// <returns></returns>
        private CategoryItemsListDTO GetListOfItemsForCategory(int categoryId)
        {
            var json = GetGW2AppData("/materials/" + categoryId);
            return ConvertFromJSONToObject<CategoryItemsListDTO>(json);
        }

        /// <summary>
        /// Gets the item with current price.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public ItemDTO GetGw2AppCurrentPriceForItem(ItemDTO item)
        {
            if (item != null)
            {
                CommerceDTO priceObj = GetGw2AppCommerceDtoForItem(item);
                SetValues(item, priceObj);
            }
            Log.LogFatal("GetGw2AppItemWithCurrentPrice: Object is null!");
            return item;
        }

        /// <summary>
        /// Sets the values.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="priceObj">The price object.</param>
        private void SetValues(ItemDTO item, CommerceDTO priceObj)
        {
            if (priceObj != null)
            {
                item.BuyQuantity = priceObj.Buys.Quantity;
                item.BuyUnitPrice = priceObj.Buys.Unit_Price;
                item.SellQuantity = priceObj.Sells.Quantity;
                item.SellUnitPrice = priceObj.Sells.Unit_Price;
            }
            else
            {
                item.BuyQuantity = 0;
                item.BuyUnitPrice = 0;
                item.SellQuantity = 0;
                item.SellUnitPrice = 0;
            }
        }

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="itemId">The item identifier.</param>
        /// <returns></returns>
        public ItemDTO GetGw2AppItem(int itemId)
        {
            ItemDTO obj;
            try
            {
                var json = GetGW2AppData("/items/" + itemId);         //sample request: https://api.guildwars2.com/v2/items/12246
                obj = ConvertFromJSONToObject<ItemDTO>(json);
            }
            catch (Exception ex)
            {
                Log.LogErrorAndShowMessageBox("Error: GetGW2AppItem:" + ex.Message);
                return null;
            }
            return obj;
        }

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <returns></returns>
        public ItemDTO[] GetGw2AppItemList(int[] itemsIds)
        {
            ItemDTO[] obj;
            try
            {
                string idsAsString = String.Empty;
                foreach (var id in itemsIds)
                {
                    idsAsString += String.Format("{0},", id);
                }
                if (string.IsNullOrWhiteSpace(idsAsString))
                    return null;
                else
                {
                    idsAsString.Trim();
                    idsAsString.Substring(0, idsAsString.Length - 1);
                }

                var json = GetGW2AppData("/items?ids=" + idsAsString);         //sample request: https://api.guildwars2.com/v2/items?ids=12134,12238,12147,12142
                obj = ConvertFromJSONToObject<ItemDTO[]>(json);
            }
            catch (Exception ex)
            {
                Log.LogErrorAndShowMessageBox("Error: GetGW2AppItem:" + ex.Message);
                return null;
            }
            return obj;
        }

        /// <summary>
        /// Gets the current price for item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        private CommerceDTO GetGw2AppCommerceDtoForItem(ItemDTO item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            CommerceDTO data = null;
            try
            {
                var json = GetGW2AppData("/commerce/prices/" + item.Id); //sample request: https://api.guildwars2.com/v2/commerce/prices/19684
                data = ConvertFromJSONToObject<CommerceDTO>(json);
            }
            catch (Exception ex)
            {
                Log.LogError("Error: GetGw2AppItemCurrentPrice:" + ex.Message);
                return null;
            }
            return data;
        }

        public void SetGw2AppCommerceDtoForItemList(ItemDTO[] items)
        {
            CommerceDTO[] commerceArray = GetGw2AppCommerceDtoForItemList(items);
            foreach (var item in items)
            {
                SetValues(item, commerceArray.FirstOrDefault(x => x.Id == item.Id));
            }
        }

        private CommerceDTO[] GetGw2AppCommerceDtoForItemList(ItemDTO[] itemsIds)
        {
            CommerceDTO[] data;
            try
            {
                string idsAsString = string.Empty;
                foreach (var item in itemsIds)
                {
                    idsAsString += string.Format("{0},", item.Id);
                }
                if (string.IsNullOrWhiteSpace(idsAsString))
                    return null;
                else
                {
                    idsAsString.Trim();
                    idsAsString.Substring(0, idsAsString.Length - 1);
                }

                var json = GetGW2AppData("/commerce/prices?ids=" + idsAsString); //sample request: https://api.guildwars2.com/v2/commerce/prices?ids=19684,1968,19686
                data = ConvertFromJSONToObject<CommerceDTO[]>(json);
            }
            catch (Exception ex)
            {
                Log.LogError("Error: GetGw2AppItemCurrentPrice:" + ex.Message);
                return null;
            }
            return data;
        }


        /// <summary>
        /// General and main method for getting content from GW2 App v2
        /// </summary>
        /// <param name="urlCode">URL code to generate specific request.</param>
        /// <returns>JSON string for given URL, or String.Empty if sth gone wrong</returns>
        private string GetGW2AppData(string urlCode)
        {
            string data = String.Empty;
            try
            {
                var webRequest = WebRequest.Create(@"https://api.guildwars2.com/v2" + urlCode);
                webRequest.Timeout = 3 * 1000;
                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    data = reader.ReadToEnd();
                }
            }
            catch (WebException we)
            {
                Log.LogError("Error: GetGW2AppData:" + we.Message);
                return String.Empty;

            }
            catch (Exception ex)
            {
                Log.LogError("Error: GetGW2AppData:" + ex.Message);
                return String.Empty;
            }
            return data;
        }

        /// <summary>
        /// Gets the object tp listings.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public ListingsDTO GetItemListings(ItemDTO item)
        {
            ListingsDTO data = null;
            try
            {
                var json = GetGW2AppData("/commerce/listings/" + item.Id); //sample request: https://api.guildwars2.com/v2/commerce/listings/19684 page and page_size
                data = ConvertFromJSONToObject<ListingsDTO>(json);
                item.Listings = data;
            }
            catch (Exception ex)
            {
                Log.LogError("Error: GetObjectTPListings:" + ex.Message);
                return null;
            }
            return data;
        }


        /// <summary>
        /// Converts from JSON to specified object.
        /// </summary>
        /// <typeparam name="T">Requested object type</typeparam>
        /// <param name="JSONcode">The JSON code as a text.</param>
        /// <returns>Object based on JSON</returns>
        private T ConvertFromJSONToObject<T>(string JSONcode)
        {
            T deserializedObject;
            try
            {
                deserializedObject = JsonConvert.DeserializeObject<T>(JSONcode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: ConvertFromJSONToObject:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
            return deserializedObject;
        }
    }
}
