namespace Shadi_Mahfouz_C968_Inventory_System
{
    public class OutSourced : Part
    {
        private string CompName;

        public string compName { get; set; }

        public OutSourced()
        {

        }

        public OutSourced(int ID, string Name, int Inv, decimal Price, int Min, int Max)
        {
            partId = ID;
            partName = Name;
            partInStock = Inv;
            partPrice = Price.ToString();
            partMin = Min;
            partMax = Max;

        }

        public OutSourced(int ID, string Name, int Inv, decimal Price, int Min, int Max, string Company)
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