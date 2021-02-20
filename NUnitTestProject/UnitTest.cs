using System.Collections.Generic;
using IndianStateCensusAnalyser;
using IndianStateCensusAnalyser.DTO;
using NUnit.Framework;
using static IndianStateCensusAnalyser.CensusAnalyser;

namespace NUnitTestProject
{

    public class Tests
    {
        static readonly string IndianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        static readonly string IndianStateCensusFilePath = "C:/Users/Mahesh Kangude/source/repos/IndianStateAnalyser/NUnitTestProject/CSVFiles/IndiaStateCensusData.csv";

        /// <summary>
        /// The census analyser object declaration
        /// </summary>
        CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;

        /// <summary>
        /// Setups this instance to inilialise objects
        /// </summary>
        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
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
    }
}