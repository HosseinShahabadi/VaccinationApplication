using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    [Serializable]
    public class Appointment
    {
        public long AppointmentNumber { get; }
        public int Status { get; set; }
        public enum StatusEnum { Passed, Waiting, Injected }

        private Person Person { get; }
        private string VaccineType { get; set; }

        private VaccineStation VaccineStation { get; }
        public DateTime VaccineDate { get; set; }
        public DateTime VaccineTime { get; set; }

        public Appointment(Person _person, string _vaccineType, VaccineStation _vaccineStation, DateTime _vaccineDate, DateTime _vaccineTime)
        {
            Random random = new Random();
            Person = _person;
            VaccineType = _vaccineType;
            VaccineStation = _vaccineStation;
            VaccineDate = _vaccineDate;
            VaccineTime = _vaccineTime;
            Status = 1;
            AppointmentNumber = random.Next(100000000,999999999);
        }

        public Appointment(Person _person, string _vaccineType, VaccineStation _vaccineStation, DateTime _vaccineDate, DateTime _vaccineTime, int _status, long _appointmentNumber)
        {
            Person = _person;
            VaccineType = _vaccineType;
            VaccineStation = _vaccineStation;
            VaccineDate = _vaccineDate;
            VaccineTime = _vaccineTime;
            Status = _status;
            AppointmentNumber = _appointmentNumber;
        }

        public static string AppointmentToString(Appointment _appointment)
        {
            return Person.PersonToString(_appointment.Person) + ","
                + _appointment.VaccineType + ","
                + VaccineStation.VaccineStationToString(_appointment.VaccineStation) + ","
                + _appointment.VaccineDate.ToShortDateString() + ","
                + _appointment.VaccineTime.ToString() + ","
                + _appointment.Status.ToString() + ","
                + _appointment.AppointmentNumber;
        }

        public static Appointment StringToAppointment(string _stringedAppointment)
        {
            string[] ListedInput = _stringedAppointment.Split(',');

            Person person = Person.StringToPerson(_stringedAppointment);
            string vaccineType = ListedInput[18];
            VaccineStation vaccineStation = VaccineStation.StringToVaccineStation
                (ListedInput[19] + "," + ListedInput[20] + "," + ListedInput[21] + ","
                + ListedInput[22] + "," + ListedInput[23] + "," + ListedInput[24] + ","
                + ListedInput[25] + "," + ListedInput[26] + "," + ListedInput[27]);
            DateTime vaccineDate = Convert.ToDateTime(ListedInput[28]);
            DateTime vaccineTime = Convert.ToDateTime(ListedInput[29]);
            int status = Convert.ToInt16(ListedInput[30]);
            long appointmentNumber = Convert.ToInt64(ListedInput[31]);

            Appointment appointment = new Appointment(person, vaccineType, vaccineStation, vaccineDate, vaccineTime, status, appointmentNumber);

            return appointment;
        }

        public Person GetPerson()
        {
            return Person;
        }

        public string GetVaccineType()
        {
            return VaccineType;
        }

        public VaccineStation GetVaccineStation()
        {
            return VaccineStation;
        }
    }
}
