using System.Collections.Generic;

namespace GWP.Shared
{
    public interface ICache
    {
        public List<string> GetColumnValue(string columnName);
    }
}
