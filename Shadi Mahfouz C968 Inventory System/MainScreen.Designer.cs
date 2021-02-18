
namespace Shadi_Mahfouz_C968_Inventory_System
{
    partial class Form1
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
            this.PartGrid = new System.Windows.Forms.DataGridView();
            this.MainPartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPartInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPartMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPartMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdGrid = new System.Windows.Forms.DataGridView();
            this.MainProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainProdInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainProdMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainProdMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductLabel = new System.Windows.Forms.TextBox();
            this.PartLabel = new System.Windows.Forms.TextBox();
            this.SearchPartBox = new System.Windows.Forms.TextBox();
            this.SearchProdBox = new System.Windows.Forms.TextBox();
            this.SearchParts = new System.Windows.Forms.Button();
            this.SearchProducts = new System.Windows.Forms.Button();
            this.AddParts = new System.Windows.Forms.Button();
            this.ModifyParts = new System.Windows.Forms.Button();
            this.DeleteParts = new System.Windows.Forms.Button();
            this.AddProducts = new System.Windows.Forms.Button();
            this.ModifyProducts = new System.Windows.Forms.Button();
            this.DeleteProducts = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.MainScreenLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PartGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PartGrid
            // 
            this.PartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MainPartId,
            this.MainPartName,
            this.MainPartInv,
            this.MainPartPrice,
            this.MainPartMin,
            this.MainPartMax});
            this.PartGrid.Location = new System.Drawing.Point(45, 190);
            this.PartGrid.Margin = new System.Windows.Forms.Padding(4);
            this.PartGrid.Name = "PartGrid";
            this.PartGrid.RowHeadersWidth = 51;
            this.PartGrid.Size = new System.Drawing.Size(803, 455);
            this.PartGrid.TabIndex = 2;
            // 
            // MainPartId
            // 
            this.MainPartId.HeaderText = "Part ID";
            this.MainPartId.MinimumWidth = 6;
            this.MainPartId.Name = "MainPartId";
            this.MainPartId.Width = 125;
            // 
            // MainPartName
            // 
            this.MainPartName.HeaderText = "Name";
            this.MainPartName.MinimumWidth = 6;
            this.MainPartName.Name = "MainPartName";
            this.MainPartName.Width = 125;
            // 
            // MainPartInv
            // 
            this.MainPartInv.HeaderText = "Inventory";
            this.MainPartInv.MinimumWidth = 6;
            this.MainPartInv.Name = "MainPartInv";
            this.MainPartInv.Width = 125;
            // 
            // MainPartPrice
            // 
            this.MainPartPrice.HeaderText = "Price";
            this.MainPartPrice.MinimumWidth = 6;
            this.MainPartPrice.Name = "MainPartPrice";
            this.MainPartPrice.Width = 125;
            // 
            // MainPartMin
            // 
            this.MainPartMin.HeaderText = "Min";
            this.MainPartMin.MinimumWidth = 6;
            this.MainPartMin.Name = "MainPartMin";
            this.MainPartMin.Width = 125;
            // 
            // MainPartMax
            // 
            this.MainPartMax.HeaderText = "Max";
            this.MainPartMax.MinimumWidth = 6;
            this.MainPartMax.Name = "MainPartMax";
            this.MainPartMax.Width = 125;
            // 
            // ProdGrid
            // 
            this.ProdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MainProdId,
            this.MainProdName,
            this.MainProdInv,
            this.MainProdPrice,
            this.MainProdMin,
            this.MainProdMax});
            this.ProdGrid.Location = new System.Drawing.Point(908, 190);
            this.ProdGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ProdGrid.Name = "ProdGrid";
            this.ProdGrid.RowHeadersWidth = 51;
            this.ProdGrid.Size = new System.Drawing.Size(804, 455);
            this.ProdGrid.TabIndex = 3;
            // 
            // MainProdId
            // 
            this.MainProdId.HeaderText = "Product ID";
            this.MainProdId.MinimumWidth = 6;
            this.MainProdId.Name = "MainProdId";
            this.MainProdId.Width = 125;
            // 
            // MainProdName
            // 
            this.MainProdName.HeaderText = "Name";
            this.MainProdName.MinimumWidth = 6;
            this.MainProdName.Name = "MainProdName";
            this.MainProdName.Width = 125;
            // 
            // MainProdInv
            // 
            this.MainProdInv.HeaderText = "Inventory";
            this.MainProdInv.MinimumWidth = 6;
            this.MainProdInv.Name = "MainProdInv";
            this.MainProdInv.Width = 125;
            // 
            // MainProdPrice
            // 
            this.MainProdPrice.HeaderText = "Price";
            this.MainProdPrice.MinimumWidth = 6;
            this.MainProdPrice.Name = "MainProdPrice";
            this.MainProdPrice.Width = 125;
            // 
            // MainProdMin
            // 
            this.MainProdMin.HeaderText = "Min";
            this.MainProdMin.MinimumWidth = 6;
            this.MainProdMin.Name = "MainProdMin";
            this.MainProdMin.Width = 125;
            // 
            // MainProdMax
            // 
            this.MainProdMax.HeaderText = "Max";
            this.MainProdMax.MinimumWidth = 6;
            this.MainProdMax.Name = "MainProdMax";
            this.MainProdMax.Width = 125;
            // 
            // ProductLabel
            // 
            this.ProductLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProductLabel.Location = new System.Drawing.Point(908, 161);
            this.ProductLabel.Margin = new System.Windows.Forms.Padding(4);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.ReadOnly = true;
            this.ProductLabel.Size = new System.Drawing.Size(133, 23);
            this.ProductLabel.TabIndex = 4;
            this.ProductLabel.Text = "Products";
            // 
            // PartLabel
            // 
            this.PartLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PartLabel.Location = new System.Drawing.Point(45, 159);
            this.PartLabel.Margin = new System.Windows.Forms.Padding(4);
            this.PartLabel.Name = "PartLabel";
            this.PartLabel.ReadOnly = true;
            this.PartLabel.Size = new System.Drawing.Size(133, 23);
            this.PartLabel.TabIndex = 5;
            this.PartLabel.Text = "Parts";
            // 
            // SearchPartBox
            // 
            this.SearchPartBox.Location = new System.Drawing.Point(573, 160);
            this.SearchPartBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchPartBox.Name = "SearchPartBox";
            this.SearchPartBox.Size = new System.Drawing.Size(275, 22);
            this.SearchPartBox.TabIndex = 6;
            // 
            // SearchProdBox
            // 
            this.SearchProdBox.Location = new System.Drawing.Point(1437, 160);
            this.SearchProdBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchProdBox.Name = "SearchProdBox";
            this.SearchProdBox.Size = new System.Drawing.Size(275, 22);
            this.SearchProdBox.TabIndex = 7;
            // 
            // SearchParts
            // 
            this.SearchParts.Location = new System.Drawing.Point(465, 158);
            this.SearchParts.Margin = new System.Windows.Forms.Padding(4);
            this.SearchParts.Name = "SearchParts";
            this.SearchParts.Size = new System.Drawing.Size(100, 25);
            this.SearchParts.TabIndex = 8;
            this.SearchParts.Text = "Search";
            this.SearchParts.UseVisualStyleBackColor = true;
            // 
            // SearchProducts
            // 
            this.SearchProducts.Location = new System.Drawing.Point(1329, 158);
            this.SearchProducts.Margin = new System.Windows.Forms.Padding(4);
            this.SearchProducts.Name = "SearchProducts";
            this.SearchProducts.Size = new System.Drawing.Size(100, 25);
            this.SearchProducts.TabIndex = 9;
            this.SearchProducts.Text = "Search";
            this.SearchProducts.UseVisualStyleBackColor = true;
            // 
            // AddParts
            // 
            this.AddParts.Location = new System.Drawing.Point(532, 653);
            this.AddParts.Margin = new System.Windows.Forms.Padding(4);
            this.AddParts.Name = "AddParts";
            this.AddParts.Size = new System.Drawing.Size(100, 37);
            this.AddParts.TabIndex = 10;
            this.AddParts.Text = "Add";
            this.AddParts.UseVisualStyleBackColor = true;
            // 
            // ModifyParts
            // 
            this.ModifyParts.Location = new System.Drawing.Point(640, 653);
            this.ModifyParts.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyParts.Name = "ModifyParts";
            this.ModifyParts.Size = new System.Drawing.Size(100, 37);
            this.ModifyParts.TabIndex = 11;
            this.ModifyParts.Text = "Modify";
            this.ModifyParts.UseVisualStyleBackColor = true;
            // 
            // DeleteParts
            // 
            this.DeleteParts.Location = new System.Drawing.Point(748, 653);
            this.DeleteParts.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteParts.Name = "DeleteParts";
            this.DeleteParts.Size = new System.Drawing.Size(100, 37);
            this.DeleteParts.TabIndex = 12;
            this.DeleteParts.Text = "Delete";
            this.DeleteParts.UseVisualStyleBackColor = true;
            // 
            // AddProducts
            // 
            this.AddProducts.Location = new System.Drawing.Point(1397, 653);
            this.AddProducts.Margin = new System.Windows.Forms.Padding(4);
            this.AddProducts.Name = "AddProducts";
            this.AddProducts.Size = new System.Drawing.Size(100, 37);
            this.AddProducts.TabIndex = 13;
            this.AddProducts.Text = "Add";
            this.AddProducts.UseVisualStyleBackColor = true;
            // 
            // ModifyProducts
            // 
            this.ModifyProducts.Location = new System.Drawing.Point(1505, 653);
            this.ModifyProducts.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyProducts.Name = "ModifyProducts";
            this.ModifyProducts.Size = new System.Drawing.Size(100, 37);
            this.ModifyProducts.TabIndex = 14;
            this.ModifyProducts.Text = "Modify";
            this.ModifyProducts.UseVisualStyleBackColor = true;
            // 
            // DeleteProducts
            // 
            this.DeleteProducts.Location = new System.Drawing.Point(1613, 653);
            this.DeleteProducts.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteProducts.Name = "DeleteProducts";
            this.DeleteProducts.Size = new System.Drawing.Size(100, 37);
            this.DeleteProducts.TabIndex = 15;
            this.DeleteProducts.Text = "Delete";
            this.DeleteProducts.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1613, 733);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 37);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // MainScreenLabel
            // 
            this.MainScreenLabel.AutoSize = true;
            this.MainScreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.MainScreenLabel.Location = new System.Drawing.Point(617, 9);
            this.MainScreenLabel.Name = "MainScreenLabel";
            this.MainScreenLabel.Size = new System.Drawing.Size(575, 31);
            this.MainScreenLabel.TabIndex = 17;
            this.MainScreenLabel.Text = "Inventory Management System Home Page";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(736, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Shadi Mahfouz | ID# 001423923 | 02/17/2021";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1765, 795);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainScreenLabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DeleteProducts);
            this.Controls.Add(this.ModifyProducts);
            this.Controls.Add(this.AddProducts);
            this.Controls.Add(this.DeleteParts);
            this.Controls.Add(this.ModifyParts);
            this.Controls.Add(this.AddParts);
            this.Controls.Add(this.SearchProducts);
            this.Controls.Add(this.SearchParts);
            this.Controls.Add(this.SearchProdBox);
            this.Controls.Add(this.SearchPartBox);
            this.Controls.Add(this.PartLabel);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.ProdGrid);
            this.Controls.Add(this.PartGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.PartGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PartGrid;
        private System.Windows.Forms.DataGridView ProdGrid;
        private System.Windows.Forms.TextBox ProductLabel;
        private System.Windows.Forms.TextBox PartLabel;
        private System.Windows.Forms.TextBox SearchPartBox;
        private System.Windows.Forms.TextBox SearchProdBox;
        private System.Windows.Forms.Button SearchParts;
        private System.Windows.Forms.Button SearchProducts;
        private System.Windows.Forms.Button AddParts;
        private System.Windows.Forms.Button ModifyParts;
        private System.Windows.Forms.Button DeleteParts;
        private System.Windows.Forms.Button AddProducts;
        private System.Windows.Forms.Button ModifyProducts;
        private System.Windows.Forms.Button DeleteProducts;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainPartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainPartInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainPartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainPartMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainPartMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainProdInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainProdMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainProdMax;
        private System.Windows.Forms.Label MainScreenLabel;
        private System.Windows.Forms.Label label1;
    }
}

