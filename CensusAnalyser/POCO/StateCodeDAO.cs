using System;
namespace IndianStateCensusAnalyser.DTO
{
    public class StateCodeDAO
    {
        public int SerialNumber;
        public string StateName;
        public int tin;
        public string StateCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="StateCodeDAO"/> class.
        /// </summary>
        /// <param name="serialNumber">The serial number.</param>
        /// <param name="StateName">Name of the state.</param>
        /// <param name="tin">The tin.</param>
        /// <param name="StateCode">The state code.</param>
        public StateCodeDAO(string serialNumber, string StateName, string tin, string StateCode)
        {
            SerialNumber = Convert.ToInt32(serialNumber);
            this.StateName = StateName;
            this.tin = Convert.ToInt32(tin);
            this.StateCode = StateCode;
        }
    }
}
