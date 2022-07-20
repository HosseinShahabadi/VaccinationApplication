using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Storage
    {
        private VaccineStation VaccineStation { get; }
        public Dictionary<string, int> Doses { get; set; }
        public Storage(VaccineStation _vaccineStation, List<string> _doses)
        {
            VaccineStation = _vaccineStation;
            Dictionary<string, int> doses = new Dictionary<string, int>();

            foreach (var item in _doses)
            {
                doses.Add(item, 30);
            }

            Doses = doses;
        }

        public Storage(VaccineStation _vaccineStation, Dictionary<string, int> _doses)
        {
            VaccineStation = _vaccineStation;
            Doses = _doses;
        }

        public static string StorageToString(Storage _storage)
        {
            return VaccineStation.VaccineStationToString(_storage.VaccineStation) + "," + Storage.StorageDictionaryToString(_storage.Doses);
        }

        public static Storage StringToStorage(string _stringedStorage)
        {
            string[] ListedInput = _stringedStorage.Split(',');

            VaccineStation vaccineStation = VaccineStation.StringToVaccineStation(_stringedStorage);
            Dictionary<string, int> Doses = Storage.StringToStorageDictionary(ListedInput[9]);

            Storage storage = new Storage(vaccineStation, Doses);

            return storage;
        }

        public static string StorageDictionaryToString(Dictionary<string, int> _dictionary)
        {
            string Result = "";
            int Counter = 0;
            foreach (var item in _dictionary)
            {
                Result += (item.Key + "|" + item.Value);
                Counter++;
                if (_dictionary.Count > Counter)
                {
                    Result += ":";
                }
            }

            return Result;
        }

        public static Dictionary<string, int> StringToStorageDictionary(string _stringedDictionary)
        {
            Dictionary<string, int> Dictionary = new Dictionary<string, int>();

               string[] ListedInput = _stringedDictionary.Split(':');
            foreach (var item in ListedInput)
            {
                string[] ListedDictionary = item.Split('|');
                Dictionary.Add(ListedDictionary[0], Convert.ToInt32(ListedDictionary[1]));
            }
            
            return Dictionary;
        }
    }
}
