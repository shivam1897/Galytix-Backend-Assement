using GWP.Shared;
using System.Collections.Generic;

namespace GWP.FunctionalLogic
{
    public class GwpService: IGwpServices
    {
        private readonly ICache _dataBase;

        public GwpService(ICache cache)
        {
            _dataBase = cache;

        }

        public Dictionary<string, decimal> GetAverageGWPOverPeriod(string[] LineOfBusiness, string startPeriod, string endPeriod)
        {
            var result = new Dictionary<string, decimal>();
            return result;
        }

        public Dictionary<string, decimal> GetAverageGWPOverPeriod(string country, List<string> LineOfBusiness, int startPeriod = 2008, int endPeriod = 2015)
        {
            var countries = _dataBase.GetColumnValue("country");
            var index = Utility.GetIndexOfCountry(countries, country);

            Utility.Get
            var result = new Dictionary<string, decimal>();
            return result;
        }
    }
}
