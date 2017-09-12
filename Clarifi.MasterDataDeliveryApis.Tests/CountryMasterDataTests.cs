using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;
using System.Net.Http;
using System.Net.Http.Headers;
using MasterDataDeliveryApis;
using System.Threading.Tasks;
using System.Net;
using MasterDataDeliveryApis.Models;
using System.Collections.Generic;

namespace Clarifi.MasterDataDeliveryApis.Tests
{
    [TestClass]
    public class CountryMasterDataTests
    {
        [TestMethod]
        public async Task GetAllCountriesTest_Should_Get_OKStatus()
        {
            var config = new HttpConfiguration();
            //configure web api
            WebApiConfig.Register(config);
            //config.MapHttpAttributeRoutes();

            using (var server = new HttpServer(config))
            {

                var client = new HttpClient(server);

                string url = "http://localhost/api/countrymaster/";

                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri(url),
                    Method = HttpMethod.Get
                };

                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using (var response = await client.SendAsync(request))
                {
                    Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                }
            }
        }

        [TestMethod]
        public async Task GetCountryByNameTest_Should_Get_CountryData_For_Input_Name()
        {
            var config = new HttpConfiguration();
            //configure web api
            WebApiConfig.Register(config);
            //config.MapHttpAttributeRoutes();

            using (var server = new HttpServer(config))
            {

                var client = new HttpClient(server);

                string url = "http://localhost/api/countrymaster/getcountrybyname/Germany";

                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri(url),
                    Method = HttpMethod.Get
                };

                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using (var response = await client.SendAsync(request))
                {
                    var responseCountryOb=new CountryMaster();
                    response.TryGetContentValue(out responseCountryOb);
                    Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                    Assert.AreEqual("Germany", responseCountryOb.Name);
                }
            }
        }

        [TestMethod]
        public async Task GetCountryByIsoCode2Test_Should_Get_CountryData_For_Input_IsoCode2()
        {
            var config = new HttpConfiguration();
            //configure web api
            WebApiConfig.Register(config);
            //config.MapHttpAttributeRoutes();

            using (var server = new HttpServer(config))
            {

                var client = new HttpClient(server);

                string url = "http://localhost/api/countrymaster/getcountrybyisocode2/AG";

                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri(url),
                    Method = HttpMethod.Get
                };

                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using (var response = await client.SendAsync(request))
                {
                    var responseCountryOb = new CountryMaster();
                    response.TryGetContentValue(out responseCountryOb);
                    Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                    Assert.AreEqual("AG", responseCountryOb.IsoCode2);
                }
            }
        }

        [TestMethod]
        public async Task GetCountryByIsoCode3Test_Should_Get_CountryData_For_Input_IsoCode3()
        {
            var config = new HttpConfiguration();
            //configure web api
            WebApiConfig.Register(config);
            //config.MapHttpAttributeRoutes();

            using (var server = new HttpServer(config))
            {

                var client = new HttpClient(server);

                string url = "http://localhost/api/countrymaster/getcountrybyisocode3/USA";

                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri(url),
                    Method = HttpMethod.Get
                };

                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using (var response = await client.SendAsync(request))
                {
                    var responseCountryOb = new CountryMaster();
                    response.TryGetContentValue(out responseCountryOb);
                    Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                    Assert.AreEqual("USA", responseCountryOb.IsoCode3);
                }
            }
        }
        [TestMethod]
        public async Task GetPolygonsForCountryTest_Should_Get_CountryData_For_Input_IsoCode2()
        {
            var config = new HttpConfiguration();
            //configure web api
            WebApiConfig.Register(config);
            //config.MapHttpAttributeRoutes();

            using (var server = new HttpServer(config))
            {

                var client = new HttpClient(server);

                string url = "http://localhost/api/countrymaster/getpolygonsforcountry/AG";

                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri(url),
                    Method = HttpMethod.Get
                };

                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using (var response = await client.SendAsync(request))
                {
                    //var responseContentOb = null;
                    Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                    //TODO: Assert to check contents of response(polygons)
                }
            }
        }

    }
}
