using Newtonsoft.Json;

namespace GuideMe.Models
{
    public class Geometry
    {
        [JsonProperty("location")]
        public Location Location { get; set; }
    }
}