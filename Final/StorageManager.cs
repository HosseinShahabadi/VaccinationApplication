using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class SaveLoadStorage : ISaveLoadStorage
    {
        public void SaveListToFile(string _path, Storage _storage)
        {
            string Data = "";
            Data += Storage.StorageToString(_storage);
            File.WriteAllText(_path, Data);
        }

        public Storage LoadListFromFile(string _path)
        {
            Storage storage = Storage.StringToStorage(File.ReadAllText(_path));
            return storage;
        }
    }

    public class StorageManager
    {
        private readonly string Path;
        private Storage Storage { get; set; }
        private readonly ISaveLoadStorage SaveLoadStorage;

        public StorageManager(string _path, ISaveLoadStorage _saveLoadStorage)
        {
            Path = _path;
            SaveLoadStorage = _saveLoadStorage;
            if (!File.Exists(Path))
                File.Create(Path).Close();
            else
                Storage = SaveLoadStorage.LoadListFromFile(Path);
        }

        public void AddStorage(Storage _storage)
        {
            SaveLoadStorage.SaveListToFile(Path, _storage);
        }

        public void RemoveStorage(Storage _storage)
        {
            SaveLoadStorage.SaveListToFile(Path, _storage);
        }

        public Storage GetStorage()
        {
            return Storage;
        }
    }
}
