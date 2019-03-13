
using System.Collections.Generic;
using Google.Cloud.Vision.V1;

namespace GuideMe.Proxies
{
    internal class LandmarkVisionService
    {
        private readonly ImageAnnotatorClient _googleClient;

        public LandmarkVisionService()
        {
            _googleClient = GoogleVision.GetClient();
        }

        public IReadOnlyList<EntityAnnotation> Detect(Image image)
        {          
            var response = _googleClient.DetectLandmarks(image);

            return response;
        }
    }
}
