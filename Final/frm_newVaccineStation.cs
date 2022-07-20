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
    public partial class frm_newVaccineStation : System.Windows.Forms.Form
    {
        public static string StartupPath = (System.IO.Directory.GetCurrentDirectory() + "\\Data\\");
        private static string VaccineStationsPath = StartupPath + "VaccineStations.txt";
        private static string StoragePath = StartupPath + "Storages\\";

        public VaccineStationManager vaccineStationManager = new VaccineStationManager(VaccineStationsPath, new SaveLoadVaccineStation());

        bool SubmitFlag = false;

        public frm_newVaccineStation()
        {
            InitializeComponent();
        }

        private void txtbx_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_stationName.Text != "" && txtbx_numberOfNurses.Text != "" &&
                txtbx_MSS.Text != "" && txtbx_MSE.Text != "" &&
                txtbx_ESS.Text != "" && txtbx_ESE.Text != "" &&
                cbx_province.Text != "" && cbx_city.Text != "" &&
                IsNumeric(txtbx_MSS.Text) && IsNumeric(txtbx_MSE.Text) &&
                IsNumeric(txtbx_ESS.Text) && IsNumeric(txtbx_ESE.Text) &&
                IsNumeric(txtbx_postalCode.Text) && IsNumeric(txtbx_numberOfNurses.Text) &&
                Convert.ToInt16(txtbx_MSS.Text) < Convert.ToInt16(txtbx_MSE.Text) &&
                Convert.ToInt16(txtbx_MSE.Text) <= Convert.ToInt16(txtbx_ESS.Text) &&
                Convert.ToInt16(txtbx_ESS.Text) <= Convert.ToInt16(txtbx_ESE.Text) &&
                Convert.ToInt16(txtbx_ESE.Text) < 25 &&
                txtbx_postalCode.Text.Length == 10)
            {
                SubmitFlag = true;
                btn_submit.BackColor = Color.FromArgb(255, 190, 250, 145);
            }

            else
            {
                SubmitFlag = false;
                btn_submit.BackColor = Color.FromArgb(255, 50, 50, 50);
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            VaccineStation existVaccineStation = vaccineStationManager.SearchVaccineStation(cbx_province.Text, cbx_city.Text, txtbx_stationName.Text);
            if (SubmitFlag && existVaccineStation == null)
            {
                VaccineStation vaccineStation = new VaccineStation
                    (cbx_province.Text,
                    cbx_city.Text,
                    txtbx_stationName.Text,
                    Convert.ToInt32(txtbx_numberOfNurses.Text),
                    Convert.ToInt32(txtbx_MSS.Text),
                    Convert.ToInt32(txtbx_MSE.Text),
                    Convert.ToInt32(txtbx_ESS.Text),
                    Convert.ToInt32(txtbx_ESE.Text),
                    txtbx_postalCode.Text);

                vaccineStationManager.AddVaccineStation(vaccineStation);

                List<string> doses = new List<string>();
                if (chbx_astraZeneca.Checked)
                {
                    doses.Add("AstraZeneca");
                }
                if (chbx_janssen.Checked)
                {
                    doses.Add("Janssen");
                }
                if (chbx_moderna.Checked)
                {
                    doses.Add("Moderna");
                }
                if (chbx_pfizer.Checked)
                {
                    doses.Add("Pfizer");
                }

                Storage storage = new Storage(vaccineStation, doses);

                StorageManager storageManager = new StorageManager(StoragePath + txtbx_postalCode.Text + ".txt", new SaveLoadStorage());
                storageManager.AddStorage(storage);

                lbl_note.Text = "The Vaccine Station has been Submitted";
                lbl_note.ForeColor = Color.FromArgb(255, 190, 250, 145);
            }
            else if (SubmitFlag && existVaccineStation != null)
            {
                lbl_note.Text = "This Vaccine Station is already submitted";
                lbl_note.ForeColor = Color.FromArgb(255, 128, 170, 255);
            }
            else
            {
                lbl_note.Text = "Please recheck your Information";
                lbl_note.ForeColor = Color.Red;
            }
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
