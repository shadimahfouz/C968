using System.ComponentModel;

namespace Shadi_Mahfouz_C968_Inventory_System
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
#pragma warning disable CS0169 // The field 'Product.ProductId' is never used
        private int ProductId;
#pragma warning restore CS0169 // The field 'Product.ProductId' is never used
#pragma warning disable CS0169 // The field 'Product.ProdName' is never used
        private string ProdName;
#pragma warning restore CS0169 // The field 'Product.ProdName' is never used
#pragma warning disable CS0169 // The field 'Product.ProdInStock' is never used
        private int ProdInStock;
#pragma warning restore CS0169 // The field 'Product.ProdInStock' is never used
        private decimal ProdPrice;
#pragma warning disable CS0169 // The field 'Product.ProdMin' is never used
        private int ProdMin;
#pragma warning restore CS0169 // The field 'Product.ProdMin' is never used
#pragma warning disable CS0169 // The field 'Product.ProdMax' is never used
        private int ProdMax;
#pragma warning restore CS0169 // The field 'Product.ProdMax' is never used


        //Public variables with getters and setters
        public int productId { get; set; }
        public string prodName { get; set; }
        public int prodInStock { get; set; }

        public string prodPrice
        {
            get { return ProdPrice.ToString("C"); }
            set
            {
                if (value.StartsWith("$"))
                {
                    ProdPrice = decimal.Parse(value.Substring(1));
                }
                else
                {
                    {
                        ProdPrice = decimal.Parse(value);
                    }
                }
            }
        }

        public int prodMin { get; set; }
        public int prodMax { get; set; }

        public Product() // Empty/default constructor
        {

        }

        public Product(int ID, string Name, int Inventory, decimal Price, int Min, int Max) // Full constructor with all parameters
        {
            productId = ID;
            prodName = Name;
            prodInStock = Inventory;
            prodPrice = Price.ToString();
            prodMin = Min;
            prodMax = Max;
        }

        public void AddAssociatedPart(Part part) //Adds associated part to associated part data grid view
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int PartId) // Removes parts associated with a selected product
        {
            bool removed = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.partId == PartId)
                {
                    AssociatedParts.Remove(part);
                    return removed = true;
                }
                else
                {
                    removed = false;
                }
            }

            return removed;
        }

        public Part LookupAssociatedPart(int PartId) // Enables search function to search using the Part ID
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.partId == PartId)
                {
                    return part;
                }
            }

            InHouse noPart = new InHouse();
            return noPart;
        }

    }
}