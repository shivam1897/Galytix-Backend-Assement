using System.Collections.Generic;

namespace GWP.Shared
{
    /// <summary>
    /// DTO to capture response
    /// </summary>
    public class AvgGwpResponse
    {
        /// <summary>
        /// Contains result 
        /// </summary>
        public Dictionary<string, decimal> Result { get; set; }
    }
}
