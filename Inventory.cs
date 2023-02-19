namespace Cap10
{
    public class Inventory
    {
        public int BatchID { get; set; }
        public string BatchDescription { get; set; }
        public int MaxStock { get; set; }
        public int MinStock { get; set; }

        public Inventory()
        {
            BatchID = 0;
            BatchDescription = String.Empty;
            MaxStock = 100;
            MinStock = 1;
        }
    }
}