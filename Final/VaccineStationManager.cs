using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class SaveLoadVaccineStation : ISaveLoadVaccineStation
    {
        public void SaveListToFile(string _path, List<VaccineStation> _vaccineStation)
        {
            string Data = "";
            foreach (var station in _vaccineStation)
            {
                Data += VaccineStation.VaccineStationToString(station) + "\n";
            }

            File.WriteAllText(_path, Data);
        }

        public List<VaccineStation> LoadListFromFile(string _path)
        {
            List<VaccineStation> VaccineStations = new List<VaccineStation>();

            //Loading Data ...
            string[] VaccineStationList = File.ReadAllLines(_path);
            foreach (var item in VaccineStationList)
            {
                VaccineStations.Add(VaccineStation.StringToVaccineStation(item));
            }

            return VaccineStations;
        }
    }
    
    public class VaccineStationManager
    {
        private readonly string Path;
        private List<VaccineStation> VaccineStationList { get; set; }
        private readonly ISaveLoadVaccineStation SaveLoadVaccineStation;

        public VaccineStationManager(string _path, ISaveLoadVaccineStation _saveLoadVaccineStation)
        {
            Path = _path;
            SaveLoadVaccineStation = _saveLoadVaccineStation;
            VaccineStationList = new List<VaccineStation>();
            if (!File.Exists(Path))
                File.Create(Path).Close();
            else
                VaccineStationList = SaveLoadVaccineStation.LoadListFromFile(Path);
        }

        public void AddVaccineStation(VaccineStation _vaccineStation)
        {
            VaccineStation VaccineStation = SearchVaccineStation(_vaccineStation.Province, _vaccineStation.City, _vaccineStation.StationName);
            if (VaccineStation == null)
            {
                VaccineStationList.Add(_vaccineStation);
                SaveLoadVaccineStation.SaveListToFile(Path, VaccineStationList);
            }
            else
            {
                VaccineStationList.Remove(VaccineStation);
                VaccineStationList.Add(_vaccineStation);
                SaveLoadVaccineStation.SaveListToFile(Path, VaccineStationList);
            }
        }

        public void RemoveVaccineStation(VaccineStation _vaccineStation)
        {
            VaccineStationList.Remove(_vaccineStation);
            SaveLoadVaccineStation.SaveListToFile(Path, VaccineStationList);
        }

        public VaccineStation SearchVaccineStation(string _province, string _city, string _stationName)
        {
            for (int i = 0; i < VaccineStationList.Count; i++)
            {
                if (VaccineStationList[i].Province == _province)
                {
                    if (VaccineStationList[i].City == _city)
                    {
                        if (VaccineStationList[i].StationName == _stationName)
                        {
                            return VaccineStationList[i];
                        }
                    }
                }
            }
            return null;
        }

        public VaccineStation ClosestStation(Coordinate _userCoordinate)
        {
            VaccineStation VaccineStation = VaccineStationList[0];
            Coordinate VaccineStationCoordinate = new Coordinate(VaccineStationList[0].PostalCode);
            double VaccineStationDistance = Coordinate.Distance(_userCoordinate, VaccineStationCoordinate);

            for (int i = 1; i < VaccineStationList.Count; i++)
            {
                Coordinate StationCoordinate = new Coordinate(VaccineStationList[i].PostalCode);
                double Distance = Coordinate.Distance(_userCoordinate, StationCoordinate);

                if (VaccineStationDistance > Distance)
                {
                    VaccineStation = VaccineStationList[i];
                    VaccineStationDistance = Distance;
                }
            }

            return VaccineStation;
        }

        public VaccineStation ClosestStation(string _userPostalCode)
        {
            VaccineStation VaccineStation = VaccineStationList[0];
            string VaccineStationPostalCode = VaccineStationList[0].PostalCode;
            long VaccineStationDistance = Coordinate.Distance(_userPostalCode, VaccineStationPostalCode);

            for (int i = 1; i < VaccineStationList.Count; i++)
            {
                string StationPostalCode = VaccineStationList[i].PostalCode;
                long Distance = Coordinate.Distance(_userPostalCode, StationPostalCode);

                if (VaccineStationDistance > Distance)
                {
                    VaccineStation = VaccineStationList[i];
                    VaccineStationDistance = Distance;
                }
            }

            return VaccineStation;
        }
    }
}
