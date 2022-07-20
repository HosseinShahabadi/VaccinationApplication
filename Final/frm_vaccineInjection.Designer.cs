namespace Final
{
    partial class frm_vaccineInjection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_appointmentNumber = new System.Windows.Forms.Label();
            this.lbl_firstNameRes = new System.Windows.Forms.Label();
            this.lbl_lastNameRes = new System.Windows.Forms.Label();
            this.txtbx_appointmentNumber = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_doseRes = new System.Windows.Forms.Label();
            this.lbl_numberOfDosesRes = new System.Windows.Forms.Label();
            this.lbl_dose = new System.Windows.Forms.Label();
            this.lbl_dosesNumber = new System.Windows.Forms.Label();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.notePanel = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_vaccineDate = new System.Windows.Forms.Label();
            this.lbl_vaccineDateRes = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.notePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_appointmentNumber
            // 
            this.lbl_appointmentNumber.AutoSize = true;
            this.lbl_appointmentNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_appointmentNumber.ForeColor = System.Drawing.Color.White;
            this.lbl_appointmentNumber.Location = new System.Drawing.Point(17, 22);
            this.lbl_appointmentNumber.Name = "lbl_appointmentNumber";
            this.lbl_appointmentNumber.Size = new System.Drawing.Size(184, 21);
            this.lbl_appointmentNumber.TabIndex = 107;
            this.lbl_appointmentNumber.Text = "Appointment Number:";
            // 
            // lbl_firstNameRes
            // 
            this.lbl_firstNameRes.AutoSize = true;
            this.lbl_firstNameRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstNameRes.ForeColor = System.Drawing.Color.White;
            this.lbl_firstNameRes.Location = new System.Drawing.Point(140, 70);
            this.lbl_firstNameRes.Name = "lbl_firstNameRes";
            this.lbl_firstNameRes.Size = new System.Drawing.Size(86, 21);
            this.lbl_firstNameRes.TabIndex = 111;
            this.lbl_firstNameRes.Text = "First Name";
            // 
            // lbl_lastNameRes
            // 
            this.lbl_lastNameRes.AutoSize = true;
            this.lbl_lastNameRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastNameRes.ForeColor = System.Drawing.Color.White;
            this.lbl_lastNameRes.Location = new System.Drawing.Point(140, 105);
            this.lbl_lastNameRes.Name = "lbl_lastNameRes";
            this.lbl_lastNameRes.Size = new System.Drawing.Size(84, 21);
            this.lbl_lastNameRes.TabIndex = 112;
            this.lbl_lastNameRes.Text = "Last Name";
            // 
            // txtbx_appointmentNumber
            // 
            this.txtbx_appointmentNumber.BackColor = System.Drawing.Color.White;
            this.txtbx_appointmentNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_appointmentNumber.Location = new System.Drawing.Point(184, 22);
            this.txtbx_appointmentNumber.Name = "txtbx_appointmentNumber";
            this.txtbx_appointmentNumber.Size = new System.Drawing.Size(100, 25);
            this.txtbx_appointmentNumber.TabIndex = 108;
            this.txtbx_appointmentNumber.TextChanged += new System.EventHandler(this.txtbx_appointmentNumber_TextChanged);
            // 
            // lbl_result
            // 
            this.lbl_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_result.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.ForeColor = System.Drawing.Color.White;
            this.lbl_result.Location = new System.Drawing.Point(0, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(170, 60);
            this.lbl_result.TabIndex = 5;
            this.lbl_result.Text = "Enter Your Appointment Number";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_doseRes
            // 
            this.lbl_doseRes.AutoSize = true;
            this.lbl_doseRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doseRes.ForeColor = System.Drawing.Color.White;
            this.lbl_doseRes.Location = new System.Drawing.Point(140, 245);
            this.lbl_doseRes.Name = "lbl_doseRes";
            this.lbl_doseRes.Size = new System.Drawing.Size(45, 21);
            this.lbl_doseRes.TabIndex = 116;
            this.lbl_doseRes.Text = "Dose";
            // 
            // lbl_numberOfDosesRes
            // 
            this.lbl_numberOfDosesRes.AutoSize = true;
            this.lbl_numberOfDosesRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numberOfDosesRes.ForeColor = System.Drawing.Color.White;
            this.lbl_numberOfDosesRes.Location = new System.Drawing.Point(140, 210);
            this.lbl_numberOfDosesRes.Name = "lbl_numberOfDosesRes";
            this.lbl_numberOfDosesRes.Size = new System.Drawing.Size(68, 21);
            this.lbl_numberOfDosesRes.TabIndex = 115;
            this.lbl_numberOfDosesRes.Text = "Number";
            // 
            // lbl_dose
            // 
            this.lbl_dose.AutoSize = true;
            this.lbl_dose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dose.ForeColor = System.Drawing.Color.White;
            this.lbl_dose.Location = new System.Drawing.Point(18, 245);
            this.lbl_dose.Name = "lbl_dose";
            this.lbl_dose.Size = new System.Drawing.Size(52, 21);
            this.lbl_dose.TabIndex = 114;
            this.lbl_dose.Text = "Dose:";
            // 
            // lbl_dosesNumber
            // 
            this.lbl_dosesNumber.AutoSize = true;
            this.lbl_dosesNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dosesNumber.ForeColor = System.Drawing.Color.White;
            this.lbl_dosesNumber.Location = new System.Drawing.Point(18, 210);
            this.lbl_dosesNumber.Name = "lbl_dosesNumber";
            this.lbl_dosesNumber.Size = new System.Drawing.Size(120, 21);
            this.lbl_dosesNumber.TabIndex = 113;
            this.lbl_dosesNumber.Text = "Dose Number:";
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstName.ForeColor = System.Drawing.Color.White;
            this.lbl_firstName.Location = new System.Drawing.Point(18, 70);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(96, 21);
            this.lbl_firstName.TabIndex = 109;
            this.lbl_firstName.Text = "First Name:";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastName.ForeColor = System.Drawing.Color.White;
            this.lbl_lastName.Location = new System.Drawing.Point(18, 105);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(94, 21);
            this.lbl_lastName.TabIndex = 110;
            this.lbl_lastName.Text = "Last Name:";
            // 
            // notePanel
            // 
            this.notePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.notePanel.Controls.Add(this.lbl_result);
            this.notePanel.Location = new System.Drawing.Point(305, 70);
            this.notePanel.Name = "notePanel";
            this.notePanel.Size = new System.Drawing.Size(170, 60);
            this.notePanel.TabIndex = 105;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.Location = new System.Drawing.Point(306, 14);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_search.Size = new System.Drawing.Size(100, 35);
            this.btn_search.TabIndex = 106;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_vaccineDate
            // 
            this.lbl_vaccineDate.AutoSize = true;
            this.lbl_vaccineDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vaccineDate.ForeColor = System.Drawing.Color.White;
            this.lbl_vaccineDate.Location = new System.Drawing.Point(18, 140);
            this.lbl_vaccineDate.Name = "lbl_vaccineDate";
            this.lbl_vaccineDate.Size = new System.Drawing.Size(113, 21);
            this.lbl_vaccineDate.TabIndex = 120;
            this.lbl_vaccineDate.Text = "Vaccine Date:";
            // 
            // lbl_vaccineDateRes
            // 
            this.lbl_vaccineDateRes.AutoSize = true;
            this.lbl_vaccineDateRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vaccineDateRes.ForeColor = System.Drawing.Color.White;
            this.lbl_vaccineDateRes.Location = new System.Drawing.Point(140, 140);
            this.lbl_vaccineDateRes.Name = "lbl_vaccineDateRes";
            this.lbl_vaccineDateRes.Size = new System.Drawing.Size(98, 21);
            this.lbl_vaccineDateRes.TabIndex = 123;
            this.lbl_vaccineDateRes.Text = "Vaccine Date";
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_confirm.Location = new System.Drawing.Point(12, 376);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_confirm.Size = new System.Drawing.Size(469, 55);
            this.btn_confirm.TabIndex = 125;
            this.btn_confirm.Text = "Confirm Injection";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // frm_vaccineInjection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(493, 444);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lbl_vaccineDateRes);
            this.Controls.Add(this.lbl_vaccineDate);
            this.Controls.Add(this.lbl_appointmentNumber);
            this.Controls.Add(this.lbl_firstNameRes);
            this.Controls.Add(this.lbl_lastNameRes);
            this.Controls.Add(this.txtbx_appointmentNumber);
            this.Controls.Add(this.lbl_doseRes);
            this.Controls.Add(this.lbl_numberOfDosesRes);
            this.Controls.Add(this.lbl_dose);
            this.Controls.Add(this.lbl_dosesNumber);
            this.Controls.Add(this.lbl_firstName);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.notePanel);
            this.Controls.Add(this.btn_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_vaccineInjection";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frm_vaccineInjection";
            this.notePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_appointmentNumber;
        private System.Windows.Forms.Label lbl_firstNameRes;
        private System.Windows.Forms.Label lbl_lastNameRes;
        private System.Windows.Forms.TextBox txtbx_appointmentNumber;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_doseRes;
        private System.Windows.Forms.Label lbl_numberOfDosesRes;
        private System.Windows.Forms.Label lbl_dose;
        private System.Windows.Forms.Label lbl_dosesNumber;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Panel notePanel;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_vaccineDate;
        private System.Windows.Forms.Label lbl_vaccineDateRes;
        private System.Windows.Forms.Button btn_confirm;
    }
}