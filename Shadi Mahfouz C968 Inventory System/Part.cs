namespace Shadi_Mahfouz_C968_Inventory_System
{
    public abstract class Part
    {
#pragma warning disable CS0169 // The field 'Part.PartId' is never used
        private int PartId;
#pragma warning restore CS0169 // The field 'Part.PartId' is never used
#pragma warning disable CS0169 // The field 'Part.PartName' is never used
        private string PartName;
#pragma warning restore CS0169 // The field 'Part.PartName' is never used
#pragma warning disable CS0169 // The field 'Part.PartInStock' is never used
        private int PartInStock;
#pragma warning restore CS0169 // The field 'Part.PartInStock' is never used
        private decimal PartPrice;
#pragma warning disable CS0169 // The field 'Part.PartMin' is never used
        private int PartMin;
#pragma warning restore CS0169 // The field 'Part.PartMin' is never used
#pragma warning disable CS0169 // The field 'Part.PartMax' is never used
        private int PartMax;
#pragma warning restore CS0169 // The field 'Part.PartMax' is never used


        //Public variable getters and setters
        public int partId { get; set; }
        public string partName { get; set; }
        public int partInStock { get; set; }

        public string partPrice
        {
            get { return PartPrice.ToString("C"); }
            set
            {
                if (value.StartsWith("$"))
                {
                    PartPrice = decimal.Parse(value.Substring(1));
                }
                else
                {
                    PartPrice = decimal.Parse(value);
                }
            }
        }
        public int partMin { get; set; }
        public int partMax { get; set; }
    }
}