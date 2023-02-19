namespace Cap10
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Inventory inventory = new Inventory();
            System.Console.WriteLine($"Stock MAX: {inventory.MaxStock}");
            System.Console.WriteLine("___________________________");

            Students student = new Students("Levid", "Ing.Sistemas");
            System.Console.WriteLine($"[{student.StudentID}]-{student.Name} [{student.Career}]");
            System.Console.WriteLine("___________________________");

            Polygon poly = new Polygon(3, 13.2f);
            System.Console.WriteLine($"Perimetro: {poly.Perimeter}");
            poly.SetSides(-1);
            System.Console.WriteLine(poly.ToString());
        }
    }
}