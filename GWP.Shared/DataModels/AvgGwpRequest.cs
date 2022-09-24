using System.Collections.Generic;

namespace GWP.Shared
{
    /// <summary>
    /// HTTP Post request object
    /// </summary>
    public class AvgGwpRequest
    {
        /// <summary>
        /// Country name
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Line Of Business
        /// </summary>
        public List<string> LineOfBusiness { get; set; }
    }
}
