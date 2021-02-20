using System.Collections.Generic;
using IndianStateCensusAnalyser;
using IndianStateCensusAnalyser.DTO;
using NUnit.Framework;
using static IndianStateCensusAnalyser.CensusAnalyser;

namespace NUnitTestProject
{
    /// <summary>
    /// test cases class
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// The indian state census headers
        /// </summary>
        static readonly string IndianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        /// <summary>
        /// The indian state census file path
        /// </summary>
        static readonly string IndianStateCensusFilePath = "C:/Users/Mahesh Kangude/source/repos/IndianStateAnalyser/NUnitTestProject/CSVFiles/IndiaStateCensusData.csv";
        static readonly string WrongIndianCensusStateFilePath = "C:/Users/Mahesh Kangude/source/repos/IndianStateAnalyser/NUnitTestProject/CSVFiles/NonExistIndiaStateCensusData.csv";
        static readonly string IncorrectTypeIndianCensusStateFilePath = "C:/Users/Mahesh Kangude/source/repos/IndianStateAnalyser/NUnitTestProject/CSVFiles/IndiaStateCensusData.txt";
        static readonly string IncorrectDelimiterTypeIndianCensusStateFilePath = "C:/Users/Mahesh Kangude/source/repos/CensusAnalyser/NUnitTestProject/CSVFiles/IncorrectDelimiterIndiaStateCensusData.csv";
        static readonly string IncorrectHeaderTypeIndianCensusStateFilePath = "C:/Users/Mahesh Kangude/source/repos/CensusAnalyser/NUnitTestProject/CSVFiles/IncorrectHeaderIndiaStateCensusData.csv";

        /// <summary>
        /// The indian state code headers
        /// </summary>
        static readonly string IndianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        /// <summary>
        /// The indian state code file path
        /// </summary>
        static readonly string IndianStateCodeFilePath = "C:/Users/Mahesh Kangude/source/repos/CensusAnalyser/NUnitTestProject/CSVFiles/IndiaStateCodeData.csv";

        /// <summary>
        /// The census analyser object declaration
        /// </summary>
        CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;

        /// <summary>
        /// Setups this instance to inilialise objects
        /// </summary>
        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }
        /// <summary>
        /// Givens the indian census data file when readed should return data count.
        /// </summary>
        [Test]
        public void GivenIndianCensusDataFile_WhenReaded_ShouldReturnDataCount()
        {
            totalRecord = censusAnalyser.LoadCensusData(Country.INDIA, IndianStateCensusFilePath, IndianStateCensusHeaders);
            Assert.AreEqual(29, totalRecord.Count);
        }
        /// <summary>
        /// Givens the non exist indian census data file when readed should return custom exception.
        /// </summary>
        [Test]
        public void GivenNonExistIndianCensusDataFile_WhenReaded_ShouldReturnCustomException()
        {
            var CensusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(Country.INDIA, WrongIndianCensusStateFilePath, IndianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.FILE_NOT_FOUND, CensusException.exceptionType);
        }
        /// <summary>
        /// Givens the incorrect type indian census data file when readed should return custom exception.
        /// </summary>
        [Test]
        public void GivenIncorrectTypeIndianCensusDataFile_WhenReaded_ShouldReturnCustomException()
        {
            var CensusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(Country.INDIA, IncorrectTypeIndianCensusStateFilePath, IndianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE, CensusException.exceptionType);       
        }
        /// <summary>
        /// Givens the incorrect delimiter indian census data file when readed should return custom exception.
        /// </summary>
        [Test]
        public void GivenIncorrectDelimiterIndianCensusDataFile_WhenReaded_ShouldReturnCustomException()
        {
            var CensusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(Country.INDIA, IncorrectDelimiterTypeIndianCensusStateFilePath, IndianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER, CensusException.exceptionType);
        }
        /// <summary>
        /// Givens the incorrect header indian census data file when readed should return custom exception.
        /// </summary>
        [Test]
        public void GivenIncorrectHeaderIndianCensusDataFile_WhenReaded_ShouldReturnCustomException()
        {
            var CensusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(Country.INDIA, IncorrectHeaderTypeIndianCensusStateFilePath, IndianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_HEADER, CensusException.exceptionType);
        }

        [Test]
        public void GivenIndianStateCodeFile_WhenReaded_ShouldReturnDataCount()
        {
            stateRecord = censusAnalyser.LoadCensusData(Country.INDIA, IndianStateCodeFilePath, IndianStateCodeHeaders);
            Assert.AreEqual(37, stateRecord.Count);
        }
    }
}