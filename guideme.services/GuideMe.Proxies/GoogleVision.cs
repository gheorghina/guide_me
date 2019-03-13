using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Vision.V1;

namespace GuideMe.Proxies
{
    internal static class GoogleVision
    {
        private static ImageAnnotatorClient client;

        public static ImageAnnotatorClient GetClient()
        {
            if (client == null)
            {
                client = ImageAnnotatorClient.Create();
            }

            return client;
        }
    }
             
}
