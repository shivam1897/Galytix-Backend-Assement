using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWP.Shared
{
    public interface IGwpServices
    {
        public Dictionary<string, decimal> GetAverageGWPOverPeriod(string country, List<string>LineOfBusiness, int startPeriod = 2008, int endPeriod = 2015);
    }
}
