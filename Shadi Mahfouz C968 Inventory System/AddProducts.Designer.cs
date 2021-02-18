
namespace Shadi_Mahfouz_C968_Inventory_System
{
    partial class AddProduct
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
            this.AddProdLabel = new System.Windows.Forms.Label();
            this.CandPartsGrid = new System.Windows.Forms.DataGridView();
            this.PartsAssocGrid = new System.Windows.Forms.DataGridView();
            this.AddProdMinText = new System.Windows.Forms.TextBox();
            this.AddProdMaxText = new System.Windows.Forms.TextBox();
            this.AddProdPriceText = new System.Windows.Forms.TextBox();
            this.AddProdInvText = new System.Windows.Forms.TextBox();
            this.AddProdNameText = new System.Windows.Forms.TextBox();
            this.AddProdIdText = new System.Windows.Forms.TextBox();
            this.AddProdSearchText = new System.Windows.Forms.TextBox();
            this.AddProdId = new System.Windows.Forms.Label();
            this.AddProdName = new System.Windows.Forms.Label();
            this.AddProdInv = new System.Windows.Forms.Label();
            this.AddProdPrice = new System.Windows.Forms.Label();
            this.AddProdMax = new System.Windows.Forms.Label();
            this.AddProdMin = new System.Windows.Forms.Label();
            this.CandPartsLabel = new System.Windows.Forms.Label();
            this.PartsAssocLabel = new System.Windows.Forms.Label();
            this.AddProdAdd = new System.Windows.Forms.Button();
            this.AddProdDel = new System.Windows.Forms.Button();
            this.AddProdSearch = new System.Windows.Forms.Button();
            this.AddProdSave = new System.Windows.Forms.Button();
            this.AddProdCancel = new System.Windows.Forms.Button();
            this.PartsAssocId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsAssocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsAssocInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsAssocPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsAssocMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsAssocMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandPartsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandPartInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandProdMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandProdMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CandPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsAssocGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProdLabel
            // 
            this.AddProdLabel.AutoSize = true;
            this.AddProdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProdLabel.Location = new System.Drawing.Point(12, 9);
            this.AddProdLabel.Name = "AddProdLabel";
            this.AddProdLabel.Size = new System.Drawing.Size(112, 20);
            this.AddProdLabel.TabIndex = 0;
            this.AddProdLabel.Text = "Add Product";
            // 
            // CandPartsGrid
            // 
            this.CandPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandPartsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CandPartsId,
            this.CandPartName,
            this.CandPartInv,
            this.CandProdPrice,
            this.CandProdMin,
            this.CandProdMax});
            this.CandPartsGrid.Location = new System.Drawing.Point(359, 65);
            this.CandPartsGrid.Name = "CandPartsGrid";
            this.CandPartsGrid.RowHeadersWidth = 51;
            this.CandPartsGrid.RowTemplate.Height = 24;
            this.CandPartsGrid.Size = new System.Drawing.Size(803, 212);
            this.CandPartsGrid.TabIndex = 1;
            // 
            // PartsAssocGrid
            // 
            this.PartsAssocGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsAssocGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartsAssocId,
            this.PartsAssocName,
            this.PartsAssocInv,
            this.PartsAssocPrice,
            this.PartsAssocMin,
            this.PartsAssocMax});
            this.PartsAssocGrid.Location = new System.Drawing.Point(359, 340);
            this.PartsAssocGrid.Name = "PartsAssocGrid";
            this.PartsAssocGrid.RowHeadersWidth = 51;
            this.PartsAssocGrid.RowTemplate.Height = 24;
            this.PartsAssocGrid.Size = new System.Drawing.Size(803, 212);
            this.PartsAssocGrid.TabIndex = 2;
            // 
            // AddProdMinText
            // 
            this.AddProdMinText.Location = new System.Drawing.Point(229, 381);
            this.AddProdMinText.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.AddProdMinText.Name = "AddProdMinText";
            this.AddProdMinText.Size = new System.Drawing.Size(76, 22);
            this.AddProdMinText.TabIndex = 3;
            // 
            // AddProdMaxText
            // 
            this.AddProdMaxText.Location = new System.Drawing.Point(107, 381);
            this.AddProdMaxText.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.AddProdMaxText.Name = "AddProdMaxText";
            this.AddProdMaxText.Size = new System.Drawing.Size(76, 22);
            this.AddProdMaxText.TabIndex = 4;
            // 
            // AddProdPriceText
            // 
            this.AddProdPriceText.Location = new System.Drawing.Point(107, 339);
            this.AddProdPriceText.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.AddProdPriceText.Name = "AddProdPriceText";
            this.AddProdPriceText.Size = new System.Drawing.Size(155, 22);
            this.AddProdPriceText.TabIndex = 5;
            // 
            // AddProdInvText
            // 
            this.AddProdInvText.Location = new System.Drawing.Point(107, 297);
            this.AddProdInvText.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.AddProdInvText.Name = "AddProdInvText";
            this.AddProdInvText.Size = new System.Drawing.Size(155, 22);
            this.AddProdInvText.TabIndex = 6;
            // 
            // AddProdNameText
            // 
            this.AddProdNameText.Location = new System.Drawing.Point(107, 255);
            this.AddProdNameText.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.AddProdNameText.Name = "AddProdNameText";
            this.AddProdNameText.Size = new System.Drawing.Size(155, 22);
            this.AddProdNameText.TabIndex = 7;
            // 
            // AddProdIdText
            // 
            this.AddProdIdText.Location = new System.Drawing.Point(107, 213);
            this.AddProdIdText.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.AddProdIdText.Name = "AddProdIdText";
            this.AddProdIdText.Size = new System.Drawing.Size(155, 22);
            this.AddProdIdText.TabIndex = 8;
            // 
            // AddProdSearchText
            // 
            this.AddProdSearchText.Location = new System.Drawing.Point(841, 37);
            this.AddProdSearchText.Name = "AddProdSearchText";
            this.AddProdSearchText.Size = new System.Drawing.Size(321, 22);
            this.AddProdSearchText.TabIndex = 9;
            // 
            // AddProdId
            // 
            this.AddProdId.AutoSize = true;
            this.AddProdId.Location = new System.Drawing.Point(80, 216);
            this.AddProdId.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.AddProdId.Name = "AddProdId";
            this.AddProdId.Size = new System.Drawing.Size(21, 17);
            this.AddProdId.TabIndex = 11;
            this.AddProdId.Text = "ID";
            // 
            // AddProdName
            // 
            this.AddProdName.AutoSize = true;
            this.AddProdName.Location = new System.Drawing.Point(56, 258);
            this.AddProdName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.AddProdName.Name = "AddProdName";
            this.AddProdName.Size = new System.Drawing.Size(45, 17);
            this.AddProdName.TabIndex = 12;
            this.AddProdName.Text = "Name";
            // 
            // AddProdInv
            // 
            this.AddProdInv.AutoSize = true;
            this.AddProdInv.Location = new System.Drawing.Point(35, 300);
            this.AddProdInv.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.AddProdInv.Name = "AddProdInv";
            this.AddProdInv.Size = new System.Drawing.Size(66, 17);
            this.AddProdInv.TabIndex = 13;
            this.AddProdInv.Text = "Inventory";
            // 
            // AddProdPrice
            // 
            this.AddProdPrice.AutoSize = true;
            this.AddProdPrice.Location = new System.Drawing.Point(61, 342);
            this.AddProdPrice.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.AddProdPrice.Name = "AddProdPrice";
            this.AddProdPrice.Size = new System.Drawing.Size(40, 17);
            this.AddProdPrice.TabIndex = 14;
            this.AddProdPrice.Text = "Price";
            // 
            // AddProdMax
            // 
            this.AddProdMax.AutoSize = true;
            this.AddProdMax.Location = new System.Drawing.Point(68, 384);
            this.AddProdMax.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.AddProdMax.Name = "AddProdMax";
            this.AddProdMax.Size = new System.Drawing.Size(33, 17);
            this.AddProdMax.TabIndex = 15;
            this.AddProdMax.Text = "Max";
            // 
            // AddProdMin
            // 
            this.AddProdMin.AutoSize = true;
            this.AddProdMin.Location = new System.Drawing.Point(193, 384);
            this.AddProdMin.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.AddProdMin.Name = "AddProdMin";
            this.AddProdMin.Size = new System.Drawing.Size(30, 17);
            this.AddProdMin.TabIndex = 16;
            this.AddProdMin.Text = "Min";
            // 
            // CandPartsLabel
            // 
            this.CandPartsLabel.AutoSize = true;
            this.CandPartsLabel.Location = new System.Drawing.Point(356, 43);
            this.CandPartsLabel.Name = "CandPartsLabel";
            this.CandPartsLabel.Size = new System.Drawing.Size(128, 17);
            this.CandPartsLabel.TabIndex = 17;
            this.CandPartsLabel.Text = "All Candidate Parts";
            // 
            // PartsAssocLabel
            // 
            this.PartsAssocLabel.AutoSize = true;
            this.PartsAssocLabel.Location = new System.Drawing.Point(356, 320);
            this.PartsAssocLabel.Name = "PartsAssocLabel";
            this.PartsAssocLabel.Size = new System.Drawing.Size(221, 17);
            this.PartsAssocLabel.TabIndex = 18;
            this.PartsAssocLabel.Text = "Parts Associated with this Product";
            // 
            // AddProdAdd
            // 
            this.AddProdAdd.Location = new System.Drawing.Point(1097, 283);
            this.AddProdAdd.Name = "AddProdAdd";
            this.AddProdAdd.Size = new System.Drawing.Size(65, 28);
            this.AddProdAdd.TabIndex = 19;
            this.AddProdAdd.Text = "Add";
            this.AddProdAdd.UseVisualStyleBackColor = true;
            // 
            // AddProdDel
            // 
            this.AddProdDel.Location = new System.Drawing.Point(1097, 558);
            this.AddProdDel.Name = "AddProdDel";
            this.AddProdDel.Size = new System.Drawing.Size(65, 28);
            this.AddProdDel.TabIndex = 20;
            this.AddProdDel.Text = "Delete";
            this.AddProdDel.UseVisualStyleBackColor = true;
            // 
            // AddProdSearch
            // 
            this.AddProdSearch.Location = new System.Drawing.Point(760, 37);
            this.AddProdSearch.Name = "AddProdSearch";
            this.AddProdSearch.Size = new System.Drawing.Size(75, 23);
            this.AddProdSearch.TabIndex = 21;
            this.AddProdSearch.Text = "Search";
            this.AddProdSearch.UseVisualStyleBackColor = true;
            // 
            // AddProdSave
            // 
            this.AddProdSave.Location = new System.Drawing.Point(1000, 627);
            this.AddProdSave.Name = "AddProdSave";
            this.AddProdSave.Size = new System.Drawing.Size(65, 28);
            this.AddProdSave.TabIndex = 22;
            this.AddProdSave.Text = "Save";
            this.AddProdSave.UseVisualStyleBackColor = true;
            // 
            // AddProdCancel
            // 
            this.AddProdCancel.Location = new System.Drawing.Point(1097, 627);
            this.AddProdCancel.Name = "AddProdCancel";
            this.AddProdCancel.Size = new System.Drawing.Size(65, 28);
            this.AddProdCancel.TabIndex = 23;
            this.AddProdCancel.Text = "Cancel";
            this.AddProdCancel.UseVisualStyleBackColor = true;
            // 
            // PartsAssocId
            // 
            this.PartsAssocId.HeaderText = "Part ID";
            this.PartsAssocId.MinimumWidth = 6;
            this.PartsAssocId.Name = "PartsAssocId";
            this.PartsAssocId.Width = 125;
            // 
            // PartsAssocName
            // 
            this.PartsAssocName.HeaderText = "Name";
            this.PartsAssocName.MinimumWidth = 6;
            this.PartsAssocName.Name = "PartsAssocName";
            this.PartsAssocName.Width = 125;
            // 
            // PartsAssocInv
            // 
            this.PartsAssocInv.HeaderText = "Inventory";
            this.PartsAssocInv.MinimumWidth = 6;
            this.PartsAssocInv.Name = "PartsAssocInv";
            this.PartsAssocInv.Width = 125;
            // 
            // PartsAssocPrice
            // 
            this.PartsAssocPrice.HeaderText = "Price";
            this.PartsAssocPrice.MinimumWidth = 6;
            this.PartsAssocPrice.Name = "PartsAssocPrice";
            this.PartsAssocPrice.Width = 125;
            // 
            // PartsAssocMin
            // 
            this.PartsAssocMin.HeaderText = "Min";
            this.PartsAssocMin.MinimumWidth = 6;
            this.PartsAssocMin.Name = "PartsAssocMin";
            this.PartsAssocMin.Width = 125;
            // 
            // PartsAssocMax
            // 
            this.PartsAssocMax.HeaderText = "Max";
            this.PartsAssocMax.MinimumWidth = 6;
            this.PartsAssocMax.Name = "PartsAssocMax";
            this.PartsAssocMax.Width = 125;
            // 
            // CandPartsId
            // 
            this.CandPartsId.HeaderText = "Part ID";
            this.CandPartsId.MinimumWidth = 6;
            this.CandPartsId.Name = "CandPartsId";
            this.CandPartsId.Width = 125;
            // 
            // CandPartName
            // 
            this.CandPartName.HeaderText = "Name";
            this.CandPartName.MinimumWidth = 6;
            this.CandPartName.Name = "CandPartName";
            this.CandPartName.Width = 125;
            // 
            // CandPartInv
            // 
            this.CandPartInv.HeaderText = "Inventory";
            this.CandPartInv.MinimumWidth = 6;
            this.CandPartInv.Name = "CandPartInv";
            this.CandPartInv.Width = 125;
            // 
            // CandProdPrice
            // 
            this.CandProdPrice.HeaderText = "Price";
            this.CandProdPrice.MinimumWidth = 6;
            this.CandProdPrice.Name = "CandProdPrice";
            this.CandProdPrice.Width = 125;
            // 
            // CandProdMin
            // 
            this.CandProdMin.HeaderText = "Min";
            this.CandProdMin.MinimumWidth = 6;
            this.CandProdMin.Name = "CandProdMin";
            this.CandProdMin.Width = 125;
            // 
            // CandProdMax
            // 
            this.CandProdMax.HeaderText = "Max";
            this.CandProdMax.MinimumWidth = 6;
            this.CandProdMax.Name = "CandProdMax";
            this.CandProdMax.Width = 125;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 681);
            this.Controls.Add(this.AddProdCancel);
            this.Controls.Add(this.AddProdSave);
            this.Controls.Add(this.AddProdSearch);
            this.Controls.Add(this.AddProdDel);
            this.Controls.Add(this.AddProdAdd);
            this.Controls.Add(this.PartsAssocLabel);
            this.Controls.Add(this.CandPartsLabel);
            this.Controls.Add(this.AddProdMin);
            this.Controls.Add(this.AddProdMax);
            this.Controls.Add(this.AddProdPrice);
            this.Controls.Add(this.AddProdInv);
            this.Controls.Add(this.AddProdName);
            this.Controls.Add(this.AddProdId);
            this.Controls.Add(this.AddProdSearchText);
            this.Controls.Add(this.AddProdIdText);
            this.Controls.Add(this.AddProdNameText);
            this.Controls.Add(this.AddProdInvText);
            this.Controls.Add(this.AddProdPriceText);
            this.Controls.Add(this.AddProdMaxText);
            this.Controls.Add(this.AddProdMinText);
            this.Controls.Add(this.PartsAssocGrid);
            this.Controls.Add(this.CandPartsGrid);
            this.Controls.Add(this.AddProdLabel);
            this.Name = "AddProduct";
            this.Text = "Add Products";
            ((System.ComponentModel.ISupportInitialize)(this.CandPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsAssocGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProdLabel;
        private System.Windows.Forms.DataGridView CandPartsGrid;
        private System.Windows.Forms.DataGridView PartsAssocGrid;
        private System.Windows.Forms.TextBox AddProdMinText;
        private System.Windows.Forms.TextBox AddProdMaxText;
        private System.Windows.Forms.TextBox AddProdPriceText;
        private System.Windows.Forms.TextBox AddProdInvText;
        private System.Windows.Forms.TextBox AddProdNameText;
        private System.Windows.Forms.TextBox AddProdIdText;
        private System.Windows.Forms.TextBox AddProdSearchText;
        private System.Windows.Forms.Label AddProdId;
        private System.Windows.Forms.Label AddProdName;
        private System.Windows.Forms.Label AddProdInv;
        private System.Windows.Forms.Label AddProdPrice;
        private System.Windows.Forms.Label AddProdMax;
        private System.Windows.Forms.Label AddProdMin;
        private System.Windows.Forms.Label CandPartsLabel;
        private System.Windows.Forms.Label PartsAssocLabel;
        private System.Windows.Forms.Button AddProdAdd;
        private System.Windows.Forms.Button AddProdDel;
        private System.Windows.Forms.Button AddProdSearch;
        private System.Windows.Forms.Button AddProdSave;
        private System.Windows.Forms.Button AddProdCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandPartsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandPartInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandProdMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandProdMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsAssocId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsAssocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsAssocInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsAssocPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsAssocMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsAssocMax;
    }
}