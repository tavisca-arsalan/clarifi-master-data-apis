using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MasterDataDeliveryApis.Models;
using MasterDataDeliveryApis.Mappers;
using MasterDataDeliveryApis.Models.DataTransferObjects;
using MasterDataDeliveryApis.DAL;

namespace MasterDataDeliveryApis.Controllers
{
    public class CountryMasterController : ApiController
    {
        private DtoDomainMapper _mapper = new DtoDomainMapper();
        private CountryMasterRepositoryManager _repositoryManager = new CountryMasterRepositoryManager();
        [HttpGet]
        public IEnumerable<CountryDto> GetAllCountries()
        {
            var domainCountryList = _repositoryManager.GetAllCountries();
            return _mapper.ToCountryDtoList(domainCountryList);
        }

        [HttpGet]
        public CountryDto GetCountryByIsoCode2(string id)
        {
            var domainCountry = _repositoryManager.GetCountryByIsoCode2(id);
            return _mapper.ToCountryDto(domainCountry);
        }

        [HttpGet]
        public CountryDto GetCountryByIsoCode3(string id)
        {
            var domainCountry = _repositoryManager.GetCountryByIsoCode3(id);
            return _mapper.ToCountryDto(domainCountry);
        }

        [HttpGet]
        public CountryDto GetCountryByName(string id)
        {
            var domainCountry = _repositoryManager.GetCountryByName(id);
            return _mapper.ToCountryDto(domainCountry);
        }

        [HttpGet]
        public List<PolygonDto> GetPolygonsForCountry(string id)
        {
            var domainPolygons = _repositoryManager.GetPolygonsForCountry(id);
            return _mapper.ToDtoPolygons(domainPolygons);
        }
    }
}
