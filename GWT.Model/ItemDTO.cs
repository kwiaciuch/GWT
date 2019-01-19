using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace GWT.Model
{
    [Serializable()]
    public class ItemDTO : INotifyPropertyChanged
    {
        private int _id;
        private string _chatLink;
        private string _name;
        private string _icon;
        private string _description;
        private string _type;
        private string _rarity;
        private int _level;
        private int _vendorValue;
        private int _defaultSkin;
        private List<string> _flags;
        private bool? _isSellable;

        private string[] noSellFlags = { "SoulbindOnAcquire", "AccountBound", "MonsterOnly", "NoSell" };
        private bool _isFavorite;
        private int? _categoryId;
        private string _categoryName;
        private string _nameWithNewLines;
        private int _buyUnitPrice;
        private int _sellUnitPrice;


        public ItemDTO()
        { }

        #region Base Properties

        [System.Xml.Serialization.XmlElement("Id")]
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        [System.Xml.Serialization.XmlElement("Name")]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        [System.Xml.Serialization.XmlElement("Icon")]
        public string Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                OnPropertyChanged();
            }
        }

        [System.Xml.Serialization.XmlElement("Description")]
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        [System.Xml.Serialization.XmlElement("Type")]
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged();
            }
        }

        [System.Xml.Serialization.XmlElement("Rarity")]
        public string Rarity
        {
            get { return _rarity; }
            set
            {
                _rarity = value;
                OnPropertyChanged();
            }
        }

        [System.Xml.Serialization.XmlElement("Level")]
        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged();
            }
        }

        [System.Xml.Serialization.XmlElement("Vendor_Value")]
        public int Vendor_Value
        {
            get { return _vendorValue; }
            set
            {
                _vendorValue = value;
                OnPropertyChanged();
            }
        }

        [System.Xml.Serialization.XmlElement("Flags")]
        public List<string> Flags
        {
            get { return _flags; }
            set
            {
                _flags = value;
                OnPropertyChanged();
            }
        }

        [System.Xml.Serialization.XmlElement("IsFavorite")]
        public bool IsFavorite
        {
            get { return _isFavorite; }
            set
            {
                _isFavorite = value;
                OnPropertyChanged();
            }
        }

        [System.Xml.Serialization.XmlElement("CategoryId")]
        public int? CategoryId
        {
            get { return _categoryId; }
            set
            {
                _categoryId = value;
                OnPropertyChanged();
            }
        }

        [System.Xml.Serialization.XmlElement("CategoryName")]
        public string CategoryName
        {
            get { return _categoryName; }
            set
            {
                _categoryName = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Custom properties

        [XmlIgnore]
        public bool IsSellable
        {
            get
            {
                if (!_isSellable.HasValue)
                    _isSellable = Flags.All(x => noSellFlags.All(f => f != x.ToString()));
                return _isSellable.Value;
            }
        }

        [XmlIgnore]
        public int BuyUnitPrice
        {
            get { return _buyUnitPrice; }
            set
            {
                _buyUnitPrice = value;
                OnPropertyChanged();
            }
        }

        [XmlIgnore]
        public int BuyQuantity { get; set; }

        [XmlIgnore]
        public int SellUnitPrice
        {
            get { return _sellUnitPrice; }
            set
            {
                _sellUnitPrice = value;
                OnPropertyChanged();
            }
        }

        [XmlIgnore]
        public int SellQuantity { get; set; }

        [XmlIgnore]
        public int ProfitUnitPrice
        {
            get { return Convert.ToInt32(SellUnitPrice * 0.85 - BuyUnitPrice); }
        }

        [XmlIgnore]
        public string NameWithNewLines
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_nameWithNewLines))
                    _nameWithNewLines = SplitName();
                return _nameWithNewLines;
            }
        }

        private string SplitName()
        {
            var obj = Name.Split(' ');
            string newName = string.Empty;

            string line = string.Empty;
            foreach (var word in obj)
            {
                if (line.Length + word.Length > 12)
                {
                    newName += line + Environment.NewLine;
                    line = word;
                }
                else
                {
                    line += String.Format(" {0}", word);
                }
            }
            newName += line;

            return string.IsNullOrWhiteSpace(newName) ? Name : newName.Trim();
        }

        [XmlIgnore]
        public ListingsDTO Listings { get; set; }

        #endregion

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
