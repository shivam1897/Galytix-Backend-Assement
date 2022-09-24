using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWP.Shared
{
    public static class Utility
    {
        public static int GetIndexOfCountry(List<string> inputList, string value)
        {
            return inputList.IndexOf(value);
        }
    }
}
