using GWP.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GWP.FunctionalLogic
{
    /// <summary>
    /// Class responsibel for serving services over Gwp
    /// </summary>
    public class GwpService: IGwpServices
    {
        private readonly ICache _dataCache;

        public GwpService(ICache cache)
        {
            _dataCache = cache;
        }

        /// <summary>
        /// Provides average gross written premium (GWP) over 2008-2015
        /// </summary>
        /// <param name="country"></param>
        /// <param name="LineOfBusiness"></param>
        /// <param name="startPeriod"></param>
        /// <param name="endPeriod"></param>
        /// <returns></returns>
        public Task<Dictionary<string, decimal>> GetAverageGWPOverPeriod(string country, List<string> LineOfBusiness, int startPeriod = 2008, int endPeriod = 2015)
        {
            var result = new Dictionary<string, decimal>();
            foreach (var lob in LineOfBusiness)
            {
                var avgGwp = CalculateAvgGwp(lob, country, startPeriod, endPeriod);
                result[lob] = avgGwp;
            }

            return Task.FromResult(result);
        }

        private decimal CalculateAvgGwp(string lob, string country, int startPeriod, int endPeriod)
        {
            var data = _dataCache.GetData();
            int lobIndex = 3;
            int startPeriodIndex = 11;
            int endPeriodIndex = 11 + (endPeriod - startPeriod);
            decimal temp = 0m;

            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (string.IsNullOrEmpty(data[i, 0]) || !data[i, 0].Equals(country))
                        continue;

                    if (data[i, lobIndex].Equals(lob))
                    {
                        for (int j = startPeriodIndex; j <= endPeriodIndex; j++)
                        {
                            if (decimal.TryParse(data[i, j], out decimal result))
                                temp += result;
                        }
                    }
                }
                return temp / (endPeriod - startPeriod);
            }
            catch
            {
                temp = 0m;
            }
            return temp;
        }
    }
}
