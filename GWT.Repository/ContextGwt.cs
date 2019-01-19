using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using GWT.Logger;
using GWT.Model;

namespace GWT.Repository
{
    public class ContextGwt
    {
        private const string _dbPath = "data.xml";
        private List<ItemDTO> _itemList;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextGwt"/> class.
        /// </summary>
        public ContextGwt()
        {
            _itemList = new List<ItemDTO>();

            InitContextData();
        }

        /// <summary>
        /// Initializes the context data from file.
        /// </summary>
        private void InitContextData()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<ItemDTO>));
                StreamReader reader = new StreamReader(_dbPath);
                _itemList = (List<ItemDTO>)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception e)
            {
                Log.LogFatal("Error during initialization of context!:\n{0}\n", e.Message);
            }

            if (_itemList == null)
                _itemList = new List<ItemDTO>();
        }

        /// <summary>
        /// Refreshes the context.
        /// </summary>
        public void Refresh()
        {
            _itemList = new List<ItemDTO>();

            InitContextData();
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(List<ItemDTO>));
            string xml = "";

            using (var sw = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    xsSubmit.Serialize(writer, _itemList);
                    xml = sw.ToString();
                }
            }

            File.WriteAllText(_dbPath, xml);
        }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        public List<ItemDTO> Items
        {
            get { return _itemList; }
            set { _itemList = value; }
        }
    }
}
