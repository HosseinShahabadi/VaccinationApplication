using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Final
{
    public class SaveLoadAppointment : ISaveLoadAppointment
    {
        public void SaveListToFile(string _path, List<Appointment> _appointment)
        {
            string Data = "";
            foreach (var appointment in _appointment)
            {
                Data += Appointment.AppointmentToString(appointment) + "\n";
            }

            File.WriteAllText(_path, Data);
        }

        public List<Appointment> LoadListFromFile(string _path)
        {
            List<Appointment> Appointments = new List<Appointment>();

            //Loading Data ...
            string[] AppointmentList = File.ReadAllLines(_path);
            foreach (var item in AppointmentList)
            {
                Appointments.Add(Appointment.StringToAppointment(item));
            }

            return Appointments;
        }
    }

    public class AppointmentManager
    {
        private readonly string Path;
        private List<Appointment> AppointmentList { get; set; }
        private readonly ISaveLoadAppointment SaveLoadAppointment;

        public AppointmentManager(string _path, ISaveLoadAppointment _saveLoadAppointment)
        {
            Path = _path;
            SaveLoadAppointment = _saveLoadAppointment;
            AppointmentList = new List<Appointment>();
            if (!File.Exists(Path))
                File.Create(Path).Close();
            else
                AppointmentList = SaveLoadAppointment.LoadListFromFile(Path);
        }

        public void AddAppointment(Appointment _appointment)
        {
            Appointment appointment = SearchAppointment(_appointment.AppointmentNumber);
            if (appointment == null)
            {
                AppointmentList.Add(_appointment);
                SaveLoadAppointment.SaveListToFile(Path, AppointmentList);
            }
        }

        public void RemoveAppointment(Appointment _appointment)
        {
            AppointmentList.Remove(_appointment);
            SaveLoadAppointment.SaveListToFile(Path, AppointmentList);
        }

        public Appointment SearchAppointment(long _appointmentNumber)
        {
            for (int i = 0; i < AppointmentList.Count; i++)
            {
                if (AppointmentList[i].AppointmentNumber == _appointmentNumber)
                {
                    return AppointmentList[i];
                }
            }
            return null;
        }
    }
}
