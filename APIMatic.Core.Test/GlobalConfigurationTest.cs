﻿using System.Collections.Generic;
using System.Net.Http;
using NUnit.Framework;

namespace APIMatic.Core.Test
{
    [TestFixture]
    public class GlobalConfigurationTest : TestBase
    {
        [Test]
        public void TestServerUrl()
        {
            var actualServer1 = LazyGlobalConfiguration.Value.ServerUrl();
            Assert.AreEqual("http://my/path:3000/v1", actualServer1);

            var actualServer2 = LazyGlobalConfiguration.Value.ServerUrl(MockServer.Server2);
            Assert.AreEqual("https://my/path/v2", actualServer2);
        }

        [Test]
        public void TestGlobalRequestQueryUrl()
        {
            var request = LazyGlobalConfiguration.Value.GlobalRequestBuilder(MockServer.Server1).Build();
            Assert.AreEqual("http://my/path:3000/v1", request.QueryUrl);

            var request2 = LazyGlobalConfiguration.Value.GlobalRequestBuilder(MockServer.Server2).Build();
            Assert.AreEqual("https://my/path/v2", request2.QueryUrl);
        }

        [Test]
        public void TestGlobalRequestHeaders()
        {
            var request = LazyGlobalConfiguration.Value.GlobalRequestBuilder(MockServer.Server1).Build();
            Assert.True(request.Headers.Count == 3);
            Assert.AreEqual("headVal1", request.Headers["additionalHead1"]);
            Assert.AreEqual("headVal2", request.Headers["additionalHead2"]);
            Assert.True(request.Headers["user-agent"].StartsWith("my lang|1.*.*|"));
        }
    }
}
