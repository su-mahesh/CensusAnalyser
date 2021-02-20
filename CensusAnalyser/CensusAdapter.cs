using System.IO;

namespace IndianStateCensusAnalyser
{
    public abstract class CensusAdapter
    {
        string[] CensusData;
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
            if (!File.Exists(csvFilePath))
            {
                throw new CensusAnalyserException("file not found", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);
            }
            if (Path.GetExtension(csvFilePath) != ".csv")
            {
                throw new CensusAnalyserException("invalid file type", CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE);
            }
            CensusData = File.ReadAllLines(csvFilePath);
            if (CensusData[0] != dataHeader)
            {
                throw new CensusAnalyserException("incorrect header in data", CensusAnalyserException.ExceptionType.INCORRECT_HEADER);
            }
            return CensusData;
        }
    }
}
