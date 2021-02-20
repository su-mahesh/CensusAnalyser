﻿using System;
using System.Collections.Generic;
using System.Text;
using IndianStateCensusAnalyser.DTO;

namespace IndianStateCensusAnalyser
{
    public class CensusAnalyser
    {
        /// <summary>
        /// Countries for census data
        /// </summary>
        public enum Country
        {
            INDIA, US, BRAZIL
        }

        Dictionary<string, CensusDTO> dataMap;
        /// <summary>
        /// Loads the census data.
        /// </summary>
        /// <param name="country">The country.</param>
        /// <param name="csvFilePath">The CSV file path.</param>
        /// <param name="dataHeaders">The data headers.</param>
        /// <returns></returns>
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}
