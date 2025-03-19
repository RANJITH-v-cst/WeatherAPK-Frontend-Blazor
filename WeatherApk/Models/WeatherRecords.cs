namespace ClientWeather.Models
{
    public class WeatherRecord
    {
        public string Name { get; set; } = string.Empty;
        public double Temperature { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
        public string email { get; set; }
    }
}