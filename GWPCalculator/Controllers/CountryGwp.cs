using GWP.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GWPCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryGwp : ControllerBase
    {
        private readonly ILogger<CountryGwp> _logger;
        private readonly IGwpServices _gwpService;

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
        [Route("server/api/gwp/avg")]
        public async Task<AvgGwpResponse> GetAverageGWPOverPeriod([FromBody] AvgGwpRequest request)
        {
            try
            {
                var result = await _gwpService.GetAverageGWPOverPeriod(request.Country, request.LineOfBusiness);
                return new AvgGwpResponse
                {
                    Result = result
                };
            }
            catch(Exception ex)
            {
                _logger.LogError($"{nameof(GetAverageGWPOverPeriod)} failed with error.", ex);
            }

            return new AvgGwpResponse
            {
                Result = new Dictionary<string, decimal>()
            };
        }
    }
}
