using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    [Serializable]
    public class VaccineStation
    {
        public string Province { get; }
        public string City { get; }
        public string PostalCode { get; }

        public string StationName { get; }
        private int NumberOfNurses { get; set; }

        private int MorningStartServiceTime { get; set; }
        private int MorningEndServiceTime { get; set; }

        private int EveningStartServiceTime { get; set; }
        private int EveningEndServiceTime { get; set; }

        public bool[] Vaccines { get; set; }
        
        public VaccineStation
            (string _province,
            string _city,
            string _stationName,
            int _numberOfNurses,
            int _morningStartServiceTime,
            int _morningEndServiceTime,
            int _eveningStartServiceTime,
            int _eveningEndServiceTime,
            string _postalCode)
        {
            Province = _province;
            City = _city;
            StationName = _stationName;
            NumberOfNurses = _numberOfNurses;
            MorningStartServiceTime = _morningStartServiceTime;
            MorningEndServiceTime = _morningEndServiceTime;
            EveningStartServiceTime = _eveningStartServiceTime;
            EveningEndServiceTime = _eveningEndServiceTime;
            PostalCode = _postalCode;
        }

        public static string VaccineStationToString(VaccineStation _vaccineStation)
        {
            return _vaccineStation.Province + ","
                + _vaccineStation.City + ","
                + _vaccineStation.StationName + ","
                + _vaccineStation.NumberOfNurses + ","
                + _vaccineStation.MorningStartServiceTime + ","
                + _vaccineStation.MorningEndServiceTime + ","
                + _vaccineStation.EveningStartServiceTime + ","
                + _vaccineStation.EveningEndServiceTime + ","
                + _vaccineStation.PostalCode;
        }

        public static VaccineStation StringToVaccineStation(string _stringedVaccineStation)
        {
            string[] ListedInput = _stringedVaccineStation.Split(',');

            string _province = Convert.ToString(ListedInput[0]);
            string _city = Convert.ToString(ListedInput[1]);
            string _stationName = Convert.ToString(ListedInput[2]);
            int _numberOfNurses = Convert.ToInt32(ListedInput[3]);
            int _morningStartServiceTime = Convert.ToInt32(ListedInput[4]);
            int _morningEndServiceTime = Convert.ToInt32(ListedInput[5]);
            int _eveningStartServiceTime = Convert.ToInt32(ListedInput[6]);
            int _eveningEndServiceTime = Convert.ToInt32(ListedInput[7]);
            string _postalCode = Convert.ToString(ListedInput[8]);

            VaccineStation vaccineStation = new VaccineStation
                (_province,
                _city,
                _stationName,
                _numberOfNurses,
                _morningStartServiceTime,
                _morningEndServiceTime,
                _eveningStartServiceTime,
                _eveningEndServiceTime,
                _postalCode);

            return vaccineStation;
        }
    }
}
