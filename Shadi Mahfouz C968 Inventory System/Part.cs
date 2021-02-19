namespace Shadi_Mahfouz_C968_Inventory_System
{
    public abstract class Part
    {
        private int PartId;
        private string PartName;
        private int PartInStock;
        private decimal PartPrice;
        private int PartMin;
        private int PartMax;

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