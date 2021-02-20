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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1Initialize();
        }

        public void Form1Initialize() //Initializes the part and product data grid views
        {
            Inventory.ExistingItems();

            var boundPart = new BindingSource();
            boundPart.DataSource = Inventory.Parts;
            PartGrid.DataSource = boundPart;

            PartGrid.Columns["partId"].HeaderText = "Part ID";
            PartGrid.Columns["partName"].HeaderText = "Name";
            PartGrid.Columns["partInStock"].HeaderText = "Inventory";
            PartGrid.Columns["partPrice"].HeaderText = "Price";
            PartGrid.Columns["partMin"].HeaderText = "Min";
            PartGrid.Columns["partMax"].HeaderText = "Max";

            var boundProd = new BindingSource();
            boundProd.DataSource = Inventory.Products;
            ProdGrid.DataSource = boundProd;

            ProdGrid.Columns["productID"].HeaderText = "Product ID";
            ProdGrid.Columns["prodName"].HeaderText = "Name";
            ProdGrid.Columns["prodInStock"].HeaderText = "Inventory";
            ProdGrid.Columns["prodPrice"].HeaderText = "Price";
            ProdGrid.Columns["prodMin"].HeaderText = "Min";
            ProdGrid.Columns["prodMax"].HeaderText = "Max";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddParts_Click(object sender, EventArgs e) //Brings up add part page
        {
            new AddPart().ShowDialog();
        }

        private void ModifyParts_Click(object sender, EventArgs e) //Brings up modify part page with radio preselected depending on whether in house or outsourced
        {
            if (PartGrid.CurrentRow.DataBoundItem.GetType() == typeof(Shadi_Mahfouz_C968_Inventory_System.InHouse))
            {
                InHouse inHousePart = (InHouse) PartGrid.CurrentRow.DataBoundItem;
                new ModPart(inHousePart).ShowDialog();
            }
            else
            {
                OutSourced outSourcedPart = (OutSourced) PartGrid.CurrentRow.DataBoundItem;
                new ModPart(outSourcedPart).ShowDialog();
            }
        }

        private void DeleteParts_Click(object sender, EventArgs e) //Deletes selected part and confirms deletion before taking action
        {
            const string message = "Are you sure you want to delete this part?"; //Deletion confirmation
            const string caption = "Confirm Delete";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in PartGrid.SelectedRows)
                {
                    PartGrid.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void PartGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddProducts_Click(object sender, EventArgs e) //Launches the add product page
        {
            Product highlightedProduct = (Product)ProdGrid.CurrentRow.DataBoundItem;
            new AddProduct().ShowDialog();
        }

        private void SearchParts_Click(object sender, EventArgs e) //Search function that matches user entered part ID to part in data grid
        {
            if (partSearchBox < 1)
                return;

            Part searchResultPart = Inventory.LookupPart(partSearchBox);

            foreach (DataGridViewRow row in PartGrid.Rows)
            {
                Part part = (Part) row.DataBoundItem;

                if (part.partId == searchResultPart.partId)
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

        private void SearchProducts_Click(object sender, EventArgs e) //Search function that matches user entered product ID to product in data grid
        {
            if (prodSearchBox < 1)
                return;

            Product searchResultProduct = Inventory.LookupProduct(prodSearchBox);

            foreach (DataGridViewRow row in ProdGrid.Rows)
            {
                Product prod = (Product) row.DataBoundItem;

                if (prod.productId == searchResultProduct.productId)
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

        private void ModifyProducts_Click(object sender, EventArgs e) //Brings up the modify product page
        {
            Product highlightedProduct = (Product) ProdGrid.CurrentRow.DataBoundItem;
            new ModProducts(highlightedProduct).ShowDialog();
        }

        private void ProdGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteProducts_Click(object sender, EventArgs e) //Delete product function
        {
            Product product = (Product) ProdGrid.CurrentRow.DataBoundItem;
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("There are parts associated with this item, please remove them before removing this item."); //Does not allow deletion if the product has parts associated with it
                return;
            }

            const string message = "Are you sure you want to delete this product?"; //Deletion confirmation
            const string caption = "Confirm Delete";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in ProdGrid.SelectedRows)
                {
                    ProdGrid.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e) //Exit function
        {
            this.Close();
        }

        private void SearchPartBox_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }

        private void SearchProdBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Handles non numeric values entered into a number only field
            {
                e.Handled = true;
            }
        }
    }
}
