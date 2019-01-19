namespace GWT.Client.Views
{
    partial class ItemViewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.labelObjectName = new System.Windows.Forms.Label();
            this.labelProfitExpected = new System.Windows.Forms.Label();
            this.labelSellCost = new System.Windows.Forms.Label();
            this.labelBuyCost = new System.Windows.Forms.Label();
            this.lSELL = new System.Windows.Forms.Label();
            this.lPROFIT = new System.Windows.Forms.Label();
            this.lBUY = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Controls.Add(this.labelObjectName);
            this.mainPanel.Controls.Add(this.labelProfitExpected);
            this.mainPanel.Controls.Add(this.labelSellCost);
            this.mainPanel.Controls.Add(this.labelBuyCost);
            this.mainPanel.Controls.Add(this.lSELL);
            this.mainPanel.Controls.Add(this.lPROFIT);
            this.mainPanel.Controls.Add(this.lBUY);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(106, 160);
            this.mainPanel.TabIndex = 0;
            // 
            // labelObjectName
            // 
            this.labelObjectName.AutoSize = true;
            this.labelObjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelObjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelObjectName.Location = new System.Drawing.Point(3, 0);
            this.labelObjectName.Name = "labelObjectName";
            this.labelObjectName.Size = new System.Drawing.Size(2, 17);
            this.labelObjectName.TabIndex = 15;
            // 
            // labelProfitExpected
            // 
            this.labelProfitExpected.AutoSize = true;
            this.labelProfitExpected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProfitExpected.Location = new System.Drawing.Point(25, 129);
            this.labelProfitExpected.Name = "labelProfitExpected";
            this.labelProfitExpected.Size = new System.Drawing.Size(23, 17);
            this.labelProfitExpected.TabIndex = 14;
            this.labelProfitExpected.Text = "---";
            // 
            // labelSellCost
            // 
            this.labelSellCost.AutoSize = true;
            this.labelSellCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSellCost.Location = new System.Drawing.Point(25, 98);
            this.labelSellCost.Name = "labelSellCost";
            this.labelSellCost.Size = new System.Drawing.Size(23, 17);
            this.labelSellCost.TabIndex = 13;
            this.labelSellCost.Text = "---";
            // 
            // labelBuyCost
            // 
            this.labelBuyCost.AutoSize = true;
            this.labelBuyCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuyCost.Location = new System.Drawing.Point(25, 63);
            this.labelBuyCost.Name = "labelBuyCost";
            this.labelBuyCost.Size = new System.Drawing.Size(23, 17);
            this.labelBuyCost.TabIndex = 12;
            this.labelBuyCost.Text = "---";
            // 
            // lSELL
            // 
            this.lSELL.AutoSize = true;
            this.lSELL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSELL.Location = new System.Drawing.Point(3, 98);
            this.lSELL.Name = "lSELL";
            this.lSELL.Size = new System.Drawing.Size(25, 17);
            this.lSELL.TabIndex = 10;
            this.lSELL.Text = "S: ";
            // 
            // lPROFIT
            // 
            this.lPROFIT.AutoSize = true;
            this.lPROFIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPROFIT.Location = new System.Drawing.Point(3, 129);
            this.lPROFIT.Name = "lPROFIT";
            this.lPROFIT.Size = new System.Drawing.Size(25, 17);
            this.lPROFIT.TabIndex = 11;
            this.lPROFIT.Text = "P: ";
            // 
            // lBUY
            // 
            this.lBUY.AutoSize = true;
            this.lBUY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lBUY.Location = new System.Drawing.Point(3, 63);
            this.lBUY.Name = "lBUY";
            this.lBUY.Size = new System.Drawing.Size(25, 17);
            this.lBUY.TabIndex = 9;
            this.lBUY.Text = "B: ";
            // 
            // ItemViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "ItemViewControl";
            this.Size = new System.Drawing.Size(106, 160);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lBUY;
        private System.Windows.Forms.Label lSELL;
        private System.Windows.Forms.Label lPROFIT;
        private System.Windows.Forms.Label labelProfitExpected;
        private System.Windows.Forms.Label labelSellCost;
        private System.Windows.Forms.Label labelBuyCost;
        private System.Windows.Forms.Label labelObjectName;
    }
}
