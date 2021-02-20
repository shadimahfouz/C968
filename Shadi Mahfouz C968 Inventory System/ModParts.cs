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
    public partial class ModPart : Form
    {
        Form1 mainScreen = (Form1) Application.OpenForms["Form1"];

        public ModPart(InHouse inHousePart) //Sets values to public variables to be set to data grid if in house part
        {
            InitializeComponent();

            modPartIdBox = inHousePart.partId;
            modPartNameBox = inHousePart.partName;
            modPartInvBox = inHousePart.partInStock;
            modPartPriceBox = Decimal.Parse(inHousePart.partPrice.Substring(1));
            modPartMinBox = inHousePart.partMin;
            modPartMaxBox = inHousePart.partMax;
            modPartMachIdBox = inHousePart.machineId.ToString();
        }

        public ModPart(OutSourced outsourcedPart) //Sets values to public variables to be set to data grid if outsourced part
        {
            InitializeComponent();

            modPartIdBox = outsourcedPart.partId;
            modPartNameBox = outsourcedPart.partName;
            modPartInvBox = outsourcedPart.partInStock;
            modPartPriceBox = Decimal.Parse(outsourcedPart.partPrice.Substring(1));
            modPartMinBox = outsourcedPart.partMin;
            modPartMaxBox = outsourcedPart.partMax;
            modPartMachIdBox = outsourcedPart.compName;

            OutsourcedMod.Checked = true;
        }

        private void ModPart_Load(object sender, EventArgs e)
        {

        }

        private void OutsourcedMod_CheckedChanged(object sender, EventArgs e) //Changes Machine ID label to Company Name is Outsourced radio button is checked
        {
            ModPartMacId.Text = "Company Name";
        }

        private void SaveModPart_Click(object sender, EventArgs e) //Save function that checks to make sure that the maximum value entered exceeds the minimum value and that the inventory values is between the min and max
        {
            if (modPartMaxBox < modPartMinBox)
            {
                MessageBox.Show("Error: Maximum field value must exceed minimum field value.");
                return;
            }

            if ((modPartInvBox < modPartMinBox) || (modPartInvBox > modPartMaxBox))
            {
                MessageBox.Show("Error: Inventory value must be between minimum and maximum values.");
            }

            if (InHouseMod.Checked)
            {
                InHouse inHousePart = new InHouse(modPartIdBox, modPartNameBox, modPartInvBox, modPartPriceBox, modPartMinBox, modPartMaxBox, int.Parse(modPartMachIdBox));
                Inventory.UpdateInhousePart(modPartIdBox, inHousePart);
                InHouseMod.Checked = true;
            }
            else
            {
                OutSourced outSourcedPart = new OutSourced(modPartIdBox, modPartNameBox, modPartInvBox, modPartPriceBox, modPartMinBox, modPartMaxBox, modPartMachIdBox);
                Inventory.UpdateOutsourcedPart(modPartIdBox, outSourcedPart);
                OutsourcedMod.Checked = true;
            }
            this.Close();

            mainScreen.PartGrid.Update();
            mainScreen.PartGrid.Refresh();
        }

        private void InHouseMod_CheckedChanged(object sender, EventArgs e) //Makes label for last text box Machine ID if radio button is checked 
        {
            ModPartMacId.Text = "Machine ID";
        }

        private void CancelModPart_Click(object sender, EventArgs e) //Cancel function
        {
            this.Close();
        }

        private void ModIdText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ModIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void ModInvText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void ModPriceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void ModMaxText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModMaxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void ModMinText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void ModMacIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (InHouseMod.Checked == true) //Handles non numeric values entered into a number only field only when the InHouse radio button is checked
            {
                if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
