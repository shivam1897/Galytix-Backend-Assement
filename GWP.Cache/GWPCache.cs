using GWP.DataBase;
using GWP.Shared;
using System.Collections.Generic;

namespace GWP.Cache
{
    public class GWPCache : ICache
    {
        private readonly CSVDataReader _dataBaseAccessor;

        public GWPCache()
        {
            _dataBaseAccessor = new CSVDataReader();
        }

        public CSVDataReader DataBaseAccessor => _dataBaseAccessor;

        public List<string> GetColumnValue(string columnName)
        {
            DataBaseAccessor.CSVData.TryGetValue(columnName, out List<string> result);
            return result;
        }
    }
}
