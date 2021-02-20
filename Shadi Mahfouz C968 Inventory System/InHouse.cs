namespace Shadi_Mahfouz_C968_Inventory_System
{
    public class InHouse : Part
    {
#pragma warning disable CS0169 // The field 'InHouse.MachineId' is never used
        private int MachineId;
#pragma warning restore CS0169 // The field 'InHouse.MachineId' is never used

        public int machineId { get; set; }

        public InHouse()
        {

        }

        public InHouse(int ID, string Name, int Inventory, decimal Price, int Min, int Max) //InHouse constructor without Machine ID
        {
            partId = ID;
            partName = Name;
            partInStock = Inventory;
            partPrice = Price.ToString();
            partMin = Min;
            partMax = Max;
        }

        public InHouse(int ID, string Name, int Inventory, decimal Price, int Min, int Max, int MachineID) //InHouse constructor with Machine ID
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