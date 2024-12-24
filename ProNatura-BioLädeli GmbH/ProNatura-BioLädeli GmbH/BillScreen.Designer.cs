
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
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductClear = new System.Windows.Forms.Button();
            this.btnProductEdit = new System.Windows.Forms.Button();
            this.btnProductSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBill)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBillName
            // 
            this.textBoxBillName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxBillName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBillName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxBillName.ForeColor = System.Drawing.Color.Black;
            this.textBoxBillName.Location = new System.Drawing.Point(153, 33);
            this.textBoxBillName.Name = "textBoxBillName";
            this.textBoxBillName.Size = new System.Drawing.Size(205, 22);
            this.textBoxBillName.TabIndex = 0;
            // 
            // textBoxBillText
            // 
            this.textBoxBillText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxBillText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBillText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxBillText.Location = new System.Drawing.Point(153, 78);
            this.textBoxBillText.Name = "textBoxBillText";
            this.textBoxBillText.Size = new System.Drawing.Size(100, 22);
            this.textBoxBillText.TabIndex = 1;
            // 
            // textBoxBillPrice
            // 
            this.textBoxBillPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxBillPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBillPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxBillPrice.Location = new System.Drawing.Point(153, 126);
            this.textBoxBillPrice.Name = "textBoxBillPrice";
            this.textBoxBillPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxBillPrice.TabIndex = 3;
            // 
            // labelBillName
            // 
            this.labelBillName.AutoSize = true;
            this.labelBillName.BackColor = System.Drawing.Color.Transparent;
            this.labelBillName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBillName.ForeColor = System.Drawing.Color.White;
            this.labelBillName.Location = new System.Drawing.Point(13, 34);
            this.labelBillName.Name = "labelBillName";
            this.labelBillName.Size = new System.Drawing.Size(130, 15);
            this.labelBillName.TabIndex = 4;
            this.labelBillName.Text = "Rechnungsempfänger";
            // 
            // labelBillText
            // 
            this.labelBillText.AutoSize = true;
            this.labelBillText.BackColor = System.Drawing.Color.Transparent;
            this.labelBillText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBillText.ForeColor = System.Drawing.Color.White;
            this.labelBillText.Location = new System.Drawing.Point(13, 79);
            this.labelBillText.Name = "labelBillText";
            this.labelBillText.Size = new System.Drawing.Size(92, 15);
            this.labelBillText.TabIndex = 5;
            this.labelBillText.Text = "Rechnungstext";
            // 
            // labelBillPrice
            // 
            this.labelBillPrice.AutoSize = true;
            this.labelBillPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelBillPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBillPrice.ForeColor = System.Drawing.Color.White;
            this.labelBillPrice.Location = new System.Drawing.Point(13, 127);
            this.labelBillPrice.Name = "labelBillPrice";
            this.labelBillPrice.Size = new System.Drawing.Size(34, 15);
            this.labelBillPrice.TabIndex = 6;
            this.labelBillPrice.Text = "Preis";
            // 
            // DGVBill
            // 
            this.DGVBill.AllowUserToAddRows = false;
            this.DGVBill.AllowUserToDeleteRows = false;
            this.DGVBill.AllowUserToResizeColumns = false;
            this.DGVBill.AllowUserToResizeRows = false;
            this.DGVBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBill.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGVBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBill.GridColor = System.Drawing.SystemColors.Control;
            this.DGVBill.Location = new System.Drawing.Point(72, 215);
            this.DGVBill.MultiSelect = false;
            this.DGVBill.Name = "DGVBill";
            this.DGVBill.ReadOnly = true;
            this.DGVBill.RowHeadersVisible = false;
            this.DGVBill.RowTemplate.Height = 25;
            this.DGVBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVBill.Size = new System.Drawing.Size(794, 250);
            this.DGVBill.TabIndex = 7;
            this.DGVBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBill_CellContentClick);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BackColor = System.Drawing.Color.White;
            this.btnProductDelete.FlatAppearance.BorderSize = 2;
            this.btnProductDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductDelete.ForeColor = System.Drawing.Color.Black;
            this.btnProductDelete.Location = new System.Drawing.Point(431, 169);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(71, 30);
            this.btnProductDelete.TabIndex = 16;
            this.btnProductDelete.Text = "Löschen";
            this.btnProductDelete.UseVisualStyleBackColor = false;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductClear
            // 
            this.btnProductClear.BackColor = System.Drawing.Color.White;
            this.btnProductClear.FlatAppearance.BorderSize = 2;
            this.btnProductClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductClear.ForeColor = System.Drawing.Color.Black;
            this.btnProductClear.Location = new System.Drawing.Point(321, 169);
            this.btnProductClear.Name = "btnProductClear";
            this.btnProductClear.Size = new System.Drawing.Size(104, 30);
            this.btnProductClear.TabIndex = 15;
            this.btnProductClear.Text = "Felder leeren";
            this.btnProductClear.UseVisualStyleBackColor = false;
            this.btnProductClear.Click += new System.EventHandler(this.btnProductClear_Click);
            // 
            // btnProductEdit
            // 
            this.btnProductEdit.BackColor = System.Drawing.Color.White;
            this.btnProductEdit.FlatAppearance.BorderSize = 2;
            this.btnProductEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductEdit.ForeColor = System.Drawing.Color.Black;
            this.btnProductEdit.Location = new System.Drawing.Point(238, 169);
            this.btnProductEdit.Name = "btnProductEdit";
            this.btnProductEdit.Size = new System.Drawing.Size(77, 30);
            this.btnProductEdit.TabIndex = 14;
            this.btnProductEdit.Text = "Bearbeiten";
            this.btnProductEdit.UseVisualStyleBackColor = false;
            this.btnProductEdit.Click += new System.EventHandler(this.btnProductEdit_Click);
            // 
            // btnProductSave
            // 
            this.btnProductSave.BackColor = System.Drawing.Color.White;
            this.btnProductSave.FlatAppearance.BorderSize = 2;
            this.btnProductSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductSave.ForeColor = System.Drawing.Color.Black;
            this.btnProductSave.Location = new System.Drawing.Point(153, 169);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(79, 30);
            this.btnProductSave.TabIndex = 13;
            this.btnProductSave.Text = "Speichern";
            this.btnProductSave.UseVisualStyleBackColor = false;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // BillScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(941, 505);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductClear);
            this.Controls.Add(this.btnProductEdit);
            this.Controls.Add(this.btnProductSave);
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
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductClear;
        private System.Windows.Forms.Button btnProductEdit;
        private System.Windows.Forms.Button btnProductSave;
    }
}