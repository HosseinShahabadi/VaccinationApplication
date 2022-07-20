using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public interface ISaveLoadAppointment
    {
        void SaveListToFile(string Path, List<Appointment> Data);
        List<Appointment> LoadListFromFile(string Path);
    }

    public interface ISaveLoadPerson
    {
        void SaveListToFile(string Path, List<Person> Data);
        List<Person> LoadListFromFile(string Path);
    }

    public interface ISaveLoadVaccineStation
    {
        void SaveListToFile(string Path, List<VaccineStation> Data);
        List<VaccineStation> LoadListFromFile(string Path);
    }

    public interface ISaveLoadStorage
    {
        void SaveListToFile(string Path, Storage Storage);
        Storage LoadListFromFile(string Path);
    }
}
