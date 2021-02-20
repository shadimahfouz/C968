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

        private void OutSourced_CheckedChanged(object sender, EventArgs e) //Changes Machine ID label to Company Name is outsourced radio is checked
        {
            AddPartMacId.Text = "Company Name";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InHouseAdd_CheckedChanged(object sender, EventArgs e) //Sets Machine ID to last text box if in house radio is checked
        {
            AddPartMacId.Text = "Machine ID";
        }

        private void SaveAddPart_Click(object sender, EventArgs e) //Save function that makes sure that maximum value exceed minimum value and that the inventory value sits in between min and max
        {
            if (addPartMaxBox < addPartMinBox)
            {
                MessageBox.Show("Error: Maximum field value must exceed minimum field value.");
                return;
            }

            if ((addPartInvBox < addPartMinBox) || (addPartInvBox > addPartMaxBox))
            {
                MessageBox.Show("Error: Inventory value must be between minimum and maximum values.");
            }

            if (InHouseAdd.Checked)
            {
                InHouse inHouse = new InHouse((Inventory.Parts.Count + 1), addPartNameBox, addPartInvBox, addPartPriceBox, addPartMinBox, addPartMaxBox, int.Parse(addPartMacIdBox));
                Inventory.AddPart(inHouse);
            }
            else
            {
                OutSourced outSourced = new OutSourced((Inventory.Parts.Count + 1), addPartNameBox, addPartInvBox, addPartPriceBox, addPartMinBox, addPartMaxBox, addPartMacIdBox);
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

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        private void AddIdText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void AddInvText_KeyPress(object sender, KeyPressEventArgs e) //Handles non numeric values entered into a number only field
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void AddPriceText_KeyPress(object sender, KeyPressEventArgs e) //Handles non numeric values entered into a number only field
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void AddMaxText_KeyPress(object sender, KeyPressEventArgs e) //Handles non numeric values entered into a number only field
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void AddMinText_KeyPress(object sender, KeyPressEventArgs e) //Handles non numeric values entered into a number only field
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void AddMacIdText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMacIdText_KeyPress(object sender, KeyPressEventArgs e) //Handles non numeric values entered into a number only field only when InHouse radio button is checked
        {
            if (InHouseAdd.Checked == true)
            {
                if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }
    }
}