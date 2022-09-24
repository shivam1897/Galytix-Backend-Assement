using GWP.DataBase;
using GWP.Shared;

namespace GWP.Cache
{
    /// <summary>
    /// Class to provide data access as cache
    /// </summary>
    public class GWPCache : ICache
    {
        private readonly CSVDataReader _dataBaseAccessor;

        public GWPCache()
        {
            _dataBaseAccessor = new CSVDataReader();
        }

        ///<inheritdoc/>
        public string[,] GetData() => _dataBaseAccessor.CSVData;
    }
}
