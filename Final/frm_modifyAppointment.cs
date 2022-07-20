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
    public partial class frm_modifyAppointment : System.Windows.Forms.Form
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
        Appointment existingAppointment;
        VaccineStation vaccineStation;
        StorageManager storageManager;

        bool SearchFlag = false;
        bool SubmitFlag = false;

        public frm_modifyAppointment()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (SearchFlag)
            {
                long AppointmentNumber = Convert.ToInt64(txtbx_appointmentNumber.Text);
                existingAppointment = appointmentManager.SearchAppointment(AppointmentNumber);
                if (existingAppointment != null)
                {
                    if (DateTime.Now > existingAppointment.VaccineDate)
                    {
                        lbl_result.Text = "This Appointment is Over\nYou can get a new One";
                        lbl_result.ForeColor = Color.FromArgb(255, 128, 170, 255);

                        lbl_firstNameRes.Text = "First Name";
                        lbl_lastNameRes.Text = "Last Name";

                        lbl_numberOfDosesRes.Text = "Number";
                        lbl_doseRes.Text = "Dose";
                        FormPanel.Enabled = false;
                    }
                    else
                    {
                        person = existingAppointment.GetPerson();
                        lbl_result.Text = "Great! Now you can modify your Choices";
                        lbl_result.ForeColor = Color.FromArgb(255, 190, 250, 145);

                        lbl_firstNameRes.Text = person.GetFirstName();
                        lbl_lastNameRes.Text = person.GetLastName();

                        cbx_province.Text = existingAppointment.GetVaccineStation().Province;
                        cbx_city.Text = existingAppointment.GetVaccineStation().City;
                        cbx_vaccineStationName.Text = existingAppointment.GetVaccineStation().StationName;
                        cbx_vaccineType.Text = existingAppointment.GetVaccineType();

                        dtp_vaccineDate.Value = existingAppointment.VaccineDate;
                        dtp_vaccineTime.Value = existingAppointment.VaccineTime;

                        if (person.isVaccinated != 0)
                            lbl_numberOfDosesRes.Text = (person.isVaccinated + 1).ToString();
                        else
                            lbl_numberOfDosesRes.Text = "1";

                        lbl_doseRes.Text = existingAppointment.GetVaccineType();

                        dtp_vaccineDate.MinDate = DateTime.Now;
                        dtp_vaccineTime.MinDate = DateTime.Now;

                        FormPanel.Enabled = true;
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
                    FormPanel.Enabled = false;
                }
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
                btn_delete.ForeColor = Color.FromArgb(255, 190, 250, 145);
            }

            else
            {
                cbx_vaccineType.Enabled = true;
                SubmitFlag = false;
                btn_submit.BackColor = Color.FromArgb(255, 50, 50, 50);
                btn_delete.ForeColor = Color.FromArgb(255, 33, 33, 33);
            }
        }

        private void txtbx_appointmentNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_appointmentNumber.Text != "" && txtbx_appointmentNumber.Text.Length == 9)
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

                    appointmentManager.RemoveAppointment(existingAppointment);
                    appointmentManager.AddAppointment(appointment);
                    btn_submit.BackColor = Color.FromArgb(255, 190, 250, 145);
                    lbl_result.Text = "Your Appointment Number is " + appointment.AppointmentNumber.ToString();
                }
                else
                {
                    lbl_result.Text = "There is no Vaccine Station with this Information";
                    btn_submit.BackColor = Color.White;
                }
            }
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            appointmentManager.RemoveAppointment(existingAppointment);
            lbl_result.Text = "Your Appointment has been Removed";
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

        private void cbx_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_city.Items.Clear();
            cbx_city.Items.AddRange(File.ReadAllLines(StartupPath + "\\Cities\\" + cbx_province.Text + ".txt"));
        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        public bool IsLetter(string value)
        {
            return value.All(char.IsLetter);
        }
    }
}
