using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using Xunit;

namespace GamingCenter.IntegrationTest
{
    public class UnitTest1
    {
        private readonly HttpClient _client;
        public UnitTest1()
        {
            var appFactory=new WebApplicationFactory<Startup>();
            _client=appFactory.CreateClient();
        }
        [Fact]
        public void Test1()
        {
            //var respose = _client.GetAsync(ApiRoutes);
        }
    }
}
