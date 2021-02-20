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
    public partial class ModProducts : Form
    {
        BindingList<Part> addParts = new BindingList<Part>();
        Form1 mainScreen = (Form1) Application.OpenForms["Form1"];

        public ModProducts(Product product)
        {
            InitializeComponent();
            ModProdInitialize(product);
        }

        public void ModProdInitialize(Product highlightedProduct) //Initializes the modify product page's data grids
        {
            modProdIdBox = highlightedProduct.productId;
            modProdNameBox = highlightedProduct.prodName;
            modProdInvBox = highlightedProduct.prodInStock;
            modProdPriceBox = decimal.Parse(highlightedProduct.prodPrice.Substring(1));
            modProdMinBox = highlightedProduct.prodMin;
            modProdMaxBox = highlightedProduct.prodMax;

            var firstSource = new BindingSource();
            firstSource.DataSource = Inventory.Parts;
            CandPartsGrid.DataSource = firstSource;

            CandPartsGrid.Columns["partId"].HeaderText = "Part ID";
            CandPartsGrid.Columns["partName"].HeaderText = "Part Name";
            CandPartsGrid.Columns["partInStock"].HeaderText = "Inventory";
            CandPartsGrid.Columns["partPrice"].HeaderText = "Price";
            CandPartsGrid.Columns["partMin"].HeaderText = "Min";
            CandPartsGrid.Columns["partMax"].HeaderText = "Max";

            foreach (Part part in highlightedProduct.AssociatedParts)
            {
                addParts.Add(part);
            }

            var secondSource = new BindingSource();
            secondSource.DataSource = addParts;
            PartsAssocGrid.DataSource = secondSource;

            PartsAssocGrid.Columns["partID"].HeaderText = "Part ID";
            PartsAssocGrid.Columns["partName"].HeaderText = "Part Name";
            PartsAssocGrid.Columns["partInStock"].HeaderText = "Inventory";
            PartsAssocGrid.Columns["partPrice"].HeaderText = "Price";
            PartsAssocGrid.Columns["partMin"].HeaderText = "Min";
            PartsAssocGrid.Columns["partMax"].HeaderText = "Max";
        }

        private void button1_Click(object sender, EventArgs e) //Save function that checks to make sure that the maximum value entered exceeds the minimum value and that the inventory values is between the min and max
        {
            if (modProdMaxBox < modProdMinBox)
            {
                MessageBox.Show("Error: Maximum field value must exceed minimum field value.");
                return;
            }

            if ((modProdInvBox < modProdMinBox) || (modProdInvBox > modProdMaxBox))
            {
                MessageBox.Show("Error: Inventory value must be between minimum and maximum values.");
            }

            Product savedProdChanges = new Product(modProdIdBox, modProdNameBox, modProdInvBox, modProdPriceBox, modProdMinBox, modProdMaxBox);

            foreach (Part part in addParts)
            {
                savedProdChanges.AddAssociatedPart(part);
            }

            Inventory.UpdateProduct(modProdIdBox, savedProdChanges);
            this.Close();

            mainScreen.ProdGrid.Update();
            mainScreen.ProdGrid.Refresh();
        }

        private void ModProducts_Load(object sender, EventArgs e)
        {

        }

        private void ModPartAdd_Click(object sender, EventArgs e) //Adds part to associated part list from candidate part list
        {
            Part addPart = (Part) CandPartsGrid.CurrentRow.DataBoundItem;
            addParts.Add(addPart);
        }

        private void ModProdSearch_Click(object sender, EventArgs e) //Search function to find a candidate part using the part ID
        {
            int searchCandPart = int.Parse(ModProdSearchText.Text);

            Part result = Inventory.LookupPart(searchCandPart);


            foreach (DataGridViewRow row in CandPartsGrid.Rows)
            {
                Part part = (Part) row.DataBoundItem;

                if (part.partId == result.partId)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void ModProdSearchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModProdDel_Click(object sender, EventArgs e) //Deletes parts associated with product
        {
            Part highlightedPart = (Part) PartsAssocGrid.CurrentRow.DataBoundItem;

            int delByID = this.modProdIdBox;
            Product highlightedProduct = Inventory.LookupProduct(delByID);
            highlightedProduct.RemoveAssociatedPart(highlightedPart.partId);

            const string message = "Are you sure you want to delete this associated part?"; //Confirms deletion
            const string caption = "Confirm Delete";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in PartsAssocGrid.SelectedRows)
                {
                    PartsAssocGrid.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void ModProdCancel_Click(object sender, EventArgs e) //Cancel function
        {
            this.Close();
        }

        private void PartsAssocGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModProdSearchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void ModProdIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void ModProdInvText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void ModProdPriceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void ModProdMaxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void ModProdMinText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }
    }
}
