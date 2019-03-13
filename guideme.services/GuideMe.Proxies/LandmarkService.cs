
using System.Collections.Generic;
using Google.Cloud.Vision.V1;
using GuideMe.Models;

namespace GuideMe.Proxies
{
    public class LandmarkService
    {
        public List<string> DetectLandmark(byte[] imageInput)
        {
            Image image = Image.FromBytes(imageInput);
            LandmarkVisionService landmarkVision = new LandmarkVisionService();
            List<string> descriptions = new List<string>();

            var response = landmarkVision.Detect(image);

            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                {
                    descriptions.Add(annotation.Description);
                }
            }

            return descriptions;
        }

        public PointsOfInterest ListPlaces(Location location, string key, string placesUri)
        {
            PlacesNearbyService placesNearby = new PlacesNearbyService(key, placesUri);
            Location testLocation = location;
            PointsOfInterest pointsOfInterest = placesNearby.SearchPointsOfInterest(testLocation);

            return pointsOfInterest;
        }

    }
}
