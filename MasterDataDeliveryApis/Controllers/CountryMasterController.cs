using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MasterDataDeliveryApis.Models;

namespace MasterDataDeliveryApis.Controllers
{
    public class CountryMasterController : ApiController
    {
        [HttpGet]
        public IEnumerable<CountryMaster> GetAllCountries()
        {
            return new List<CountryMaster> {new  CountryMaster()
                                                {
                                                    Name = "Australia",
                                                    IsoCode2 = "AUS"
                                                }
            };
        }

        [HttpGet]
        public CountryMaster GetCountryByIsoCode2(string id)
        {
            return new CountryMaster()
            {
                Name = "Australia",
                IsoCode2 = id
            };
        }

        [HttpGet]
        public CountryMaster GetCountryByIsoCode3(string id)
        {
            return new CountryMaster()
            {
                Name = "Australia",
                IsoCode3 = id
            };
        }

        [HttpGet]
        public CountryMaster GetCountryByName(string id)
        {
            return new CountryMaster()
            {
                Name = id,
                IsoCode2 = "AU"
            };
        }

        [HttpGet]
        public List<Polygon> GetPolygonsForCountryCode(string id)
        {
           return new List<Polygon>();
        }
    }
}
