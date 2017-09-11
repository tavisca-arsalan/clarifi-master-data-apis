using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;
using System.Net.Http;
using System.Net.Http.Headers;
using MasterDataDeliveryApis;
using System.Threading.Tasks;
using System.Net;

namespace Clarifi.MasterDataDeliveryApis.Tests
{
    [TestClass]
    public class CountryMasterDataTests
    {
        [TestMethod]
        public async Task GetAllCountriesTest_HttpClient_Should_Get_OKStatus_From()
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
    }
}
