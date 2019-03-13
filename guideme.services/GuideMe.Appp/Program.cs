using System;
using System.Collections.Generic;
using System.IO;
using GuideMe.Models;
using GuideMe.Proxies;

namespace GuideMe.Appp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DetectLandmark();
            ListPlaces();

            Console.ReadKey();
        }

        public static void DetectLandmark()
        {
            try
            {
                List<byte[]> images = new List<byte[]>();

                images.Add(File.ReadAllBytes("pics/1.jpg"));
                images.Add(File.ReadAllBytes("pics/2.jpg"));
                images.Add(File.ReadAllBytes("pics/3.jpg"));
                images.Add(File.ReadAllBytes("pics/4.jpg"));
                images.Add(File.ReadAllBytes("pics/5.jpg"));

                LandmarkService landmarkService = new LandmarkService();

                foreach (byte[] imageArray in images)
                {
                    Console.WriteLine("--------------------------");

                    List<string> landmarkDescriptions = landmarkService.DetectLandmark(imageArray);

                    foreach (var description in landmarkDescriptions)
                    {
                        Console.WriteLine(description);
                    }

                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }

        }

        public static void ListPlaces()
        {
            string myKey = "AIzaSyDIgvwzP3L2qpz3wGlZrw5QHLIX1A4YtoI";
            string placesUri = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={0},{1}&rankby=distance&key={2}";

            LandmarkService ls = new LandmarkService();
            PointsOfInterest pointsOfInterest = ls.ListPlaces(new Location(-33.8670522, 151.1957362), myKey, placesUri);


            foreach(var p in pointsOfInterest.Places)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}
