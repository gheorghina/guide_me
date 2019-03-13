
using System.Net.Http;
using GuideMe.Models;
using Newtonsoft.Json;

namespace GuideMe.Proxies
{
    internal class PlacesNearbyService
    {
        private string myKey;// = "";
        private string placesUriTemplate;// = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={0},{1}&rankby=distance&key={2}";
        
        private HttpClient httpClient;

        public PlacesNearbyService(string key, string placesUri)
        {
            httpClient = new HttpClient();
            myKey = key;
            placesUriTemplate = placesUri;
        }

        public PointsOfInterest SearchPointsOfInterest(Location location)
        {
            string url = string.Format(placesUriTemplate, location.Latitude, location.Longitude, myKey);
            var pointsOfInterestResponse =  httpClient.GetAsync(url);          

            var pointsOfInterest = JsonConvert.DeserializeObject<PointsOfInterest>(pointsOfInterestResponse.Result.Content.ReadAsStringAsync().Result);

            return pointsOfInterest;
        }
    }
}
