namespace Cap10
{
    public class Polygon
    {
        public int Sides { get; set; }
        public float SidesLength { get; set; }
        public float Perimeter { get; set; }

        public Polygon(int Sides, float SidesLength)
        {
            this.Sides = Sides;
            this.SidesLength = SidesLength;
            Perimeter = SidesLength * Sides;
        }
        public Polygon()
        {
            Sides = 0;
            SidesLength = 0.0f;
            Perimeter = 0.0f;
        }

        public void SetSides(int Sides)
        {
            if(Sides > 0)
                this.Sides = Sides;
            else
                System.Console.WriteLine($"Los lados ingresados no son validos: {Sides}");
        }

        public override string ToString()
        {
            return $"Lados: {Sides} - LargoLagods: {SidesLength} -> Perimetro: {Perimeter}";
        }

    }
}