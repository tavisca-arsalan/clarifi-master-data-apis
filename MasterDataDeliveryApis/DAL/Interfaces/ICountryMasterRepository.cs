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
        List<Country> GetAllCountries();
        Country GetCountryByName(string name);
        Country GetCountryByIsoCode2(string isoCode2);
        Country GetCountryByIsoCode3(string isoCode3);
        List<Polygon> GetPolygonsForCountry(string isoCode2);
    }
}
