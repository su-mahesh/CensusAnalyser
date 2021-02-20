using IndianStateCensusAnalyser.POCO;

namespace IndianStateCensusAnalyser.DTO
{
    public class CensusDTO
    {
        public int SerialNumber;
        public string StateName;
        public string state;
        public int tin;
        public string StateCode;
        public long population;
        public long area;
        public long density;
        public long HousingUnits;
        public double TotalArea;
        public double WaterArea;
        public double LandArea;
        public double PopulationDensity;
        public double HousingDensity;

        /// <summary>
        /// Initializes a new instance of the <see cref="CensusDTO"/> class.
        /// </summary>
        /// <param name="CensusDataDao">The census data DAO.</param>
        public CensusDTO(CensusDataDAO CensusDataDao)
        {
            state = CensusDataDao.state;
            population = CensusDataDao.population;
            area = CensusDataDao.area;
            density = CensusDataDao.density;
        }
    }
}
