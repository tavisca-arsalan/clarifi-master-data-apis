using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MasterDataDeliveryApis.DAL.Interfaces; 

namespace MasterDataDeliveryApis.DAL
{
    public class CountryMasterRepositoryManager: ICountryMasterRepository
    {
        public List<Models.Country> GetAllCountries()
        {
            throw new NotImplementedException();
        }

        public Models.Country GetCountryByName(string name)
        {
            throw new NotImplementedException();
        }

        public Models.Country GetCountryByIsoCode2(string isoCode2)
        {
            throw new NotImplementedException();
        }

        public Models.Country GetCountryByIsoCode3(string isoCode3)
        {
            throw new NotImplementedException();
        }
        public List<Models.Polygon> GetPolygonsForCountry(string isoCode2)
        {
            throw new NotImplementedException();
        }
    }
}