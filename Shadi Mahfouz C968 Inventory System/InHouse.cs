namespace Shadi_Mahfouz_C968_Inventory_System
{
    public class InHouse : Part
    {
        private int MachineId;

        public int machineId { get; set; }

        public InHouse()
        {

        }

        public InHouse(int ID, string Name, int Inventory, decimal Price, int Min, int Max)
        {
            partId = ID;
            partName = Name;
            partInStock = Inventory;
            partPrice = Price.ToString();
            partMin = Min;
            partMax = Max;
        }

        public InHouse(int ID, string Name, int Inventory, decimal Price, int Min, int Max, int MachineID)
        {
            partId = ID;
            partName = Name;
            partInStock = Inventory;
            partPrice = Price.ToString();
            partMin = Min;
            partMax = Max;
            machineId = MachineID;
        }
    }
}