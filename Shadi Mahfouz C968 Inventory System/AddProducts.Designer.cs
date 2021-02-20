
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
            ((System.ComponentModel.ISupportInitialize)(this.CandPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsAssocGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProdLabel
            // 
            this.AddProdLabel.AutoSize = true;
            this.AddProdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProdLabel.Location = new System.Drawing.Point(9, 7);
            this.AddProdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddProdLabel.Name = "AddProdLabel";
            this.AddProdLabel.Size = new System.Drawing.Size(97, 17);
            this.AddProdLabel.TabIndex = 0;
            this.AddProdLabel.Text = "Add Product";
            // 
            // CandPartsGrid
            // 
            this.CandPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandPartsGrid.Location = new System.Drawing.Point(269, 53);
            this.CandPartsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.CandPartsGrid.Name = "CandPartsGrid";
            this.CandPartsGrid.RowHeadersWidth = 51;
            this.CandPartsGrid.RowTemplate.Height = 24;
            this.CandPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CandPartsGrid.Size = new System.Drawing.Size(602, 172);
            this.CandPartsGrid.TabIndex = 1;
            // 
            // PartsAssocGrid
            // 
            this.PartsAssocGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsAssocGrid.Location = new System.Drawing.Point(269, 276);
            this.PartsAssocGrid.Margin = new System.Windows.Forms.Padding(2);
            this.PartsAssocGrid.Name = "PartsAssocGrid";
            this.PartsAssocGrid.RowHeadersWidth = 51;
            this.PartsAssocGrid.RowTemplate.Height = 24;
            this.PartsAssocGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsAssocGrid.Size = new System.Drawing.Size(602, 172);
            this.PartsAssocGrid.TabIndex = 2;
            this.PartsAssocGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsAssocGrid_CellContentClick);
            // 
            // AddProdMinText
            // 
            this.AddProdMinText.Location = new System.Drawing.Point(172, 310);
            this.AddProdMinText.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.AddProdMinText.Name = "AddProdMinText";
            this.AddProdMinText.Size = new System.Drawing.Size(58, 20);
            this.AddProdMinText.TabIndex = 3;
            this.AddProdMinText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProdMinText_KeyPress);
            // 
            // AddProdMaxText
            // 
            this.AddProdMaxText.Location = new System.Drawing.Point(80, 310);
            this.AddProdMaxText.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.AddProdMaxText.Name = "AddProdMaxText";
            this.AddProdMaxText.Size = new System.Drawing.Size(58, 20);
            this.AddProdMaxText.TabIndex = 4;
            this.AddProdMaxText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProdMaxText_KeyPress);
            // 
            // AddProdPriceText
            // 
            this.AddProdPriceText.Location = new System.Drawing.Point(80, 275);
            this.AddProdPriceText.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.AddProdPriceText.Name = "AddProdPriceText";
            this.AddProdPriceText.Size = new System.Drawing.Size(117, 20);
            this.AddProdPriceText.TabIndex = 5;
            this.AddProdPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProdPriceText_KeyPress);
            // 
            // AddProdInvText
            // 
            this.AddProdInvText.Location = new System.Drawing.Point(80, 241);
            this.AddProdInvText.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.AddProdInvText.Name = "AddProdInvText";
            this.AddProdInvText.Size = new System.Drawing.Size(117, 20);
            this.AddProdInvText.TabIndex = 6;
            this.AddProdInvText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProdInvText_KeyPress);
            // 
            // AddProdNameText
            // 
            this.AddProdNameText.Location = new System.Drawing.Point(80, 207);
            this.AddProdNameText.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.AddProdNameText.Name = "AddProdNameText";
            this.AddProdNameText.Size = new System.Drawing.Size(117, 20);
            this.AddProdNameText.TabIndex = 7;
            // 
            // AddProdIdText
            // 
            this.AddProdIdText.Location = new System.Drawing.Point(80, 173);
            this.AddProdIdText.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.AddProdIdText.Name = "AddProdIdText";
            this.AddProdIdText.Size = new System.Drawing.Size(117, 20);
            this.AddProdIdText.TabIndex = 8;
            this.AddProdIdText.TextChanged += new System.EventHandler(this.AddProdIdText_TextChanged);
            this.AddProdIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProdIdText_KeyPress);
            // 
            // AddProdSearchText
            // 
            this.AddProdSearchText.Location = new System.Drawing.Point(631, 30);
            this.AddProdSearchText.Margin = new System.Windows.Forms.Padding(2);
            this.AddProdSearchText.Name = "AddProdSearchText";
            this.AddProdSearchText.Size = new System.Drawing.Size(242, 20);
            this.AddProdSearchText.TabIndex = 9;
            this.AddProdSearchText.TextChanged += new System.EventHandler(this.AddProdSearchText_TextChanged);
            this.AddProdSearchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProdSearchText_KeyPress);
            // 
            // AddProdId
            // 
            this.AddProdId.AutoSize = true;
            this.AddProdId.Location = new System.Drawing.Point(60, 176);
            this.AddProdId.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.AddProdId.Name = "AddProdId";
            this.AddProdId.Size = new System.Drawing.Size(18, 13);
            this.AddProdId.TabIndex = 11;
            this.AddProdId.Text = "ID";
            // 
            // AddProdName
            // 
            this.AddProdName.AutoSize = true;
            this.AddProdName.Location = new System.Drawing.Point(42, 210);
            this.AddProdName.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.AddProdName.Name = "AddProdName";
            this.AddProdName.Size = new System.Drawing.Size(35, 13);
            this.AddProdName.TabIndex = 12;
            this.AddProdName.Text = "Name";
            // 
            // AddProdInv
            // 
            this.AddProdInv.AutoSize = true;
            this.AddProdInv.Location = new System.Drawing.Point(26, 244);
            this.AddProdInv.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.AddProdInv.Name = "AddProdInv";
            this.AddProdInv.Size = new System.Drawing.Size(51, 13);
            this.AddProdInv.TabIndex = 13;
            this.AddProdInv.Text = "Inventory";
            // 
            // AddProdPrice
            // 
            this.AddProdPrice.AutoSize = true;
            this.AddProdPrice.Location = new System.Drawing.Point(46, 278);
            this.AddProdPrice.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.AddProdPrice.Name = "AddProdPrice";
            this.AddProdPrice.Size = new System.Drawing.Size(31, 13);
            this.AddProdPrice.TabIndex = 14;
            this.AddProdPrice.Text = "Price";
            // 
            // AddProdMax
            // 
            this.AddProdMax.AutoSize = true;
            this.AddProdMax.Location = new System.Drawing.Point(51, 312);
            this.AddProdMax.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.AddProdMax.Name = "AddProdMax";
            this.AddProdMax.Size = new System.Drawing.Size(27, 13);
            this.AddProdMax.TabIndex = 15;
            this.AddProdMax.Text = "Max";
            // 
            // AddProdMin
            // 
            this.AddProdMin.AutoSize = true;
            this.AddProdMin.Location = new System.Drawing.Point(145, 312);
            this.AddProdMin.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.AddProdMin.Name = "AddProdMin";
            this.AddProdMin.Size = new System.Drawing.Size(24, 13);
            this.AddProdMin.TabIndex = 16;
            this.AddProdMin.Text = "Min";
            // 
            // CandPartsLabel
            // 
            this.CandPartsLabel.AutoSize = true;
            this.CandPartsLabel.Location = new System.Drawing.Point(267, 35);
            this.CandPartsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CandPartsLabel.Name = "CandPartsLabel";
            this.CandPartsLabel.Size = new System.Drawing.Size(96, 13);
            this.CandPartsLabel.TabIndex = 17;
            this.CandPartsLabel.Text = "All Candidate Parts";
            // 
            // PartsAssocLabel
            // 
            this.PartsAssocLabel.AutoSize = true;
            this.PartsAssocLabel.Location = new System.Drawing.Point(267, 260);
            this.PartsAssocLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PartsAssocLabel.Name = "PartsAssocLabel";
            this.PartsAssocLabel.Size = new System.Drawing.Size(167, 13);
            this.PartsAssocLabel.TabIndex = 18;
            this.PartsAssocLabel.Text = "Parts Associated with this Product";
            // 
            // AddProdAdd
            // 
            this.AddProdAdd.Location = new System.Drawing.Point(823, 230);
            this.AddProdAdd.Margin = new System.Windows.Forms.Padding(2);
            this.AddProdAdd.Name = "AddProdAdd";
            this.AddProdAdd.Size = new System.Drawing.Size(49, 23);
            this.AddProdAdd.TabIndex = 19;
            this.AddProdAdd.Text = "Add";
            this.AddProdAdd.UseVisualStyleBackColor = true;
            this.AddProdAdd.Click += new System.EventHandler(this.AddProdAdd_Click);
            // 
            // AddProdDel
            // 
            this.AddProdDel.Location = new System.Drawing.Point(823, 453);
            this.AddProdDel.Margin = new System.Windows.Forms.Padding(2);
            this.AddProdDel.Name = "AddProdDel";
            this.AddProdDel.Size = new System.Drawing.Size(49, 23);
            this.AddProdDel.TabIndex = 20;
            this.AddProdDel.Text = "Delete";
            this.AddProdDel.UseVisualStyleBackColor = true;
            this.AddProdDel.Click += new System.EventHandler(this.AddProdDel_Click);
            // 
            // AddProdSearch
            // 
            this.AddProdSearch.Location = new System.Drawing.Point(570, 30);
            this.AddProdSearch.Margin = new System.Windows.Forms.Padding(2);
            this.AddProdSearch.Name = "AddProdSearch";
            this.AddProdSearch.Size = new System.Drawing.Size(56, 19);
            this.AddProdSearch.TabIndex = 21;
            this.AddProdSearch.Text = "Search";
            this.AddProdSearch.UseVisualStyleBackColor = true;
            this.AddProdSearch.Click += new System.EventHandler(this.AddProdSearch_Click);
            // 
            // AddProdSave
            // 
            this.AddProdSave.Location = new System.Drawing.Point(750, 509);
            this.AddProdSave.Margin = new System.Windows.Forms.Padding(2);
            this.AddProdSave.Name = "AddProdSave";
            this.AddProdSave.Size = new System.Drawing.Size(49, 23);
            this.AddProdSave.TabIndex = 22;
            this.AddProdSave.Text = "Save";
            this.AddProdSave.UseVisualStyleBackColor = true;
            this.AddProdSave.Click += new System.EventHandler(this.AddProdSave_Click);
            // 
            // AddProdCancel
            // 
            this.AddProdCancel.Location = new System.Drawing.Point(823, 509);
            this.AddProdCancel.Margin = new System.Windows.Forms.Padding(2);
            this.AddProdCancel.Name = "AddProdCancel";
            this.AddProdCancel.Size = new System.Drawing.Size(49, 23);
            this.AddProdCancel.TabIndex = 23;
            this.AddProdCancel.Text = "Cancel";
            this.AddProdCancel.UseVisualStyleBackColor = true;
            this.AddProdCancel.Click += new System.EventHandler(this.AddProdCancel_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 553);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddProduct";
            this.Text = "Add Products";
            this.Load += new System.EventHandler(this.AddProduct_Load);
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

        //Connects public variables to text boxes via getters and setters
        public int addProdIdBox
        {
            get { return int.Parse(AddProdIdText.Text); }
            set { AddProdIdText.Text = value.ToString(); }
        }

        public string addProdNameBox
        {
            get { return AddProdNameText.Text; }
            set { AddProdNameText.Text = value; }
        }

        public int addProdInvBox
        {
            get { return int.Parse(AddProdInvText.Text); }
            set { AddProdInvText.Text = value.ToString(); }
        }

        public decimal addProdPriceBox
        {
            get { return decimal.Parse(AddProdPriceText.Text); }
            set { AddProdPriceText.Text = value.ToString(); }
        }

        public int addProdMinBox
        {
            get { return int.Parse(AddProdMinText.Text); }
            set { AddProdMinText.Text = value.ToString(); }
        }

        public int addProdMaxBox
        {
            get { return int.Parse(AddProdMaxText.Text); }
            set { AddProdMaxText.Text = value.ToString(); }
        }
    }
}