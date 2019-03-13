using System.Collections.Generic;
using Newtonsoft.Json;

namespace GuideMe.Models
{
    public class PointsOfInterest
    {        
        [JsonProperty("next_page_token")]
        public string NextPageToken { get; set; }

        [JsonProperty("results")]
        public List<Place> Places { get; set; }      
    }
}
