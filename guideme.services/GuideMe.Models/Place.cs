using System.Collections.Generic;
using Newtonsoft.Json;

namespace GuideMe.Models
{
    public class Place
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }
    }
}