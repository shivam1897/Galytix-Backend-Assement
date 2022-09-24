using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWP.Shared
{
    /// <summary>
    /// Gwp service interface
    /// </summary>
    public interface IGwpServices
    {
        /// <summary>
        /// Method to return avg GQP over time period
        /// </summary>
        /// <param name="country"></param>
        /// <param name="LineOfBusiness"></param>
        /// <param name="startPeriod"></param>
        /// <param name="endPeriod"></param>
        /// <returns></returns>
        public Task<Dictionary<string, decimal>> GetAverageGWPOverPeriod(string country, List<string>LineOfBusiness, int startPeriod = 2008, int endPeriod = 2015);
    }
}
