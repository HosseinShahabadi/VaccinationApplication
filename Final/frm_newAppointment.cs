using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class frm_newAppointment : System.Windows.Forms.Form
    {
        public static string StartupPath = (System.IO.Directory.GetCurrentDirectory() + "\\Data\\");
        private static string PersonsPath = StartupPath + "Persons.txt";
        private static string AppointmentsPath = StartupPath + "Appointments.txt";
        private static string VaccineStationsPath = StartupPath + "VaccineStations.txt";
        private static string StoragePath = StartupPath + "Storages\\";

        public PersonManager personManager = new PersonManager(PersonsPath, new SaveLoadPerson());
        public AppointmentManager appointmentManager = new AppointmentManager(AppointmentsPath, new SaveLoadAppointment());
        public VaccineStationManager vaccineStationManager = new VaccineStationManager(VaccineStationsPath, new SaveLoadVaccineStation());

        Person person;
        VaccineStation vaccineStation;
        StorageManager storageManager;

        bool SearchFlag = false;
        bool SubmitFlag = false;

        public frm_newAppointment()
        {
            InitializeComponent();
            dtp_vaccineDate.MinDate = DateTime.Now;
            dtp_vaccineTime.MinDate = DateTime.Now;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (SearchFlag)
            {
                string National_ID = txtbx_nationalID.Text;
                person = personManager.SearchPerson(National_ID);
                if (person != null)
                {
                    lbl_result.Text = "Great! Now Fill this form";
                    lbl_result.ForeColor = Color.FromArgb(255, 190, 250, 145);

                    lbl_firstNameRes.Text = person.GetFirstName();
                    lbl_lastNameRes.Text = person.GetLastName();

                    if (person.isVaccinated != 0)
                    {
                        lbl_numberOfDosesRes.Text = (person.isVaccinated).ToString();
                        lbl_dosesRes.Text = person.Vaccines;
                    }
                    else
                    {
                        lbl_numberOfDosesRes.Text = "0";
                        lbl_dosesRes.Text = "Not Vaccinated yet";
                    }

                    FormPanel.Enabled = true;
                }

                else
                {
                    lbl_result.Text = "Not Found!";
                    lbl_result.ForeColor = Color.Red;

                    lbl_firstNameRes.Text = "First Name";
                    lbl_lastNameRes.Text = "Last Name";

                    lbl_numberOfDosesRes.Text = "Number";
                    lbl_dosesRes.Text = "Doses";
                    FormPanel.Enabled = false;
                }
            }
        }

        private void txtbx_nationalID_TextChanged(object sender, EventArgs e)
        {
            if (IsNumeric(txtbx_nationalID.Text) && txtbx_nationalID.Text.Length == 10)
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

        private void txtbx_TextChanged(object sender, EventArgs e)
        {
            if (cbx_vaccineStationName.Text != "")
            {
                cbx_vaccineType.Enabled = true;
                SubmitFlag = true;
                vaccineStation = vaccineStationManager.SearchVaccineStation(cbx_province.Text, cbx_city.Text, cbx_vaccineStationName.Text);
                btn_submit.BackColor = Color.FromArgb(255, 190, 250, 145);
            }

            else
            {
                cbx_vaccineType.Enabled = false;
                SubmitFlag = false;
                btn_submit.BackColor = Color.FromArgb(255, 50, 50, 50);
            }
        }

        private void cbx_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_city.Items.Clear();
            cbx_city.Items.AddRange(File.ReadAllLines(StartupPath + "\\Cities\\" + cbx_province.Text + ".txt"));
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (SubmitFlag)
            {
                if (vaccineStation != null)
                {
                    Appointment appointment = new Appointment
                        (person,
                        cbx_vaccineType.Text,
                        vaccineStation,
                        dtp_vaccineDate.Value,
                        dtp_vaccineTime.Value);

                    appointmentManager.AddAppointment(appointment);
                    btn_submit.BackColor = Color.FromArgb(255, 190, 250, 145);
                    lbl_result.ForeColor = Color.FromArgb(255, 190, 250, 145);
                    lbl_result.Text = "Your Appointment Number is " + appointment.AppointmentNumber.ToString();
                }
                else
                {
                    lbl_result.Text = "There is no Vaccine Station with this Information";
                    lbl_result.ForeColor = Color.Red;
                    btn_submit.BackColor = Color.White;
                }
            }
        }

        private void btn_closestStation_Click(object sender, EventArgs e)
        {
            //Will Use Stations Address and Find Closest Station to user address
            //Coordinate userCoordinate = person.HomeAddress.ExactLocation;
            string userPostalCode = person.HomeAddress.PostalCode;
            VaccineStation closestStation = vaccineStationManager.ClosestStation(userPostalCode);
            cbx_province.Text = closestStation.Province;
            cbx_city.Text = closestStation.City;
            cbx_vaccineStationName.Text = closestStation.StationName;
        }

        private void cbx_vaccineType_TextChanged(object sender, EventArgs e)
        {
            if (vaccineStation != null)
            {
                storageManager = new StorageManager(StoragePath + vaccineStation.PostalCode + ".txt", new SaveLoadStorage());
                Storage storage = storageManager.GetStorage();
                lbl_result.Text = "Great! Now Fill this form";
                lbl_result.ForeColor = Color.FromArgb(255, 190, 250, 145);

                cbx_vaccineType.Items.Clear();
                cbx_vaccineType.Items.AddRange(storage.Doses.Keys.ToArray());
            }
            else
            {
                lbl_result.Text = "There is no Vaccine Station with this Information";
                lbl_result.ForeColor = Color.Red;
                btn_submit.BackColor = Color.White;
            }
        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
    }
}
