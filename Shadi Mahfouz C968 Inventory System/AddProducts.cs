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
    public partial class AddProduct : Form
    {
        BindingList<Part> addParts = new BindingList<Part>();
        public AddProduct()
        {
            InitializeComponent(); 
            ProdAddLoad();
        }


        public void ProdAddLoad() //Initializes the data grids in Add Products page
        {
            var firstSource = new BindingSource();
            firstSource.DataSource = Inventory.Parts;
            CandPartsGrid.DataSource = firstSource;
            CandPartsGrid.Columns["PartID"].HeaderText = "Part ID";
            CandPartsGrid.Columns["PartName"].HeaderText = "Part Name";
            CandPartsGrid.Columns["PartInStock"].HeaderText = "Inventory";
            CandPartsGrid.Columns["PartPrice"].HeaderText = "Price";
            CandPartsGrid.Columns["PartMin"].HeaderText = "Min";
            CandPartsGrid.Columns["PartMax"].HeaderText = "Max";


            var secondSource = new BindingSource();
            secondSource.DataSource = addParts;
            PartsAssocGrid.DataSource = secondSource;
            PartsAssocGrid.Columns["PartID"].HeaderText = "Part ID";
            PartsAssocGrid.Columns["PartName"].HeaderText = "Part Name";
            PartsAssocGrid.Columns["PartInStock"].HeaderText = "Inventory";
            PartsAssocGrid.Columns["PartPrice"].HeaderText = "Price";
            PartsAssocGrid.Columns["PartMin"].HeaderText = "Min";
            PartsAssocGrid.Columns["PartMax"].HeaderText = "Max";

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddProdCancel_Click(object sender, EventArgs e) //Cancel function
        {
            this.Close();
        }

        private void AddProdAdd_Click(object sender, EventArgs e) //Adds part from Candidate Parts list to Associated parts list
        {
            Part addPart = (Part) CandPartsGrid.CurrentRow.DataBoundItem;
            addParts.Add(addPart);
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void AddProdSearch_Click(object sender, EventArgs e) //Search function that searches by Part ID
        {
            int candSearch = int.Parse(AddProdSearchText.Text);
            Part result = Inventory.LookupPart(candSearch);

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

        private void AddProdSearchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProdDel_Click(object sender, EventArgs e) //Delete function that confirms deletion of associated parts
        {
            const string message = "Are you sure you want to delete this product?";
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

        private void AddProdSave_Click(object sender, EventArgs e) //Save function that checks to make sure maximum value exceeds minimum value and that inventory value sits in between min and max
        {
            if (addProdMaxBox > addProdMinBox)
            {
                MessageBox.Show("Error: Maximum value must exceed minimum value.");
                return;
            }

            if ((addProdInvBox < addProdMinBox) || (addProdInvBox > addProdMaxBox))
            {
                MessageBox.Show("Error: Inventory value must be between minimum and maximum values.");
            }

            Product addProduct = new Product((Inventory.Products.Count + 1), addProdNameBox, addProdInvBox, addProdPriceBox, addProdMinBox, addProdMaxBox);
            Inventory.AddProduct(addProduct);

            foreach (Part part in addParts)
            {
                addProduct.AddAssociatedPart(part);
            }
            this.Close();
        }

        private void AddProdIdText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartsAssocGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddProdIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void AddProdInvText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void AddProdPriceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void AddProdMaxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void AddProdMinText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void AddProdSearchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }
    }
}
