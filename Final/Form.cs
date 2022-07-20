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
    public partial class Form : System.Windows.Forms.Form
    {
        bool isDark = true;

        public Form()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }


        private void btn_newPerson_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            frm_newPerson Form = new frm_newPerson() { TopLevel = false, TopMost = true };
            this.panel.Controls.Add(Form);
            Form.Show();
        }

        private void btn_vaccineInjection_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            frm_vaccineInjection Form = new frm_vaccineInjection() { TopLevel = false, TopMost = true };
            this.panel.Controls.Add(Form);
            Form.Show();
        }

        private void btn_newAppointment_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            frm_newAppointment Form = new frm_newAppointment() { TopLevel = false, TopMost = true };
            this.panel.Controls.Add(Form);
            Form.Show();
        }

        private void btn_modifyAppointment_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            frm_modifyAppointment Form = new frm_modifyAppointment() { TopLevel = false, TopMost = true };
            this.panel.Controls.Add(Form);
            Form.Show();
        }
        
        private void btn_vaccineCard_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            frm_vaccineCard Form = new frm_vaccineCard() { TopLevel = false, TopMost = true };
            this.panel.Controls.Add(Form);
            Form.Show();
        }

        private void btn_newVaccineStation_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            frm_newVaccineStation Form = new frm_newVaccineStation() { TopLevel = false, TopMost = true };
            this.panel.Controls.Add(Form);
            Form.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
