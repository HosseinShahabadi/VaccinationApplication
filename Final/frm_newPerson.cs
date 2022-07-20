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
    public partial class frm_newPerson : System.Windows.Forms.Form
    {
        public static string StartupPath = (System.IO.Directory.GetCurrentDirectory() + "\\Data\\");
        private static string PersonsPath = StartupPath + "Persons.txt";
        public PersonManager personManager = new PersonManager(PersonsPath, new SaveLoadPerson());

        bool SubmitFlag = false;

        public frm_newPerson()
        {
            InitializeComponent();
        }
        
        private void txtbx_TextChanged(object sender, EventArgs e)
        {
            if (IsLetter(txtbx_firstName.Text) && IsLetter(txtbx_lastName.Text) &&
                IsNumeric(txtbx_postalCode.Text) && txtbx_postalCode.Text.Length == 10 &&
                IsNumeric(txtbx_phoneNumber.Text) && txtbx_phoneNumber.Text.Length == 11 &&
                IsNumeric(txtbx_nationalID.Text) && txtbx_nationalID.Text.Length == 10)
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

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        public bool IsLetter(string value)
        {
            return value.All(char.IsLetter);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Person person = personManager.SearchPerson(txtbx_nationalID.Text);
            if (SubmitFlag && person == null)
            {
                person = new Person
                    (txtbx_firstName.Text,
                    txtbx_lastName.Text,
                    txtbx_nationalID.Text,
                    txtbx_phoneNumber.Text,
                    rd_male.Checked,
                    chbx_married.Checked,
                    chbx_employed.Checked,
                    ageDateTimePicker.Value.Year,
                    ageDateTimePicker.Value.Month,
                    ageDateTimePicker.Value.Day,
                    cbx_province.Text,
                    cbx_city.Text,
                    txtbx_address.Text,
                    txtbx_postalCode.Text);

                personManager.AddPerson(person);

                lbl_note.Text = "Congratulation";
                lbl_note.ForeColor = Color.FromArgb(255, 190, 250, 145);
            }

            else if (SubmitFlag && person != null)
            {
                lbl_note.Text = "This National ID is already Registered!";
                lbl_note.ForeColor = Color.Red;
            }

            else
            {
                lbl_note.Text = "Please Recheck your Infromation!";
                lbl_note.ForeColor = Color.Red;
            }
        }

        private void cbx_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_city.Items.Clear();
            cbx_city.Items.AddRange(File.ReadAllLines(StartupPath + "\\Cities\\" + cbx_province.Text + ".txt"));
        }
    }
}
