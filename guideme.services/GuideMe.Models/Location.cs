using Newtonsoft.Json;

namespace GuideMe.Models
{
    public class Location
    {
        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;

        }

        public Location()
        {

        }

        [JsonProperty("lng")]
        public double Longitude { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }
    }
}
