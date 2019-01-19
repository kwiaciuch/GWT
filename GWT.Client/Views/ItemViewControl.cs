using GWT.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GWT.Client.Views
{
    public partial class ItemViewControl : UserControl
    {
        public ItemDTO ItemDto { get; set; }  

        private ItemViewControl()
        {
            InitializeComponent();
        }

        public ItemViewControl(ItemDTO item) : this()
        {
            if (item == null) 
                throw new ArgumentNullException("item");

            ItemDto = item;
            labelObjectName.DataBindings.Add("Text", ItemDto, "NameWithNewLines");
            labelBuyCost.DataBindings.Add("Text", ItemDto, "BuyUnitPrice");
            labelSellCost.DataBindings.Add("Text", ItemDto, "SellUnitPrice");
            labelProfitExpected.DataBindings.Add("Text", ItemDto, "ProfitUnitPrice");
        }

        public void SetBackColorToTopColor()
        {
            this.mainPanel.BackColor = Color.LightGreen;
        }

        public void SetBackColorToDefaultColor()
        {
            this.mainPanel.BackColor = Color.AliceBlue;
        }
    }
}
