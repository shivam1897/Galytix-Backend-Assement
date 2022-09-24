using GWP.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace GWPCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryGwp : ControllerBase
    {
        private readonly ILogger<CountryGwp> _logger;
        private IGwpServices _gwpService;

        public CountryGwp(ILogger<CountryGwp> logger, IGwpServices service)
        {
            _logger = logger;
            _gwpService = service;
        }

        [HttpGet]
        public string Get()
        {
            return "This assignment is submitted by Shivam Singh Yadav. Please test the POST request";
        }
        
        [HttpPost]
        public Dictionary<string, decimal> GetAverageGWPOverPeriod([FromBody] AvgGwpRequest request)
        {
            var result = _gwpService.GetAverageGWPOverPeriod(request.Country, request.LineOfBusiness);
            return result;
        }
    }
}
