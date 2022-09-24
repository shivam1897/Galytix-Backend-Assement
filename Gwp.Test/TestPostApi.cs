using GWP.FunctionalLogic;
using GWP.Shared;
using GWPCalculator.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Gwp.Test
{
    [TestClass]
    public class TestPostApi
    {
        private Mock<ILogger<CountryGwp>> _logger;
        private Mock<ICache> _cache;
        private GwpService _service;

        [TestInitialize]
        public void Init()
        {
            _logger = new Mock<ILogger<CountryGwp>>();
            _cache = new Mock<ICache>();
            SetUpCacheObject();
            _service = new GwpService(_cache.Object);
        }

        

        [TestMethod]
        public void POST_API_CALL_TEST()
        {
            var controller = new CountryGwp(_logger.Object, _service);
            var request = new AvgGwpRequest
            {
                Country = "test",
                LineOfBusiness = new System.Collections.Generic.List<string> { "transport" }
            };
            var res = controller.GetAverageGWPOverPeriod(request).Result;

            Assert.IsNotNull(res);
            Assert.AreEqual(request.LineOfBusiness.Count, res.Result.Count);
        }

        /// <summary>
        /// It can be used to set up mock data
        /// </summary>
        private void SetUpCacheObject()
        {
            var data = new string[10, 26];
            _cache.Setup(x => x.GetData()).Returns(data);
        }

    }
}
