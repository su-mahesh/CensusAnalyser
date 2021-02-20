using System.IO;

namespace IndianStateCensusAnalyser
{
    public abstract class CensusAdapter
    {
        /// <summary>
        /// Gets the census data.
        /// </summary>
        /// <param name="csvFilePath">The CSV file path.</param>
        /// <param name="dataHeader">The data header.</param>
        /// <returns></returns>
        /// <exception cref="IndianStateCensusAnalyser.CensusAnalyserException">
        /// file not found
        /// or
        /// invalid file type
        /// or
        /// incorrect header in data
        /// </exception>
        protected string[] GetCensusData(string csvFilePath, string dataHeader) 
        {
            if (File.Exists(csvFilePath))
            {
                return File.ReadAllLines(csvFilePath);
            }
            return null;
        }
    }
}
