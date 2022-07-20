using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class frm_vaccineInjection : System.Windows.Forms.Form
    {

        public static string StartupPath = (System.IO.Directory.GetCurrentDirectory() + "\\Data\\");
        private static string PersonsPath = StartupPath + "Persons.txt";
        private static string AppointmentsPath = StartupPath + "Appointments.txt";
        private static string StoragePath = StartupPath + "Storages\\";

        public PersonManager personManager = new PersonManager(PersonsPath, new SaveLoadPerson());
        public AppointmentManager appointmentManager = new AppointmentManager(AppointmentsPath, new SaveLoadAppointment());

        Person person;
        Appointment appointment;

        bool SearchFlag = false;
        bool SubmitFlag = false;

        public frm_vaccineInjection()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (SearchFlag)
            {
                long AppointmentNumber = Convert.ToInt64(txtbx_appointmentNumber.Text);
                appointment = appointmentManager.SearchAppointment(AppointmentNumber);
                if (appointment != null)
                {
                    person = personManager.SearchPerson(appointment.GetPerson().National_ID);
                    lbl_result.Text = "You can now Confirm this Appointment";
                    lbl_result.ForeColor = Color.FromArgb(255, 190, 250, 145);

                    lbl_firstNameRes.Text = person.GetFirstName();
                    lbl_lastNameRes.Text = person.GetLastName();

                    lbl_vaccineDateRes.Text = appointment.VaccineDate.ToShortDateString();

                    if (person.isVaccinated != 0)
                        lbl_numberOfDosesRes.Text = (person.isVaccinated + 1).ToString();
                    else
                        lbl_numberOfDosesRes.Text = "1";

                    lbl_doseRes.Text = appointment.GetVaccineType();

                    if (appointment.Status == 2)
                    {
                        lbl_result.Text = "This Appointment is already Confirmed!";
                        SubmitFlag = false;
                        lbl_result.ForeColor = Color.Red;
                    }
                    else
                    {
                        SubmitFlag = true;
                        btn_confirm.ForeColor = Color.FromArgb(255, 190, 250, 145);
                    }
                }

                else
                {
                    lbl_result.Text = "Not Found!";
                    lbl_result.ForeColor = Color.Red;

                    lbl_firstNameRes.Text = "First Name";
                    lbl_lastNameRes.Text = "Last Name";

                    lbl_numberOfDosesRes.Text = "Number";
                    lbl_doseRes.Text = "Dose";

                    SubmitFlag = false;
                    btn_confirm.ForeColor = Color.FromArgb(255, 33, 33, 33);
                }
            }
            else
            {
                lbl_result.Text = "Double check your Appointment Number";
                lbl_result.ForeColor = Color.Red;
            }
        }

        private void txtbx_appointmentNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_appointmentNumber.Text.Length == 9 && IsNumeric(txtbx_appointmentNumber.Text))
            {
                SearchFlag = true;
                btn_search.BackColor = Color.FromArgb(255, 190, 250, 145);
            }

            else
            {
                SearchFlag = false;
                btn_search.BackColor = Color.FromArgb(255, 50, 50, 50);
            }
        }
        
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (SubmitFlag)
            {
                appointmentManager.RemoveAppointment(appointment);
                personManager.RemovePerson(person);

                person.isVaccinated += 1;
                person.Vaccines = appointment.GetVaccineType();
                appointment.Status = 2;

                personManager.AddPerson(person);
                appointmentManager.AddAppointment(appointment);

                lbl_result.Text = "Injection Confirmed";
                btn_confirm.ForeColor = Color.FromArgb(255, 33, 33, 33);

                StorageManager storageManager = new StorageManager(StoragePath + appointment.GetVaccineStation().PostalCode + ".txt", new SaveLoadStorage());
                Storage storage = storageManager.GetStorage();
                storageManager.RemoveStorage(storage);
                int oldNumberOfDoses = storage.Doses[appointment.GetVaccineType()];
                storage.Doses.Remove(appointment.GetVaccineType());
                storage.Doses.Add(appointment.GetVaccineType(), (oldNumberOfDoses - 1));
                storageManager.AddStorage(storage);
            }
        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
    }
}
