namespace test
{
    public class API
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
        public int Name { get; set; }

        public string Description { get; set; } 
        public string Delivery { get; set; }
    }
}