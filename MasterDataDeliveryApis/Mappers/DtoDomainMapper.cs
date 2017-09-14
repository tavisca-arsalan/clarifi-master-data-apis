using MasterDataDeliveryApis.Models;
using MasterDataDeliveryApis.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDataDeliveryApis.Mappers
{
    public class DtoDomainMapper
    {
        public CountryDto ToCountryDto(Country country)
        {
            return new CountryDto()
            {
                Name = country.Name,
                RegionName = country.RegionName,
                SubRegionName = country.SubRegionName,
                IntermediateRegionName = country.IntermediateRegionName,
                IsoCode2 = country.IsoCode2,
                IsoCode3 = country.IsoCode3,
                Language = country.Language,
                AddedDate= country.AddedDate,
                ModifiedDate = country.ModifiedDate,
                FlagUrl = country.FlagUrl,
                IconUrl = country.IconUrl,
                Polygons= ToDtoPolygons(country.Polygons),
                Source =  ToDtoSource(country.Source)
            };
        }

        public IEnumerable<CountryDto> ToCountryDtoList(List<Country> domainCountryList)
        {
            if (domainCountryList == null || domainCountryList.Count==0)
                return null;
            else
            {
                List<CountryDto> dtoCountryList = new List<CountryDto>();
                foreach (var domainCountry in domainCountryList)
                {
                    dtoCountryList.Add(ToCountryDto(domainCountry));
                }
                return dtoCountryList;
            }
            
        }

        public List<PolygonDto> ToDtoPolygons(List<Polygon> domainPolygons)
        {
            List<PolygonDto> dtoPolygons = new List<PolygonDto>();
            foreach (var domainPlygon in domainPolygons)
            {
                dtoPolygons.Add(ToDtoPolygon(domainPlygon));
            }
            return dtoPolygons;
        }

        public PolygonDto ToDtoPolygon(Polygon domainPolygon)
        {
            PolygonDto dtoPolygon = new PolygonDto();
            dtoPolygon.Source = ToDtoSource(domainPolygon.Source);
            dtoPolygon.Coordinates = new List<GeoCodesDto>();
            foreach (var domainCoordinate in domainPolygon.Coordinates)
            {
                dtoPolygon.Coordinates.Add(ToDtoCoordinates(domainCoordinate));
            }
            return dtoPolygon;
        }

        public GeoCodesDto ToDtoCoordinates(GeoCodes domainCoordinates)
        {
            return new GeoCodesDto()
            {
                Longitude = domainCoordinates.Longitude,
                Latitude = domainCoordinates.Latitude
            };
        }

        public SourceDto ToDtoSource(Source domainSource)
        {
            return new SourceDto()
            {
                Name = domainSource.Name,
                Description = domainSource.Description,
                Url = domainSource.Url
            };
        }
    }
}