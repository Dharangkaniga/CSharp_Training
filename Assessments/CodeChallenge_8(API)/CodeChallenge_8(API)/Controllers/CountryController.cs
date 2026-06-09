using CodeChallenge_8_API_.Models;
using System;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CodeChallenge_API_.Controllers
{
    public class CountryController : ApiController
    {
        private static List<Country> countries = new List<Country>()
        {
            new Country { ID = 1, CountryName = "India", Capital = "New Delhi" },
            new Country { ID = 2, CountryName = "USA", Capital = "Washington D.C." }
        };

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(countries);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);

            if (country == null)
                return NotFound();

            return Ok(country);
        }

        [HttpPost]
        public IHttpActionResult Post(Country country)
        {
            if (country == null)
                return BadRequest("Invalid Data");

            countries.Add(country);

            return Ok("Country Added Successfully");
        }

        [HttpPut]
        public IHttpActionResult Put(int id, Country country)
        {
            var existingCountry = countries.FirstOrDefault(c => c.ID == id);

            if (existingCountry == null)
                return NotFound();

            existingCountry.CountryName = country.CountryName;
            existingCountry.Capital = country.Capital;

            return Ok("Country Updated Successfully");
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);

            if (country == null)
                return NotFound();

            countries.Remove(country);

            return Ok("Country Deleted Successfully");
        }
    }
}