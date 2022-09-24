using System.Collections.Generic;
using System.IO;

namespace GWP.DataBase
{
    /// <summary>
    /// Class to interact with RAW Data
    /// </summary>
    public class CSVDataReader
    {
        private readonly Dictionary<string, List<string>> _data;

        /// <summary>
        /// Accessor to CSV data
        /// </summary>
        public Dictionary<string, List<string>> CSVData { get  => _data; }

        /// <summary>
        /// Constructor
        /// </summary>
        public CSVDataReader()
        {
            _data = new Dictionary<string, List<string>>();
            ReadCsv();
        }

        /// <summary>
        /// Method to read CSV data and store it in a dictionary
        /// </summary>
        private void ReadCsv()
        {
            bool IsFirstLine = true;
            using (var reader = new StreamReader(@"..\gwpByCountry.csv"))
            {

                var keys = new string[100];
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Split(',');
                    
                    int i = 0;
                    foreach (var value in line)
                    {
                        if (IsFirstLine)
                        {
                            
                            keys[i] = value;
                            _data[value] = new List<string>();
                        }
                        else
                        {
                            _data[keys[i]].Add(value);
                        }
                        i++;
                    }
                    i = 0;
                    IsFirstLine = false;

                }

            }
        }
    }
}

