using MasterDataDeliveryApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDataDeliveryApis.DAL.Interfaces
{
    interface ICountryMasterRepository
    {
        List<CountryMaster> GetAllCountries();
        CountryMaster GetCountryByName(string name);
        CountryMaster GetCountryByIsoCode2(string isoCode2);
        CountryMaster GetCountryByIsoCode3(string isoCode3);
        List<Polygon> GetPolygonsForCountryCode(string isoCode2);
    }
}
