using GWP.DataBase;
using GWP.Shared;

namespace GWP.Cache
{
    public class GWPCache : ICache
    {
        private readonly CSVDataReader _dataBaseAccessor;

        public GWPCache()
        {
            _dataBaseAccessor = new CSVDataReader();
        }

        public string[,] GetData()
        {
            return _dataBaseAccessor.CSVData;
        }
    }
}
