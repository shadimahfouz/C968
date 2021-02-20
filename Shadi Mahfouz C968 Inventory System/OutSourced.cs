namespace Shadi_Mahfouz_C968_Inventory_System
{
    public class OutSourced : Part
    {
#pragma warning disable CS0169 // The field 'OutSourced.CompName' is never used
        private string CompName;
#pragma warning restore CS0169 // The field 'OutSourced.CompName' is never used

        public string compName { get; set; }

        public OutSourced()
        {

        }

        public OutSourced(int ID, string Name, int Inv, decimal Price, int Min, int Max) //Outsourced constructor without company name
        {
            partId = ID;
            partName = Name;
            partInStock = Inv;
            partPrice = Price.ToString();
            partMin = Min;
            partMax = Max;

        }

        public OutSourced(int ID, string Name, int Inv, decimal Price, int Min, int Max, string Company) //Outsourced constructor with company name
        {
            partId = ID;
            partName = Name;
            partInStock = Inv;
            partPrice = Price.ToString();
            partMin = Min;
            partMax = Max;
            compName = Company;
        }
    }
}