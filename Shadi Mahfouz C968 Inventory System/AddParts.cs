using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shadi_Mahfouz_C968_Inventory_System
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutSourced_CheckedChanged(object sender, EventArgs e)
        {
            AddPartMacId.Text = "Company Name";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InHouseAdd_CheckedChanged(object sender, EventArgs e)
        {
            AddPartMacId.Text = "Machine ID";
        }

        private void SaveAddPart_Click(object sender, EventArgs e)
        {
            if (AddMaxText < AddMinText) // Prevents saving if Max value is smaller than the Min value
            {
                MessageBox.Show("Min value must be less than max value");
                return;
            }

            if (InHouseAdd.Checked)
            {
                InHouse inHouse = new InHouse((Inventory.Parts.Count + 1), AddNameText, AddInvText, AddPriceText, AddMinText, AddMaxText, int.Parse(AddMacIdText));
                Inventory.AddPart(inHouse);
            }
            else
            {
                OutSourced outSourced = new OutSourced((Inventory.Parts.Count + 1), AddNameText, AddInvText, AddPriceText, AddMinText, AddMaxText, AddMacIdText);
                Inventory.AddPart(outSourced);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void AddNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelAddPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}