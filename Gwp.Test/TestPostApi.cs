using GWP.FunctionalLogic;
using GWP.Shared;
using GWPCalculator.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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
            var result = controller.GetAverageGWPOverPeriod(request);

            Assert.IsNotNull(result);
        }
    }
}
