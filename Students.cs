namespace Cap10
{
    public class Students
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Career { get; set; }

        public Students(string Name, string Career)
        {
            Random random = new Random();
            StudentID = random.Next(20200582, 20230582);
            
            this.Name = Name;
            this.Career = Career;
        }
    }
}