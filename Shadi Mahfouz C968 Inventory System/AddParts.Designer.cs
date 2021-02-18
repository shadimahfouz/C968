
namespace Shadi_Mahfouz_C968_Inventory_System
{
    partial class AddPart
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
            this.InHouseAdd = new System.Windows.Forms.RadioButton();
            this.OutsourcedAdd = new System.Windows.Forms.RadioButton();
            this.AddPartLabel = new System.Windows.Forms.Label();
            this.AddMacIdText = new System.Windows.Forms.TextBox();
            this.AddIdText = new System.Windows.Forms.TextBox();
            this.AddNameText = new System.Windows.Forms.TextBox();
            this.AddInvText = new System.Windows.Forms.TextBox();
            this.AddPriceText = new System.Windows.Forms.TextBox();
            this.AddMaxText = new System.Windows.Forms.TextBox();
            this.AddMinText = new System.Windows.Forms.TextBox();
            this.SaveAddPart = new System.Windows.Forms.Button();
            this.CancelAddPart = new System.Windows.Forms.Button();
            this.AddPartId = new System.Windows.Forms.Label();
            this.AddPartName = new System.Windows.Forms.Label();
            this.AddPartInv = new System.Windows.Forms.Label();
            this.AddPartPrice = new System.Windows.Forms.Label();
            this.AddPartMax = new System.Windows.Forms.Label();
            this.AddPartMin = new System.Windows.Forms.Label();
            this.AddPartMacId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InHouseAdd
            // 
            this.InHouseAdd.AutoSize = true;
            this.InHouseAdd.Location = new System.Drawing.Point(162, 12);
            this.InHouseAdd.Name = "InHouseAdd";
            this.InHouseAdd.Size = new System.Drawing.Size(86, 21);
            this.InHouseAdd.TabIndex = 3;
            this.InHouseAdd.TabStop = true;
            this.InHouseAdd.Text = "In-House";
            this.InHouseAdd.UseVisualStyleBackColor = true;
            // 
            // OutsourcedAdd
            // 
            this.OutsourcedAdd.AutoSize = true;
            this.OutsourcedAdd.Location = new System.Drawing.Point(261, 12);
            this.OutsourcedAdd.Name = "OutsourcedAdd";
            this.OutsourcedAdd.Size = new System.Drawing.Size(103, 21);
            this.OutsourcedAdd.TabIndex = 4;
            this.OutsourcedAdd.TabStop = true;
            this.OutsourcedAdd.Text = "Outsourced";
            this.OutsourcedAdd.UseVisualStyleBackColor = true;
            this.OutsourcedAdd.CheckedChanged += new System.EventHandler(this.OutSourced_CheckedChanged);
            // 
            // AddPartLabel
            // 
            this.AddPartLabel.AutoSize = true;
            this.AddPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartLabel.Location = new System.Drawing.Point(12, 13);
            this.AddPartLabel.Name = "AddPartLabel";
            this.AddPartLabel.Size = new System.Drawing.Size(82, 20);
            this.AddPartLabel.TabIndex = 5;
            this.AddPartLabel.Text = "Add Part";
            // 
            // AddMacIdText
            // 
            this.AddMacIdText.Location = new System.Drawing.Point(146, 220);
            this.AddMacIdText.Name = "AddMacIdText";
            this.AddMacIdText.Size = new System.Drawing.Size(100, 22);
            this.AddMacIdText.TabIndex = 6;
            // 
            // AddIdText
            // 
            this.AddIdText.Location = new System.Drawing.Point(146, 80);
            this.AddIdText.Name = "AddIdText";
            this.AddIdText.Size = new System.Drawing.Size(100, 22);
            this.AddIdText.TabIndex = 7;
            // 
            // AddNameText
            // 
            this.AddNameText.Location = new System.Drawing.Point(146, 108);
            this.AddNameText.Name = "AddNameText";
            this.AddNameText.Size = new System.Drawing.Size(100, 22);
            this.AddNameText.TabIndex = 8;
            // 
            // AddInvText
            // 
            this.AddInvText.Location = new System.Drawing.Point(146, 136);
            this.AddInvText.Name = "AddInvText";
            this.AddInvText.Size = new System.Drawing.Size(100, 22);
            this.AddInvText.TabIndex = 9;
            // 
            // AddPriceText
            // 
            this.AddPriceText.Location = new System.Drawing.Point(146, 164);
            this.AddPriceText.Name = "AddPriceText";
            this.AddPriceText.Size = new System.Drawing.Size(100, 22);
            this.AddPriceText.TabIndex = 10;
            // 
            // AddMaxText
            // 
            this.AddMaxText.Location = new System.Drawing.Point(146, 192);
            this.AddMaxText.Name = "AddMaxText";
            this.AddMaxText.Size = new System.Drawing.Size(76, 22);
            this.AddMaxText.TabIndex = 11;
            this.AddMaxText.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // AddMinText
            // 
            this.AddMinText.Location = new System.Drawing.Point(278, 192);
            this.AddMinText.Name = "AddMinText";
            this.AddMinText.Size = new System.Drawing.Size(76, 22);
            this.AddMinText.TabIndex = 12;
            // 
            // SaveAddPart
            // 
            this.SaveAddPart.Location = new System.Drawing.Point(183, 269);
            this.SaveAddPart.Name = "SaveAddPart";
            this.SaveAddPart.Size = new System.Drawing.Size(65, 28);
            this.SaveAddPart.TabIndex = 13;
            this.SaveAddPart.Text = "Save";
            this.SaveAddPart.UseVisualStyleBackColor = true;
            // 
            // CancelAddPart
            // 
            this.CancelAddPart.Location = new System.Drawing.Point(289, 269);
            this.CancelAddPart.Name = "CancelAddPart";
            this.CancelAddPart.Size = new System.Drawing.Size(65, 28);
            this.CancelAddPart.TabIndex = 14;
            this.CancelAddPart.Text = "Cancel";
            this.CancelAddPart.UseVisualStyleBackColor = true;
            // 
            // AddPartId
            // 
            this.AddPartId.AutoSize = true;
            this.AddPartId.Location = new System.Drawing.Point(119, 83);
            this.AddPartId.Name = "AddPartId";
            this.AddPartId.Size = new System.Drawing.Size(21, 17);
            this.AddPartId.TabIndex = 15;
            this.AddPartId.Text = "ID";
            // 
            // AddPartName
            // 
            this.AddPartName.AutoSize = true;
            this.AddPartName.Location = new System.Drawing.Point(95, 111);
            this.AddPartName.Name = "AddPartName";
            this.AddPartName.Size = new System.Drawing.Size(45, 17);
            this.AddPartName.TabIndex = 16;
            this.AddPartName.Text = "Name";
            this.AddPartName.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddPartInv
            // 
            this.AddPartInv.AutoSize = true;
            this.AddPartInv.Location = new System.Drawing.Point(74, 139);
            this.AddPartInv.Name = "AddPartInv";
            this.AddPartInv.Size = new System.Drawing.Size(66, 17);
            this.AddPartInv.TabIndex = 17;
            this.AddPartInv.Text = "Inventory";
            // 
            // AddPartPrice
            // 
            this.AddPartPrice.AutoSize = true;
            this.AddPartPrice.Location = new System.Drawing.Point(68, 167);
            this.AddPartPrice.Name = "AddPartPrice";
            this.AddPartPrice.Size = new System.Drawing.Size(72, 17);
            this.AddPartPrice.TabIndex = 18;
            this.AddPartPrice.Text = "Price/Cost";
            // 
            // AddPartMax
            // 
            this.AddPartMax.AutoSize = true;
            this.AddPartMax.Location = new System.Drawing.Point(107, 192);
            this.AddPartMax.Name = "AddPartMax";
            this.AddPartMax.Size = new System.Drawing.Size(33, 17);
            this.AddPartMax.TabIndex = 19;
            this.AddPartMax.Text = "Max";
            // 
            // AddPartMin
            // 
            this.AddPartMin.AutoSize = true;
            this.AddPartMin.Location = new System.Drawing.Point(242, 192);
            this.AddPartMin.Name = "AddPartMin";
            this.AddPartMin.Size = new System.Drawing.Size(30, 17);
            this.AddPartMin.TabIndex = 20;
            this.AddPartMin.Text = "Min";
            // 
            // AddPartMacId
            // 
            this.AddPartMacId.AutoSize = true;
            this.AddPartMacId.Location = new System.Drawing.Point(62, 223);
            this.AddPartMacId.Name = "AddPartMacId";
            this.AddPartMacId.Size = new System.Drawing.Size(78, 17);
            this.AddPartMacId.TabIndex = 21;
            this.AddPartMacId.Text = "Machine ID";
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 334);
            this.Controls.Add(this.AddPartMacId);
            this.Controls.Add(this.AddPartMin);
            this.Controls.Add(this.AddPartMax);
            this.Controls.Add(this.AddPartPrice);
            this.Controls.Add(this.AddPartInv);
            this.Controls.Add(this.AddPartName);
            this.Controls.Add(this.AddPartId);
            this.Controls.Add(this.CancelAddPart);
            this.Controls.Add(this.SaveAddPart);
            this.Controls.Add(this.AddMinText);
            this.Controls.Add(this.AddMaxText);
            this.Controls.Add(this.AddPriceText);
            this.Controls.Add(this.AddInvText);
            this.Controls.Add(this.AddNameText);
            this.Controls.Add(this.AddIdText);
            this.Controls.Add(this.AddMacIdText);
            this.Controls.Add(this.AddPartLabel);
            this.Controls.Add(this.OutsourcedAdd);
            this.Controls.Add(this.InHouseAdd);
            this.Name = "AddPart";
            this.Text = "Add Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton InHouseAdd;
        private System.Windows.Forms.RadioButton OutsourcedAdd;
        private System.Windows.Forms.Label AddPartLabel;
        private System.Windows.Forms.TextBox AddMacIdText;
        private System.Windows.Forms.TextBox AddIdText;
        private System.Windows.Forms.TextBox AddNameText;
        private System.Windows.Forms.TextBox AddInvText;
        private System.Windows.Forms.TextBox AddPriceText;
        private System.Windows.Forms.TextBox AddMaxText;
        private System.Windows.Forms.TextBox AddMinText;
        private System.Windows.Forms.Button SaveAddPart;
        private System.Windows.Forms.Button CancelAddPart;
        private System.Windows.Forms.Label AddPartId;
        private System.Windows.Forms.Label AddPartName;
        private System.Windows.Forms.Label AddPartInv;
        private System.Windows.Forms.Label AddPartPrice;
        private System.Windows.Forms.Label AddPartMax;
        private System.Windows.Forms.Label AddPartMin;
        private System.Windows.Forms.Label AddPartMacId;
    }
}