
namespace ProNatura_BioLädeli_GmbH
{
    partial class BillScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillScreen));
            this.textBoxBillName = new System.Windows.Forms.TextBox();
            this.textBoxBillText = new System.Windows.Forms.TextBox();
            this.textBoxBillPrice = new System.Windows.Forms.TextBox();
            this.labelBillName = new System.Windows.Forms.Label();
            this.labelBillText = new System.Windows.Forms.Label();
            this.labelBillPrice = new System.Windows.Forms.Label();
            this.DGVBill = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBill)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBillName
            // 
            this.textBoxBillName.Location = new System.Drawing.Point(153, 26);
            this.textBoxBillName.Name = "textBoxBillName";
            this.textBoxBillName.Size = new System.Drawing.Size(205, 23);
            this.textBoxBillName.TabIndex = 0;
            // 
            // textBoxBillText
            // 
            this.textBoxBillText.Location = new System.Drawing.Point(153, 71);
            this.textBoxBillText.Name = "textBoxBillText";
            this.textBoxBillText.Size = new System.Drawing.Size(100, 23);
            this.textBoxBillText.TabIndex = 1;
            // 
            // textBoxBillPrice
            // 
            this.textBoxBillPrice.Location = new System.Drawing.Point(153, 119);
            this.textBoxBillPrice.Name = "textBoxBillPrice";
            this.textBoxBillPrice.Size = new System.Drawing.Size(100, 23);
            this.textBoxBillPrice.TabIndex = 3;
            // 
            // labelBillName
            // 
            this.labelBillName.AutoSize = true;
            this.labelBillName.Location = new System.Drawing.Point(13, 34);
            this.labelBillName.Name = "labelBillName";
            this.labelBillName.Size = new System.Drawing.Size(124, 15);
            this.labelBillName.TabIndex = 4;
            this.labelBillName.Text = "Rechnungsempfänger";
            // 
            // labelBillText
            // 
            this.labelBillText.AutoSize = true;
            this.labelBillText.Location = new System.Drawing.Point(13, 79);
            this.labelBillText.Name = "labelBillText";
            this.labelBillText.Size = new System.Drawing.Size(86, 15);
            this.labelBillText.TabIndex = 5;
            this.labelBillText.Text = "Rechnungstext";
            // 
            // labelBillPrice
            // 
            this.labelBillPrice.AutoSize = true;
            this.labelBillPrice.Location = new System.Drawing.Point(13, 127);
            this.labelBillPrice.Name = "labelBillPrice";
            this.labelBillPrice.Size = new System.Drawing.Size(32, 15);
            this.labelBillPrice.TabIndex = 6;
            this.labelBillPrice.Text = "Preis";
            // 
            // DGVBill
            // 
            this.DGVBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBill.GridColor = System.Drawing.Color.Maroon;
            this.DGVBill.Location = new System.Drawing.Point(13, 162);
            this.DGVBill.Name = "DGVBill";
            this.DGVBill.RowTemplate.Height = 25;
            this.DGVBill.Size = new System.Drawing.Size(775, 215);
            this.DGVBill.TabIndex = 7;
            // 
            // BillScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.DGVBill);
            this.Controls.Add(this.labelBillPrice);
            this.Controls.Add(this.labelBillText);
            this.Controls.Add(this.labelBillName);
            this.Controls.Add(this.textBoxBillPrice);
            this.Controls.Add(this.textBoxBillText);
            this.Controls.Add(this.textBoxBillName);
            this.Name = "BillScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechnungen";
            ((System.ComponentModel.ISupportInitialize)(this.DGVBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBillName;
        private System.Windows.Forms.TextBox textBoxBillText;
        private System.Windows.Forms.TextBox textBoxBillPrice;
        private System.Windows.Forms.Label labelBillName;
        private System.Windows.Forms.Label labelBillText;
        private System.Windows.Forms.Label labelBillPrice;
        private System.Windows.Forms.DataGridView DGVBill;
    }
}