using System.Collections.Generic;

namespace GWP.Shared
{
    /// <summary>
    /// Cache interface
    /// </summary>
    public interface ICache
    {
        /// <summary>
        /// Return data present in database
        /// </summary>
        /// <returns></returns>
        public string[,] GetData();
    }
}
