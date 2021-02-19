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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddParts_Click(object sender, EventArgs e)
        {
            new AddPart().ShowDialog();
        }

        private void ModifyParts_Click(object sender, EventArgs e)
        {
            new ModPart().ShowDialog();
        }

        private void DeleteParts_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in PartGrid.SelectedRows)
            {
                PartGrid.Rows.RemoveAt(row.Index);
            }
        }

        private void PartGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddProducts_Click(object sender, EventArgs e)
        {
            Product 
        }

        private void SearchParts_Click(object sender, EventArgs e)
        {
            if (SearchPartBox < 1)
                return;

            Part searchResultPart = Inventory.LookupPart(SearchPartBox);

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

        private void SearchProducts_Click(object sender, EventArgs e)
        {
            if (SearchProdBox < 1)
                return;

            Product searchResultProduct = Inventory.LookupProduct(SearchProdBox);

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
    }
}
