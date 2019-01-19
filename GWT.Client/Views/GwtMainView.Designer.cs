namespace GWT.Client.Views
{
    partial class GwtMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelForTabs = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgBuyers = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbBuyers = new System.Windows.Forms.CheckBox();
            this.lBuyers = new System.Windows.Forms.Label();
            this.dgSellers = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbSellers = new System.Windows.Forms.CheckBox();
            this.lSellers = new System.Windows.Forms.Label();
            this.pGW2TPLink = new System.Windows.Forms.Panel();
            this.linkGW2tp = new System.Windows.Forms.LinkLabel();
            this.pWikiLink = new System.Windows.Forms.Panel();
            this.linkWiki = new System.Windows.Forms.LinkLabel();
            this.colBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellerPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellerCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelForTabs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuyers)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSellers)).BeginInit();
            this.panel4.SuspendLayout();
            this.pGW2TPLink.SuspendLayout();
            this.pWikiLink.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForTabs
            // 
            this.panelForTabs.AutoSize = true;
            this.panelForTabs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelForTabs.Controls.Add(this.tabControl);
            this.panelForTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForTabs.Location = new System.Drawing.Point(178, 24);
            this.panelForTabs.Name = "panelForTabs";
            this.panelForTabs.Size = new System.Drawing.Size(856, 646);
            this.panelForTabs.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(852, 642);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelSearchName);
            this.panel1.Controls.Add(this.textBoxSearchName);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 646);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Location = new System.Drawing.Point(131, 49);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(40, 13);
            this.labelSearchName.TabIndex = 2;
            this.labelSearchName.Text = "Nazwa";
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(3, 46);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(122, 20);
            this.textBoxSearchName.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSearch.Location = new System.Drawing.Point(0, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(174, 40);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1325, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.optionsToolStripMenuItem.Text = "Zresetuj baze";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.refreshToolStripMenuItem.Text = "Odśwież";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.closeToolStripMenuItem.Text = "Zamknij";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Controls.Add(this.pGW2TPLink);
            this.panel2.Controls.Add(this.pWikiLink);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1034, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 646);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 58);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgBuyers);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgSellers);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Size = new System.Drawing.Size(287, 584);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgBuyers
            // 
            this.dgBuyers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgBuyers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuyers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBuyPrice,
            this.colBuyCount,
            this.colBuyers});
            this.dgBuyers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBuyers.Location = new System.Drawing.Point(0, 23);
            this.dgBuyers.Name = "dgBuyers";
            this.dgBuyers.ReadOnly = true;
            this.dgBuyers.Size = new System.Drawing.Size(287, 233);
            this.dgBuyers.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbBuyers);
            this.panel3.Controls.Add(this.lBuyers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.MaximumSize = new System.Drawing.Size(0, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 23);
            this.panel3.TabIndex = 2;
            // 
            // cbBuyers
            // 
            this.cbBuyers.AutoSize = true;
            this.cbBuyers.Checked = true;
            this.cbBuyers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBuyers.Location = new System.Drawing.Point(6, 3);
            this.cbBuyers.Name = "cbBuyers";
            this.cbBuyers.Size = new System.Drawing.Size(60, 17);
            this.cbBuyers.TabIndex = 7;
            this.cbBuyers.Text = "TOP10";
            this.cbBuyers.UseVisualStyleBackColor = true;
            this.cbBuyers.CheckedChanged += new System.EventHandler(this.cbBuyers_CheckedChanged);
            // 
            // lBuyers
            // 
            this.lBuyers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBuyers.Font = new System.Drawing.Font("Book Antiqua", 15.5F, System.Drawing.FontStyle.Bold);
            this.lBuyers.Location = new System.Drawing.Point(0, 0);
            this.lBuyers.MaximumSize = new System.Drawing.Size(0, 23);
            this.lBuyers.Name = "lBuyers";
            this.lBuyers.Size = new System.Drawing.Size(287, 23);
            this.lBuyers.TabIndex = 5;
            this.lBuyers.Text = "Zamawiający";
            this.lBuyers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgSellers
            // 
            this.dgSellers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSellers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSellerPrice,
            this.colSellerCount,
            this.colSellers});
            this.dgSellers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSellers.Location = new System.Drawing.Point(0, 23);
            this.dgSellers.Name = "dgSellers";
            this.dgSellers.Size = new System.Drawing.Size(287, 301);
            this.dgSellers.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbSellers);
            this.panel4.Controls.Add(this.lSellers);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.MaximumSize = new System.Drawing.Size(0, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 23);
            this.panel4.TabIndex = 8;
            // 
            // cbSellers
            // 
            this.cbSellers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSellers.AutoSize = true;
            this.cbSellers.Checked = true;
            this.cbSellers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSellers.Location = new System.Drawing.Point(6, 3);
            this.cbSellers.Name = "cbSellers";
            this.cbSellers.Size = new System.Drawing.Size(60, 17);
            this.cbSellers.TabIndex = 10;
            this.cbSellers.Text = "TOP10";
            this.cbSellers.UseVisualStyleBackColor = true;
            this.cbSellers.CheckedChanged += new System.EventHandler(this.cbSellers_CheckedChanged);
            // 
            // lSellers
            // 
            this.lSellers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lSellers.Font = new System.Drawing.Font("Book Antiqua", 15.5F, System.Drawing.FontStyle.Bold);
            this.lSellers.Location = new System.Drawing.Point(0, 0);
            this.lSellers.Name = "lSellers";
            this.lSellers.Size = new System.Drawing.Size(287, 23);
            this.lSellers.TabIndex = 9;
            this.lSellers.Text = "Sprzedający";
            this.lSellers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pGW2TPLink
            // 
            this.pGW2TPLink.Controls.Add(this.linkGW2tp);
            this.pGW2TPLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.pGW2TPLink.Location = new System.Drawing.Point(0, 29);
            this.pGW2TPLink.Name = "pGW2TPLink";
            this.pGW2TPLink.Size = new System.Drawing.Size(287, 29);
            this.pGW2TPLink.TabIndex = 5;
            // 
            // linkGW2tp
            // 
            this.linkGW2tp.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkGW2tp.AutoSize = true;
            this.linkGW2tp.Location = new System.Drawing.Point(3, 8);
            this.linkGW2tp.Name = "linkGW2tp";
            this.linkGW2tp.Size = new System.Drawing.Size(52, 13);
            this.linkGW2tp.TabIndex = 1;
            this.linkGW2tp.TabStop = true;
            this.linkGW2tp.Text = "GW2TP: ";
            this.linkGW2tp.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkGW2tp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGW2tp_LinkClicked);
            // 
            // pWikiLink
            // 
            this.pWikiLink.Controls.Add(this.linkWiki);
            this.pWikiLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.pWikiLink.Location = new System.Drawing.Point(0, 0);
            this.pWikiLink.Name = "pWikiLink";
            this.pWikiLink.Size = new System.Drawing.Size(287, 29);
            this.pWikiLink.TabIndex = 6;
            // 
            // linkWiki
            // 
            this.linkWiki.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkWiki.AutoSize = true;
            this.linkWiki.Location = new System.Drawing.Point(3, 8);
            this.linkWiki.Name = "linkWiki";
            this.linkWiki.Size = new System.Drawing.Size(34, 13);
            this.linkWiki.TabIndex = 0;
            this.linkWiki.TabStop = true;
            this.linkWiki.Text = "Wiki: ";
            this.linkWiki.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWiki_LinkClicked);
            // 
            // colBuyPrice
            // 
            this.colBuyPrice.HeaderText = "Cena";
            this.colBuyPrice.Name = "colBuyPrice";
            this.colBuyPrice.ReadOnly = true;
            this.colBuyPrice.Width = 57;
            // 
            // colBuyCount
            // 
            this.colBuyCount.HeaderText = "Ilość";
            this.colBuyCount.Name = "colBuyCount";
            this.colBuyCount.ReadOnly = true;
            this.colBuyCount.Width = 54;
            // 
            // colBuyers
            // 
            this.colBuyers.HeaderText = "Zamawiających";
            this.colBuyers.Name = "colBuyers";
            this.colBuyers.ReadOnly = true;
            this.colBuyers.Width = 106;
            // 
            // colSellerPrice
            // 
            this.colSellerPrice.HeaderText = "Cena";
            this.colSellerPrice.Name = "colSellerPrice";
            this.colSellerPrice.Width = 57;
            // 
            // colSellerCount
            // 
            this.colSellerCount.HeaderText = "Ilość";
            this.colSellerCount.Name = "colSellerCount";
            this.colSellerCount.Width = 54;
            // 
            // colSellers
            // 
            this.colSellers.HeaderText = "Sprzedających";
            this.colSellers.Name = "colSellers";
            this.colSellers.Width = 102;
            // 
            // GwtMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 670);
            this.Controls.Add(this.panelForTabs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "GwtMainForm";
            this.Text = "GWT - Izabela Dyba";
            this.Load += new System.EventHandler(this.GwtMainForm_Load);
            this.panelForTabs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBuyers)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSellers)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pGW2TPLink.ResumeLayout(false);
            this.pGW2TPLink.PerformLayout();
            this.pWikiLink.ResumeLayout(false);
            this.pWikiLink.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelForTabs;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbSellers;
        private System.Windows.Forms.DataGridView dgBuyers;
        private System.Windows.Forms.Label lSellers;
        private System.Windows.Forms.DataGridView dgSellers;
        private System.Windows.Forms.CheckBox cbBuyers;
        private System.Windows.Forms.Label lBuyers;
        private System.Windows.Forms.Panel pGW2TPLink;
        private System.Windows.Forms.LinkLabel linkGW2tp;
        private System.Windows.Forms.Panel pWikiLink;
        private System.Windows.Forms.LinkLabel linkWiki;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellers;
    }
}

