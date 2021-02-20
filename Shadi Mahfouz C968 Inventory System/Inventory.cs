using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Shadi_Mahfouz_C968_Inventory_System
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();

        public static void ExistingItems() // Pre-populates the data grids with parts and products for testing purposes
        {
            Product firstProd = new Product(1, "Motherboard", 7, 25.00m, 5, 15);
            Product secondProd = new Product(2, "GPU", 10, 35.00m, 5, 25);
            Product thirdProd = new Product(3, "PC Case", 6, 45.00m, 3, 10);
            Product fourthProd = new Product(4, "Gaming Mouse", 10, 5.00m, 5, 25);
            Product fifthProd = new Product(5, "Gaming Keyboard", 8, 6.00m, 3, 10);

            Products.Add(firstProd);
            Products.Add(secondProd);
            Products.Add(thirdProd);
            Products.Add(fourthProd);
            Products.Add(fifthProd);

            Part firstPart = new InHouse(1, "Capacitor", 30, 0.25m, 20, 50, 123);
            Part secondPart = new InHouse(2, "Thermal Pads", 120, 0.10m, 100, 200, 111);
            Part thirdPart = new InHouse(3, "Wiring Kit", 20, 2.00m, 10, 30, 222);
            Part fourthPart = new InHouse(4, "Led Lights", 20, 1.00m, 15, 50, 333);
            Part fifthPart = new OutSourced(5, "Thermal Paste", 13, 3.50m, 10, 20, "PC Builders LLC");
            Part sixthPart = new OutSourced(6, "CPU", 5, 65.00m, 2, 10, "Intel");

            Parts.Add(firstPart);
            Parts.Add(secondPart);
            Parts.Add(thirdPart);
            Parts.Add(fourthPart);
            Parts.Add(fifthPart);
            Parts.Add(sixthPart);

            firstProd.AssociatedParts.Add(firstPart);
            firstProd.AssociatedParts.Add(sixthPart);
            secondProd.AssociatedParts.Add(secondPart);
            thirdProd.AssociatedParts.Add(thirdPart);
            thirdProd.AssociatedParts.Add(fourthPart);
        }
        

        public static void AddProduct(Product product) //Add product method
        {
            Products.Add(product);
        }

        public bool RemoveProduct(int prodID) //Remove product method
        {
            bool removed = false;
         foreach (Product product in Products)
         {
             if (prodID == product.productId)
             {
                 Products.Remove(product);
                 return removed = true;
             }

             else
             {
                 return false;
             }
         }

         return removed;
        }

        public static Product LookupProduct(int prodID) //Lookup product method
        {
            foreach (Product prod in Products)
            {
                if (prod.productId == prodID)
                {
                    return prod;
                }
            }

            Product noProd = new Shadi_Mahfouz_C968_Inventory_System.Product();
            return noProd;
        }

        public static void UpdateProduct(int prodID, Product updatedInfo) //Update product method after editing
        {
            foreach (Product prod in Products)
            {
                if (prod.productId == prodID)
                {
                    prod.prodName = updatedInfo.prodName;
                    prod.prodInStock = updatedInfo.prodInStock;
                    prod.prodPrice = updatedInfo.prodPrice;
                    prod.prodMin = updatedInfo.prodMin;
                    prod.prodMax = updatedInfo.prodMax;
                    prod.AssociatedParts = updatedInfo.AssociatedParts;
                    return;
                }
            }
        }

        public static void AddPart(Part part) //Add part method
        {
            Parts.Add(part);
        }

        public bool DeletePart(Part part) //Delete part method
        {
            try
            {
                Parts.Remove(part);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Part LookupPart(int partID) //Look up part method
        {
            foreach (Part part in Parts)
            {
                if (part.partId == partID)
                {
                    return part;
                }
            }

            Part noPart = null;
            return noPart;
        }

        public static void UpdateInhousePart(int partID, InHouse inhousePart) //Updates in house part after editing
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].GetType() == typeof(Shadi_Mahfouz_C968_Inventory_System.InHouse))
                {
                    InHouse newInHouse = (InHouse) Parts[i];

                    if (newInHouse.partId == partID)
                    {
                        newInHouse.partName = inhousePart.partName;
                        newInHouse.partInStock = inhousePart.partInStock;
                        newInHouse.partPrice = inhousePart.partPrice;
                        newInHouse.partMin = inhousePart.partMin;
                        newInHouse.partMax = inhousePart.partMax;
                        newInHouse.machineId = inhousePart.machineId;
                    }
                }
            }
        }

        public static void UpdateOutsourcedPart(int partID, OutSourced outsourcedPart) //Updates outsourced part after editing
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].GetType() == typeof(Shadi_Mahfouz_C968_Inventory_System.OutSourced))
                {
                    OutSourced newOutSourced = (OutSourced) Parts[i];

                    if (newOutSourced.partId == partID)
                    {
                        newOutSourced.partName = outsourcedPart.partName;
                        newOutSourced.partInStock = outsourcedPart.partInStock;
                        newOutSourced.partPrice = outsourcedPart.partPrice;
                        newOutSourced.partMin = outsourcedPart.partMin;
                        newOutSourced.partMax = outsourcedPart.partMax;
                        newOutSourced.compName = outsourcedPart.compName;
                    }
                }
            }
        }
    }
}