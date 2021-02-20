
namespace Shadi_Mahfouz_C968_Inventory_System
{
    partial class ModPart
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
            this.ModPartLabel = new System.Windows.Forms.Label();
            this.InHouseMod = new System.Windows.Forms.RadioButton();
            this.OutsourcedMod = new System.Windows.Forms.RadioButton();
            this.ModMinText = new System.Windows.Forms.TextBox();
            this.ModMaxText = new System.Windows.Forms.TextBox();
            this.ModMacIdText = new System.Windows.Forms.TextBox();
            this.ModIdText = new System.Windows.Forms.TextBox();
            this.ModPriceText = new System.Windows.Forms.TextBox();
            this.ModInvText = new System.Windows.Forms.TextBox();
            this.ModNameText = new System.Windows.Forms.TextBox();
            this.SaveModPart = new System.Windows.Forms.Button();
            this.CancelModPart = new System.Windows.Forms.Button();
            this.ModPartId = new System.Windows.Forms.Label();
            this.AddPartName = new System.Windows.Forms.Label();
            this.ModPartInv = new System.Windows.Forms.Label();
            this.ModPartPrice = new System.Windows.Forms.Label();
            this.ModPartMin = new System.Windows.Forms.Label();
            this.ModPartMax = new System.Windows.Forms.Label();
            this.ModPartMacId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModPartLabel
            // 
            this.ModPartLabel.AutoSize = true;
            this.ModPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModPartLabel.Location = new System.Drawing.Point(9, 7);
            this.ModPartLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModPartLabel.Name = "ModPartLabel";
            this.ModPartLabel.Size = new System.Drawing.Size(90, 17);
            this.ModPartLabel.TabIndex = 0;
            this.ModPartLabel.Text = "Modify Part";
            // 
            // InHouseMod
            // 
            this.InHouseMod.AutoSize = true;
            this.InHouseMod.Location = new System.Drawing.Point(169, 11);
            this.InHouseMod.Margin = new System.Windows.Forms.Padding(2);
            this.InHouseMod.Name = "InHouseMod";
            this.InHouseMod.Size = new System.Drawing.Size(68, 17);
            this.InHouseMod.TabIndex = 1;
            this.InHouseMod.TabStop = true;
            this.InHouseMod.Text = "In-House";
            this.InHouseMod.UseVisualStyleBackColor = true;
            this.InHouseMod.CheckedChanged += new System.EventHandler(this.InHouseMod_CheckedChanged);
            // 
            // OutsourcedMod
            // 
            this.OutsourcedMod.AutoSize = true;
            this.OutsourcedMod.Location = new System.Drawing.Point(238, 11);
            this.OutsourcedMod.Margin = new System.Windows.Forms.Padding(2);
            this.OutsourcedMod.Name = "OutsourcedMod";
            this.OutsourcedMod.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedMod.TabIndex = 2;
            this.OutsourcedMod.TabStop = true;
            this.OutsourcedMod.Text = "Outsourced";
            this.OutsourcedMod.UseVisualStyleBackColor = true;
            this.OutsourcedMod.CheckedChanged += new System.EventHandler(this.OutsourcedMod_CheckedChanged);
            // 
            // ModMinText
            // 
            this.ModMinText.Location = new System.Drawing.Point(229, 166);
            this.ModMinText.Margin = new System.Windows.Forms.Padding(2);
            this.ModMinText.Name = "ModMinText";
            this.ModMinText.Size = new System.Drawing.Size(58, 20);
            this.ModMinText.TabIndex = 3;
            this.ModMinText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModMinText_KeyPress);
            // 
            // ModMaxText
            // 
            this.ModMaxText.Location = new System.Drawing.Point(132, 166);
            this.ModMaxText.Margin = new System.Windows.Forms.Padding(2);
            this.ModMaxText.Name = "ModMaxText";
            this.ModMaxText.Size = new System.Drawing.Size(58, 20);
            this.ModMaxText.TabIndex = 4;
            this.ModMaxText.TextChanged += new System.EventHandler(this.ModMaxText_TextChanged);
            this.ModMaxText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModMaxText_KeyPress);
            // 
            // ModMacIdText
            // 
            this.ModMacIdText.Location = new System.Drawing.Point(132, 188);
            this.ModMacIdText.Margin = new System.Windows.Forms.Padding(2);
            this.ModMacIdText.Name = "ModMacIdText";
            this.ModMacIdText.Size = new System.Drawing.Size(116, 20);
            this.ModMacIdText.TabIndex = 5;
            this.ModMacIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModMacIdText_KeyPress);
            // 
            // ModIdText
            // 
            this.ModIdText.Location = new System.Drawing.Point(132, 75);
            this.ModIdText.Margin = new System.Windows.Forms.Padding(2);
            this.ModIdText.Name = "ModIdText";
            this.ModIdText.Size = new System.Drawing.Size(76, 20);
            this.ModIdText.TabIndex = 6;
            this.ModIdText.TextChanged += new System.EventHandler(this.ModIdText_TextChanged);
            this.ModIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModIdText_KeyPress);
            // 
            // ModPriceText
            // 
            this.ModPriceText.Location = new System.Drawing.Point(132, 143);
            this.ModPriceText.Margin = new System.Windows.Forms.Padding(2);
            this.ModPriceText.Name = "ModPriceText";
            this.ModPriceText.Size = new System.Drawing.Size(76, 20);
            this.ModPriceText.TabIndex = 7;
            this.ModPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModPriceText_KeyPress);
            // 
            // ModInvText
            // 
            this.ModInvText.Location = new System.Drawing.Point(132, 121);
            this.ModInvText.Margin = new System.Windows.Forms.Padding(2);
            this.ModInvText.Name = "ModInvText";
            this.ModInvText.Size = new System.Drawing.Size(76, 20);
            this.ModInvText.TabIndex = 8;
            this.ModInvText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModInvText_KeyPress);
            // 
            // ModNameText
            // 
            this.ModNameText.Location = new System.Drawing.Point(132, 98);
            this.ModNameText.Margin = new System.Windows.Forms.Padding(2);
            this.ModNameText.Name = "ModNameText";
            this.ModNameText.Size = new System.Drawing.Size(76, 20);
            this.ModNameText.TabIndex = 9;
            // 
            // SaveModPart
            // 
            this.SaveModPart.Location = new System.Drawing.Point(157, 236);
            this.SaveModPart.Margin = new System.Windows.Forms.Padding(2);
            this.SaveModPart.Name = "SaveModPart";
            this.SaveModPart.Size = new System.Drawing.Size(49, 23);
            this.SaveModPart.TabIndex = 10;
            this.SaveModPart.Text = "Save";
            this.SaveModPart.UseVisualStyleBackColor = true;
            this.SaveModPart.Click += new System.EventHandler(this.SaveModPart_Click);
            // 
            // CancelModPart
            // 
            this.CancelModPart.Location = new System.Drawing.Point(238, 236);
            this.CancelModPart.Margin = new System.Windows.Forms.Padding(2);
            this.CancelModPart.Name = "CancelModPart";
            this.CancelModPart.Size = new System.Drawing.Size(49, 23);
            this.CancelModPart.TabIndex = 11;
            this.CancelModPart.Text = "Cancel";
            this.CancelModPart.UseVisualStyleBackColor = true;
            this.CancelModPart.Click += new System.EventHandler(this.CancelModPart_Click);
            // 
            // ModPartId
            // 
            this.ModPartId.AutoSize = true;
            this.ModPartId.Location = new System.Drawing.Point(81, 78);
            this.ModPartId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModPartId.Name = "ModPartId";
            this.ModPartId.Size = new System.Drawing.Size(18, 13);
            this.ModPartId.TabIndex = 12;
            this.ModPartId.Text = "ID";
            // 
            // AddPartName
            // 
            this.AddPartName.AutoSize = true;
            this.AddPartName.Location = new System.Drawing.Point(63, 103);
            this.AddPartName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddPartName.Name = "AddPartName";
            this.AddPartName.Size = new System.Drawing.Size(35, 13);
            this.AddPartName.TabIndex = 13;
            this.AddPartName.Text = "Name";
            // 
            // ModPartInv
            // 
            this.ModPartInv.AutoSize = true;
            this.ModPartInv.Location = new System.Drawing.Point(47, 126);
            this.ModPartInv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModPartInv.Name = "ModPartInv";
            this.ModPartInv.Size = new System.Drawing.Size(51, 13);
            this.ModPartInv.TabIndex = 14;
            this.ModPartInv.Text = "Inventory";
            // 
            // ModPartPrice
            // 
            this.ModPartPrice.AutoSize = true;
            this.ModPartPrice.Location = new System.Drawing.Point(42, 149);
            this.ModPartPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModPartPrice.Name = "ModPartPrice";
            this.ModPartPrice.Size = new System.Drawing.Size(57, 13);
            this.ModPartPrice.TabIndex = 15;
            this.ModPartPrice.Text = "Price/Cost";
            // 
            // ModPartMin
            // 
            this.ModPartMin.AutoSize = true;
            this.ModPartMin.Location = new System.Drawing.Point(202, 169);
            this.ModPartMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModPartMin.Name = "ModPartMin";
            this.ModPartMin.Size = new System.Drawing.Size(24, 13);
            this.ModPartMin.TabIndex = 16;
            this.ModPartMin.Text = "Min";
            // 
            // ModPartMax
            // 
            this.ModPartMax.AutoSize = true;
            this.ModPartMax.Location = new System.Drawing.Point(72, 172);
            this.ModPartMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModPartMax.Name = "ModPartMax";
            this.ModPartMax.Size = new System.Drawing.Size(27, 13);
            this.ModPartMax.TabIndex = 17;
            this.ModPartMax.Text = "Max";
            // 
            // ModPartMacId
            // 
            this.ModPartMacId.AutoSize = true;
            this.ModPartMacId.Location = new System.Drawing.Point(38, 194);
            this.ModPartMacId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModPartMacId.Name = "ModPartMacId";
            this.ModPartMacId.Size = new System.Drawing.Size(62, 13);
            this.ModPartMacId.TabIndex = 18;
            this.ModPartMacId.Text = "Machine ID";
            // 
            // ModPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 325);
            this.Controls.Add(this.ModPartMacId);
            this.Controls.Add(this.ModPartMax);
            this.Controls.Add(this.ModPartMin);
            this.Controls.Add(this.ModPartPrice);
            this.Controls.Add(this.ModPartInv);
            this.Controls.Add(this.AddPartName);
            this.Controls.Add(this.ModPartId);
            this.Controls.Add(this.CancelModPart);
            this.Controls.Add(this.SaveModPart);
            this.Controls.Add(this.ModNameText);
            this.Controls.Add(this.ModInvText);
            this.Controls.Add(this.ModPriceText);
            this.Controls.Add(this.ModIdText);
            this.Controls.Add(this.ModMacIdText);
            this.Controls.Add(this.ModMaxText);
            this.Controls.Add(this.ModMinText);
            this.Controls.Add(this.OutsourcedMod);
            this.Controls.Add(this.InHouseMod);
            this.Controls.Add(this.ModPartLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModPart";
            this.Text = "Modify Parts";
            this.Load += new System.EventHandler(this.ModPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModPartLabel;
        private System.Windows.Forms.RadioButton InHouseMod;
        private System.Windows.Forms.RadioButton OutsourcedMod;
        private System.Windows.Forms.TextBox ModMinText;
        private System.Windows.Forms.TextBox ModMaxText;
        private System.Windows.Forms.TextBox ModMacIdText;
        private System.Windows.Forms.TextBox ModIdText;
        private System.Windows.Forms.TextBox ModPriceText;
        private System.Windows.Forms.TextBox ModInvText;
        private System.Windows.Forms.TextBox ModNameText;
        private System.Windows.Forms.Button SaveModPart;
        private System.Windows.Forms.Button CancelModPart;
        private System.Windows.Forms.Label ModPartId;
        private System.Windows.Forms.Label AddPartName;
        private System.Windows.Forms.Label ModPartInv;
        private System.Windows.Forms.Label ModPartPrice;
        private System.Windows.Forms.Label ModPartMin;
        private System.Windows.Forms.Label ModPartMax;
        private System.Windows.Forms.Label ModPartMacId;

        //Connects public variables to text boxes via getters and setters
        public int modPartIdBox
        {
            get { return int.Parse(ModIdText.Text); }
            set { ModIdText.Text = value.ToString(); }
        }

        public string modPartNameBox
        {
            get { return ModNameText.Text; }
            set { ModNameText.Text = value; }
        }

        public int modPartInvBox
        {
            get { return int.Parse(ModInvText.Text); }
            set { ModInvText.Text = value.ToString(); }
        }

        public decimal modPartPriceBox
        {
            get { return decimal.Parse(ModPriceText.Text); }
            set { ModPriceText.Text = value.ToString(); }
        }

        public int modPartMinBox
        {
            get { return int.Parse(ModMinText.Text); }
            set { ModMinText.Text = value.ToString(); }
        }

        public int modPartMaxBox
        {
            get { return int.Parse(ModMaxText.Text); }
            set { ModMaxText.Text = value.ToString(); }
        }

        public string modPartMachIdBox
        {
            get { return ModMacIdText.Text; }
            set { ModMacIdText.Text = value; }
        }
    }
}