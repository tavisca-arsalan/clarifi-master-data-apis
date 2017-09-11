using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDataDeliveryApis.DAL
{
    public class CountryMasterDBManager
    {
        public List<Models.CountryMaster> GetAllCountries()
        {
            throw new NotImplementedException();
        }

        public Models.CountryMaster GetCountryByName(string name)
        {
            throw new NotImplementedException();
        }

        public Models.CountryMaster GetCountryByIsoCode2(string isoCode2)
        {
            throw new NotImplementedException();
        }

        public Models.CountryMaster GetCountryByIsoCode3(string isoCode3)
        {
            throw new NotImplementedException();
        }
        public List<Models.Polygon> GetPolygonsForCountryCode(string isoCode2)
        {
            throw new NotImplementedException();
        }
    }
}