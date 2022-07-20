namespace Final
{
    partial class frm_newPerson
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
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.txtbx_firstName = new System.Windows.Forms.TextBox();
            this.txtbx_lastName = new System.Windows.Forms.TextBox();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.rd_male = new System.Windows.Forms.RadioButton();
            this.txtbx_nationalID = new System.Windows.Forms.TextBox();
            this.lbl_nationalID = new System.Windows.Forms.Label();
            this.txtbx_phoneNumber = new System.Windows.Forms.TextBox();
            this.lbl_phoneNumber = new System.Windows.Forms.Label();
            this.ageDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbl_age = new System.Windows.Forms.Label();
            this.rd_female = new System.Windows.Forms.RadioButton();
            this.lbl_homeAddress = new System.Windows.Forms.Label();
            this.addressPanel = new System.Windows.Forms.Panel();
            this.txtbx_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txtbx_postalCode = new System.Windows.Forms.TextBox();
            this.lbl_postalCode = new System.Windows.Forms.Label();
            this.cbx_city = new System.Windows.Forms.ComboBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.cbx_province = new System.Windows.Forms.ComboBox();
            this.lbl_province = new System.Windows.Forms.Label();
            this.chbx_married = new System.Windows.Forms.CheckBox();
            this.chbx_employed = new System.Windows.Forms.CheckBox();
            this.notePanel = new System.Windows.Forms.Panel();
            this.lbl_note = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.addressPanel.SuspendLayout();
            this.notePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstName.ForeColor = System.Drawing.Color.White;
            this.lbl_firstName.Location = new System.Drawing.Point(20, 20);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(96, 21);
            this.lbl_firstName.TabIndex = 0;
            this.lbl_firstName.Text = "First Name:";
            // 
            // txtbx_firstName
            // 
            this.txtbx_firstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.txtbx_firstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_firstName.Location = new System.Drawing.Point(137, 20);
            this.txtbx_firstName.Name = "txtbx_firstName";
            this.txtbx_firstName.Size = new System.Drawing.Size(100, 25);
            this.txtbx_firstName.TabIndex = 1;
            this.txtbx_firstName.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // txtbx_lastName
            // 
            this.txtbx_lastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.txtbx_lastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_lastName.Location = new System.Drawing.Point(137, 55);
            this.txtbx_lastName.Name = "txtbx_lastName";
            this.txtbx_lastName.Size = new System.Drawing.Size(100, 25);
            this.txtbx_lastName.TabIndex = 2;
            this.txtbx_lastName.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastName.ForeColor = System.Drawing.Color.White;
            this.lbl_lastName.Location = new System.Drawing.Point(20, 55);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(94, 21);
            this.lbl_lastName.TabIndex = 4;
            this.lbl_lastName.Text = "Last Name:";
            // 
            // rd_male
            // 
            this.rd_male.AutoSize = true;
            this.rd_male.Checked = true;
            this.rd_male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_male.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.rd_male.ForeColor = System.Drawing.Color.White;
            this.rd_male.Location = new System.Drawing.Point(250, 200);
            this.rd_male.Name = "rd_male";
            this.rd_male.Size = new System.Drawing.Size(55, 21);
            this.rd_male.TabIndex = 6;
            this.rd_male.TabStop = true;
            this.rd_male.Text = "Male";
            this.rd_male.UseVisualStyleBackColor = true;
            // 
            // txtbx_nationalID
            // 
            this.txtbx_nationalID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.txtbx_nationalID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_nationalID.Location = new System.Drawing.Point(140, 110);
            this.txtbx_nationalID.Name = "txtbx_nationalID";
            this.txtbx_nationalID.Size = new System.Drawing.Size(100, 25);
            this.txtbx_nationalID.TabIndex = 3;
            this.txtbx_nationalID.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // lbl_nationalID
            // 
            this.lbl_nationalID.AutoSize = true;
            this.lbl_nationalID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nationalID.ForeColor = System.Drawing.Color.White;
            this.lbl_nationalID.Location = new System.Drawing.Point(20, 110);
            this.lbl_nationalID.Name = "lbl_nationalID";
            this.lbl_nationalID.Size = new System.Drawing.Size(102, 21);
            this.lbl_nationalID.TabIndex = 9;
            this.lbl_nationalID.Text = "National ID:";
            // 
            // txtbx_phoneNumber
            // 
            this.txtbx_phoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.txtbx_phoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_phoneNumber.Location = new System.Drawing.Point(140, 142);
            this.txtbx_phoneNumber.Name = "txtbx_phoneNumber";
            this.txtbx_phoneNumber.Size = new System.Drawing.Size(118, 25);
            this.txtbx_phoneNumber.TabIndex = 4;
            this.txtbx_phoneNumber.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.AutoSize = true;
            this.lbl_phoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phoneNumber.ForeColor = System.Drawing.Color.White;
            this.lbl_phoneNumber.Location = new System.Drawing.Point(20, 145);
            this.lbl_phoneNumber.Name = "lbl_phoneNumber";
            this.lbl_phoneNumber.Size = new System.Drawing.Size(106, 17);
            this.lbl_phoneNumber.TabIndex = 15;
            this.lbl_phoneNumber.Text = "Phone Number:";
            // 
            // ageDateTimePicker
            // 
            this.ageDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ageDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ageDateTimePicker.Location = new System.Drawing.Point(70, 200);
            this.ageDateTimePicker.Name = "ageDateTimePicker";
            this.ageDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.ageDateTimePicker.TabIndex = 5;
            this.ageDateTimePicker.ValueChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.ForeColor = System.Drawing.Color.White;
            this.lbl_age.Location = new System.Drawing.Point(20, 200);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(44, 21);
            this.lbl_age.TabIndex = 18;
            this.lbl_age.Text = "Age:";
            // 
            // rd_female
            // 
            this.rd_female.AutoSize = true;
            this.rd_female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_female.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.rd_female.ForeColor = System.Drawing.Color.White;
            this.rd_female.Location = new System.Drawing.Point(311, 200);
            this.rd_female.Name = "rd_female";
            this.rd_female.Size = new System.Drawing.Size(69, 21);
            this.rd_female.TabIndex = 19;
            this.rd_female.Text = "Female";
            this.rd_female.UseVisualStyleBackColor = true;
            // 
            // lbl_homeAddress
            // 
            this.lbl_homeAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lbl_homeAddress.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_homeAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_homeAddress.ForeColor = System.Drawing.Color.White;
            this.lbl_homeAddress.Location = new System.Drawing.Point(12, 309);
            this.lbl_homeAddress.Name = "lbl_homeAddress";
            this.lbl_homeAddress.Size = new System.Drawing.Size(100, 23);
            this.lbl_homeAddress.TabIndex = 24;
            this.lbl_homeAddress.Text = "Home Address";
            this.lbl_homeAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressPanel
            // 
            this.addressPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.addressPanel.Controls.Add(this.txtbx_address);
            this.addressPanel.Controls.Add(this.lbl_address);
            this.addressPanel.Controls.Add(this.txtbx_postalCode);
            this.addressPanel.Controls.Add(this.lbl_postalCode);
            this.addressPanel.Controls.Add(this.cbx_city);
            this.addressPanel.Controls.Add(this.lbl_city);
            this.addressPanel.Controls.Add(this.cbx_province);
            this.addressPanel.Controls.Add(this.lbl_province);
            this.addressPanel.Location = new System.Drawing.Point(12, 332);
            this.addressPanel.Name = "addressPanel";
            this.addressPanel.Size = new System.Drawing.Size(469, 100);
            this.addressPanel.TabIndex = 27;
            // 
            // txtbx_address
            // 
            this.txtbx_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.txtbx_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_address.Location = new System.Drawing.Point(79, 70);
            this.txtbx_address.Name = "txtbx_address";
            this.txtbx_address.Size = new System.Drawing.Size(379, 13);
            this.txtbx_address.TabIndex = 35;
            this.txtbx_address.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.White;
            this.lbl_address.Location = new System.Drawing.Point(12, 70);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(61, 17);
            this.lbl_address.TabIndex = 34;
            this.lbl_address.Text = "Address:";
            // 
            // txtbx_postalCode
            // 
            this.txtbx_postalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.txtbx_postalCode.Location = new System.Drawing.Point(380, 29);
            this.txtbx_postalCode.Name = "txtbx_postalCode";
            this.txtbx_postalCode.Size = new System.Drawing.Size(78, 20);
            this.txtbx_postalCode.TabIndex = 33;
            this.txtbx_postalCode.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // lbl_postalCode
            // 
            this.lbl_postalCode.AutoSize = true;
            this.lbl_postalCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_postalCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_postalCode.ForeColor = System.Drawing.Color.White;
            this.lbl_postalCode.Location = new System.Drawing.Point(377, 9);
            this.lbl_postalCode.Name = "lbl_postalCode";
            this.lbl_postalCode.Size = new System.Drawing.Size(81, 17);
            this.lbl_postalCode.TabIndex = 32;
            this.lbl_postalCode.Text = "Postal Code";
            // 
            // cbx_city
            // 
            this.cbx_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_city.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.cbx_city.FormattingEnabled = true;
            this.cbx_city.Location = new System.Drawing.Point(139, 29);
            this.cbx_city.Name = "cbx_city";
            this.cbx_city.Size = new System.Drawing.Size(121, 21);
            this.cbx_city.Sorted = true;
            this.cbx_city.TabIndex = 31;
            this.cbx_city.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_city.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.ForeColor = System.Drawing.Color.White;
            this.lbl_city.Location = new System.Drawing.Point(139, 9);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(32, 17);
            this.lbl_city.TabIndex = 30;
            this.lbl_city.Text = "City";
            // 
            // cbx_province
            // 
            this.cbx_province.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_province.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_province.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.cbx_province.FormattingEnabled = true;
            this.cbx_province.Items.AddRange(new object[] {
            "Alborz",
            "Ardabil",
            "Bushehr",
            "Chaharmahal and Bakhtiari",
            "East Azerbaijan",
            "Fars",
            "Gilan",
            "Golestan",
            "Hamadan",
            "Hormozgan",
            "Ilam",
            "Isfahan",
            "Kerman",
            "Kermanshah",
            "Khuzestan",
            "Kohgiluyeh and Boyer-Ahmad",
            "Kurdistan",
            "Lorestan",
            "Markazi",
            "Mazandaran",
            "North Khorasan",
            "Qazvin",
            "Qom",
            "Razavi Khorasan",
            "Semnan",
            "Sistan and Baluchestan",
            "South Khorasan",
            "Tehran",
            "West Azerbaijan",
            "Yazd",
            "Zanjan"});
            this.cbx_province.Location = new System.Drawing.Point(12, 29);
            this.cbx_province.Name = "cbx_province";
            this.cbx_province.Size = new System.Drawing.Size(121, 21);
            this.cbx_province.Sorted = true;
            this.cbx_province.TabIndex = 29;
            this.cbx_province.SelectedIndexChanged += new System.EventHandler(this.cbx_province_SelectedIndexChanged);
            this.cbx_province.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // lbl_province
            // 
            this.lbl_province.AutoSize = true;
            this.lbl_province.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_province.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_province.ForeColor = System.Drawing.Color.White;
            this.lbl_province.Location = new System.Drawing.Point(12, 9);
            this.lbl_province.Name = "lbl_province";
            this.lbl_province.Size = new System.Drawing.Size(61, 17);
            this.lbl_province.TabIndex = 28;
            this.lbl_province.Text = "Province";
            // 
            // chbx_married
            // 
            this.chbx_married.AutoSize = true;
            this.chbx_married.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbx_married.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbx_married.ForeColor = System.Drawing.Color.White;
            this.chbx_married.Location = new System.Drawing.Point(24, 240);
            this.chbx_married.Name = "chbx_married";
            this.chbx_married.Size = new System.Drawing.Size(74, 21);
            this.chbx_married.TabIndex = 7;
            this.chbx_married.Text = "Married";
            this.chbx_married.UseVisualStyleBackColor = true;
            // 
            // chbx_employed
            // 
            this.chbx_employed.AutoSize = true;
            this.chbx_employed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbx_employed.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbx_employed.ForeColor = System.Drawing.Color.White;
            this.chbx_employed.Location = new System.Drawing.Point(24, 270);
            this.chbx_employed.Name = "chbx_employed";
            this.chbx_employed.Size = new System.Drawing.Size(87, 21);
            this.chbx_employed.TabIndex = 8;
            this.chbx_employed.Text = "Employed";
            this.chbx_employed.UseVisualStyleBackColor = true;
            // 
            // notePanel
            // 
            this.notePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.notePanel.Controls.Add(this.lbl_note);
            this.notePanel.Location = new System.Drawing.Point(311, 20);
            this.notePanel.Name = "notePanel";
            this.notePanel.Size = new System.Drawing.Size(170, 60);
            this.notePanel.TabIndex = 33;
            // 
            // lbl_note
            // 
            this.lbl_note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_note.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_note.ForeColor = System.Drawing.Color.White;
            this.lbl_note.Location = new System.Drawing.Point(0, 0);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(170, 60);
            this.lbl_note.TabIndex = 5;
            this.lbl_note.Text = "Enter Your Information";
            this.lbl_note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_submit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_submit.Location = new System.Drawing.Point(406, 296);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_submit.Size = new System.Drawing.Size(75, 30);
            this.btn_submit.TabIndex = 34;
            this.btn_submit.Text = "Submit";
            this.btn_submit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // frm_newPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(493, 444);
            this.ControlBox = false;
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.notePanel);
            this.Controls.Add(this.chbx_employed);
            this.Controls.Add(this.chbx_married);
            this.Controls.Add(this.addressPanel);
            this.Controls.Add(this.lbl_homeAddress);
            this.Controls.Add(this.rd_female);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.ageDateTimePicker);
            this.Controls.Add(this.txtbx_phoneNumber);
            this.Controls.Add(this.lbl_phoneNumber);
            this.Controls.Add(this.txtbx_nationalID);
            this.Controls.Add(this.lbl_nationalID);
            this.Controls.Add(this.rd_male);
            this.Controls.Add(this.txtbx_lastName);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.txtbx_firstName);
            this.Controls.Add(this.lbl_firstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_newPerson";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frm_newPerson";
            this.TopMost = true;
            this.addressPanel.ResumeLayout(false);
            this.addressPanel.PerformLayout();
            this.notePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.TextBox txtbx_firstName;
        private System.Windows.Forms.TextBox txtbx_lastName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.RadioButton rd_male;
        private System.Windows.Forms.TextBox txtbx_nationalID;
        private System.Windows.Forms.Label lbl_nationalID;
        private System.Windows.Forms.TextBox txtbx_phoneNumber;
        private System.Windows.Forms.Label lbl_phoneNumber;
        private System.Windows.Forms.DateTimePicker ageDateTimePicker;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.RadioButton rd_female;
        private System.Windows.Forms.Label lbl_homeAddress;
        private System.Windows.Forms.Panel addressPanel;
        private System.Windows.Forms.CheckBox chbx_married;
        private System.Windows.Forms.CheckBox chbx_employed;
        private System.Windows.Forms.Panel notePanel;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_province;
        private System.Windows.Forms.ComboBox cbx_province;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.ComboBox cbx_city;
        private System.Windows.Forms.Label lbl_postalCode;
        private System.Windows.Forms.TextBox txtbx_postalCode;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txtbx_address;
    }
}