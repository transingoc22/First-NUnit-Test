using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using NUnit.Framework;
using System.Net;

namespace RestSharpTest
{
   

    public class TrelloTest
    {

        public static IRestClient _client;
        [OneTimeSetUp]
        public static void InitRestClient()
        {
            _client = new RestClient("https://api.trello.com");
        }
        [Test]
        public async Task CheckTrelloAPI()
        {
            var client = new RestClient("https://api.trello.com");
            var request = new RestRequest("members/me", Method.Get);
            var response = await client.ExecuteAsync(request);
            Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.Content);
            Assert.AreEqual(expected: HttpStatusCode.OK, actual: response.StatusCode);
        }
    }
}
