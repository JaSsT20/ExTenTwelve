namespace Cap10
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Inventory inventory = new Inventory();
            System.Console.WriteLine($"{inventory.MaxStock}");
        }
    }
}