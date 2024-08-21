using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CC_WebAPI.Models;

namespace CC_WebAPI.Controllers
{
    [RoutePrefix("api/Country")]
    public class CountryController : ApiController
    { 
        List<Country> Countrylist = new List<Country>()
        {
            new Country { ID = 1, CountryName = "Japan", Capital = "Tokyo" },
            new Country { ID = 2, CountryName = "India", Capital = "New Delhi" },
            new Country { ID = 3, CountryName = "Poland", Capital = "Warsaw" },
            new Country { ID = 4, CountryName = "South Korea", Capital = "Seoul" },
            new Country { ID = 5, CountryName = "China", Capital = "Beijing" }
        };

        //GET All countries
        [HttpGet]
        [Route("All")]
        public IEnumerable<Country> Get()
        {
            return Countrylist;
        }

        //GET Country Byid
        [HttpGet]
        [Route("ById")]
        public IHttpActionResult GetCountryByName(int Id)
        {
            string Countryname = Countrylist.Where(c => c.ID == Id).SingleOrDefault()?.CountryName;
            if (Countryname == null)
            {
                return NotFound();
            }
            return Ok(Countryname);
        }

        //POST add country
        [HttpPost]
        [Route("Post")]
        public List<Country> Post([FromBody] Country country)
        {
            Countrylist.Add(country);
            return Countrylist;
        }

        //PUT Update country
        [HttpPut]
        [Route("Put")]
        public IEnumerable<Country> Put(int id, [FromBody] Country c)
        {
            Countrylist[id - 1] = c;
            return Countrylist;
        }

        //DELETE delete country
        [HttpDelete]
        [Route("Delete")]
        public IEnumerable<Country> Delete(int id)
        {
            Countrylist.RemoveAt(id - 1);
            return Countrylist;
        }
    }
}

