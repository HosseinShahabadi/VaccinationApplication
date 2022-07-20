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
    public partial class frm_vaccineCard : System.Windows.Forms.Form
    {
        public static string StartupPath = (System.IO.Directory.GetCurrentDirectory() + "\\Data\\");
        private static string PersonsPath = StartupPath + "Persons.txt";

        public PersonManager personManager = new PersonManager(PersonsPath, new SaveLoadPerson());

        bool SearchFlag = false;
        bool PrintFlag = false;

        public frm_vaccineCard()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (SearchFlag)
            {
                string NationalID = txtbx_nationalID.Text;
                Person person = personManager.SearchPerson(NationalID);
                if (person != null)
                {
                    lbl_result.Text = "Found it!";
                    lbl_result.ForeColor = Color.FromArgb(255, 190, 250, 145);

                    lbl_firstNameRes.Text = person.GetFirstName();
                    lbl_lastNameRes.Text = person.GetLastName();
                    lbl_nationalIDRes.Text = person.National_ID;

                    if (person.GetSex())
                        lbl_sexRes.Text = "Male";
                    else
                        lbl_sexRes.Text = "Female";

                    if (person.isVaccinated != 0)
                    {
                        lbl_numberOfDosesRes.Text = (person.isVaccinated).ToString();
                        lbl_dosesRes.Text = person.Vaccines.ToString();
                    }
                    else
                    {
                        lbl_numberOfDosesRes.Text = "0";
                        lbl_dosesRes.Text = "Not Vaccinated yet";
                    }

                    //Will Generate QR Code and Show that Here
                    //So We can Validate Them by Scanning
                    pbx_QRCode.Visible = true;

                    PrintFlag = true;
                    btn_print.BackColor = Color.FromArgb(255, 190, 250, 145);
                }

                else
                {
                    lbl_result.Text = "Not Found!";
                    lbl_result.ForeColor = Color.Red;

                    lbl_firstNameRes.Text = "First Name";
                    lbl_lastNameRes.Text = "Last Name";
                    lbl_nationalIDRes.Text = "National ID";
                    lbl_sexRes.Text = "Sex";

                    lbl_numberOfDosesRes.Text = "Number";
                    lbl_dosesRes.Text = "Doses";

                    pbx_QRCode.Visible = false;

                    PrintFlag = false;
                    btn_print.BackColor = Color.FromArgb(255, 50, 50, 50);
                }
            }
            else
            {
                lbl_result.Text = "Double check your \nNational ID";
                lbl_result.ForeColor = Color.Red;
            }
        }

        private void txtbx_nationalID_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_nationalID.Text.Length == 10 && IsNumeric(txtbx_nationalID.Text))
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

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (PrintFlag)
            {
                //Print Ticket
            }
            else
            {
                lbl_result.Text = "You must enter your \nNational ID first";
                lbl_result.ForeColor = Color.Red;
            }
        }
        
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
    }
}
