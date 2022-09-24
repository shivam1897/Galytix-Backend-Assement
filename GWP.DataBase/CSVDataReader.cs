using System.Collections.Generic;
using System.IO;

namespace GWP.DataBase
{
    /// <summary>
    /// Class to interact with RAW Data
    /// </summary>
    public class CSVDataReader
    {
        private readonly string [, ] _data;

        /// <summary>
        /// Accessor to CSV data
        /// </summary>
        public string[,] CSVData { get => _data; }

        /// <summary>
        /// Constructor
        /// </summary>
        public CSVDataReader()
        {
            _data = new string[1000, 26];
            ReadCsv();
        }

        /// <summary>
        /// Method to read CSV data and store it in a dictionary
        /// </summary>
        private void ReadCsv()
        {
            using (var reader = new StreamReader(@"..\gwpByCountry.csv"))
            {

                int i = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Split(',');
                    int j = 0;
                    foreach(var value in line)
                    {
                        _data[i, j] = value;
                        j++;
                    }
                    i++;
                }
            }
        }
    }
}

