using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GuideMe.Models;
using GuideMe.Proxies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GuideMe.API.Controllers
{
    [Route("api/[controller]")]
    public class LandmarkVisionController : Controller
    {
        private readonly IConfiguration Configuration;

        public LandmarkVisionController()
        {
            Configuration = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json").Build();
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            //return Configuration["GoogleVision:PlacesKey"];
        }

        // POST api/values
        [HttpPost]
        public void DetectLandmark([FromBody]byte[] value)
        {
            string myKey = "";
            string placesUri = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={0},{1}&rankby=distance&key={2}";

            LandmarkService ls = new LandmarkService();
            ls.ListPlaces(new Location(-33.8670522, 151.1957362), myKey, placesUri);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
