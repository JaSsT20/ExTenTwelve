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

    }
}