namespace Final
{
    partial class frm_modifyAppointment
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
            this.btn_closestStation = new System.Windows.Forms.Button();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_vaccineType = new System.Windows.Forms.Label();
            this.cbx_vaccineType = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_vaccineTime = new System.Windows.Forms.Label();
            this.dtp_vaccineTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_vaccineDate = new System.Windows.Forms.Label();
            this.dtp_vaccineDate = new System.Windows.Forms.DateTimePicker();
            this.cbx_city = new System.Windows.Forms.ComboBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.cbx_province = new System.Windows.Forms.ComboBox();
            this.lbl_province = new System.Windows.Forms.Label();
            this.cbx_vaccineStationName = new System.Windows.Forms.ComboBox();
            this.lbl_vaccineStation = new System.Windows.Forms.Label();
            this.lbl_form = new System.Windows.Forms.Label();
            this.lbl_doseRes = new System.Windows.Forms.Label();
            this.lbl_numberOfDosesRes = new System.Windows.Forms.Label();
            this.lbl_dose = new System.Windows.Forms.Label();
            this.lbl_dosesNumber = new System.Windows.Forms.Label();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.notePanel = new System.Windows.Forms.Panel();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_lastNameRes = new System.Windows.Forms.Label();
            this.txtbx_appointmentNumber = new System.Windows.Forms.TextBox();
            this.lbl_appointmentNumber = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_firstNameRes = new System.Windows.Forms.Label();
            this.FormPanel.SuspendLayout();
            this.notePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_closestStation
            // 
            this.btn_closestStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_closestStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_closestStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_closestStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closestStation.Font = new System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closestStation.ForeColor = System.Drawing.Color.White;
            this.btn_closestStation.Location = new System.Drawing.Point(335, 29);
            this.btn_closestStation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_closestStation.Name = "btn_closestStation";
            this.btn_closestStation.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_closestStation.Size = new System.Drawing.Size(100, 30);
            this.btn_closestStation.TabIndex = 46;
            this.btn_closestStation.Text = "Closest Station";
            this.btn_closestStation.UseVisualStyleBackColor = false;
            this.btn_closestStation.Click += new System.EventHandler(this.btn_closestStation_Click);
            // 
            // FormPanel
            // 
            this.FormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.FormPanel.Controls.Add(this.btn_delete);
            this.FormPanel.Controls.Add(this.btn_closestStation);
            this.FormPanel.Controls.Add(this.lbl_vaccineType);
            this.FormPanel.Controls.Add(this.cbx_vaccineType);
            this.FormPanel.Controls.Add(this.btn_submit);
            this.FormPanel.Controls.Add(this.lbl_vaccineTime);
            this.FormPanel.Controls.Add(this.dtp_vaccineTime);
            this.FormPanel.Controls.Add(this.lbl_vaccineDate);
            this.FormPanel.Controls.Add(this.dtp_vaccineDate);
            this.FormPanel.Controls.Add(this.cbx_city);
            this.FormPanel.Controls.Add(this.lbl_city);
            this.FormPanel.Controls.Add(this.cbx_province);
            this.FormPanel.Controls.Add(this.lbl_province);
            this.FormPanel.Controls.Add(this.cbx_vaccineStationName);
            this.FormPanel.Controls.Add(this.lbl_vaccineStation);
            this.FormPanel.Enabled = false;
            this.FormPanel.Location = new System.Drawing.Point(22, 166);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(450, 189);
            this.FormPanel.TabIndex = 104;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_delete.Location = new System.Drawing.Point(259, 123);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_delete.Size = new System.Drawing.Size(85, 50);
            this.btn_delete.TabIndex = 47;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_vaccineType
            // 
            this.lbl_vaccineType.AutoSize = true;
            this.lbl_vaccineType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vaccineType.ForeColor = System.Drawing.Color.White;
            this.lbl_vaccineType.Location = new System.Drawing.Point(13, 145);
            this.lbl_vaccineType.Name = "lbl_vaccineType";
            this.lbl_vaccineType.Size = new System.Drawing.Size(113, 21);
            this.lbl_vaccineType.TabIndex = 45;
            this.lbl_vaccineType.Text = "Vaccine Type:";
            // 
            // cbx_vaccineType
            // 
            this.cbx_vaccineType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_vaccineType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_vaccineType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.cbx_vaccineType.FormattingEnabled = true;
            this.cbx_vaccineType.Items.AddRange(new object[] {
            "First Vaccine",
            "Second Vaccine",
            "Third Vaccine"});
            this.cbx_vaccineType.Location = new System.Drawing.Point(132, 145);
            this.cbx_vaccineType.Name = "cbx_vaccineType";
            this.cbx_vaccineType.Size = new System.Drawing.Size(96, 21);
            this.cbx_vaccineType.Sorted = true;
            this.cbx_vaccineType.TabIndex = 44;
            this.cbx_vaccineType.TextChanged += new System.EventHandler(this.cbx_vaccineType_TextChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_submit.Location = new System.Drawing.Point(350, 123);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_submit.Size = new System.Drawing.Size(85, 50);
            this.btn_submit.TabIndex = 42;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_vaccineTime
            // 
            this.lbl_vaccineTime.AutoSize = true;
            this.lbl_vaccineTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vaccineTime.ForeColor = System.Drawing.Color.White;
            this.lbl_vaccineTime.Location = new System.Drawing.Point(13, 110);
            this.lbl_vaccineTime.Name = "lbl_vaccineTime";
            this.lbl_vaccineTime.Size = new System.Drawing.Size(115, 21);
            this.lbl_vaccineTime.TabIndex = 41;
            this.lbl_vaccineTime.Text = "Vaccine Time:";
            // 
            // dtp_vaccineTime
            // 
            this.dtp_vaccineTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.dtp_vaccineTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_vaccineTime.Location = new System.Drawing.Point(132, 111);
            this.dtp_vaccineTime.Name = "dtp_vaccineTime";
            this.dtp_vaccineTime.Size = new System.Drawing.Size(96, 20);
            this.dtp_vaccineTime.TabIndex = 40;
            // 
            // lbl_vaccineDate
            // 
            this.lbl_vaccineDate.AutoSize = true;
            this.lbl_vaccineDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vaccineDate.ForeColor = System.Drawing.Color.White;
            this.lbl_vaccineDate.Location = new System.Drawing.Point(13, 75);
            this.lbl_vaccineDate.Name = "lbl_vaccineDate";
            this.lbl_vaccineDate.Size = new System.Drawing.Size(113, 21);
            this.lbl_vaccineDate.TabIndex = 39;
            this.lbl_vaccineDate.Text = "Vaccine Date:";
            // 
            // dtp_vaccineDate
            // 
            this.dtp_vaccineDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.dtp_vaccineDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_vaccineDate.Location = new System.Drawing.Point(132, 76);
            this.dtp_vaccineDate.Name = "dtp_vaccineDate";
            this.dtp_vaccineDate.Size = new System.Drawing.Size(96, 20);
            this.dtp_vaccineDate.TabIndex = 38;
            // 
            // cbx_city
            // 
            this.cbx_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_city.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.cbx_city.FormattingEnabled = true;
            this.cbx_city.Location = new System.Drawing.Point(141, 34);
            this.cbx_city.Name = "cbx_city";
            this.cbx_city.Size = new System.Drawing.Size(87, 21);
            this.cbx_city.Sorted = true;
            this.cbx_city.TabIndex = 37;
            this.cbx_city.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_city.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.ForeColor = System.Drawing.Color.White;
            this.lbl_city.Location = new System.Drawing.Point(141, 14);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(32, 17);
            this.lbl_city.TabIndex = 36;
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
            this.cbx_province.Location = new System.Drawing.Point(14, 34);
            this.cbx_province.Name = "cbx_province";
            this.cbx_province.Size = new System.Drawing.Size(121, 21);
            this.cbx_province.Sorted = true;
            this.cbx_province.TabIndex = 35;
            this.cbx_province.SelectedIndexChanged += new System.EventHandler(this.cbx_province_SelectedIndexChanged);
            this.cbx_province.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // lbl_province
            // 
            this.lbl_province.AutoSize = true;
            this.lbl_province.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_province.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_province.ForeColor = System.Drawing.Color.White;
            this.lbl_province.Location = new System.Drawing.Point(14, 14);
            this.lbl_province.Name = "lbl_province";
            this.lbl_province.Size = new System.Drawing.Size(61, 17);
            this.lbl_province.TabIndex = 34;
            this.lbl_province.Text = "Province";
            // 
            // cbx_vaccineStationName
            // 
            this.cbx_vaccineStationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_vaccineStationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_vaccineStationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.cbx_vaccineStationName.FormattingEnabled = true;
            this.cbx_vaccineStationName.Location = new System.Drawing.Point(234, 34);
            this.cbx_vaccineStationName.Name = "cbx_vaccineStationName";
            this.cbx_vaccineStationName.Size = new System.Drawing.Size(88, 21);
            this.cbx_vaccineStationName.Sorted = true;
            this.cbx_vaccineStationName.TabIndex = 33;
            this.cbx_vaccineStationName.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // lbl_vaccineStation
            // 
            this.lbl_vaccineStation.AutoSize = true;
            this.lbl_vaccineStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_vaccineStation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vaccineStation.ForeColor = System.Drawing.Color.White;
            this.lbl_vaccineStation.Location = new System.Drawing.Point(233, 14);
            this.lbl_vaccineStation.Name = "lbl_vaccineStation";
            this.lbl_vaccineStation.Size = new System.Drawing.Size(52, 17);
            this.lbl_vaccineStation.TabIndex = 32;
            this.lbl_vaccineStation.Text = "Station";
            // 
            // lbl_form
            // 
            this.lbl_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lbl_form.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_form.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form.ForeColor = System.Drawing.Color.White;
            this.lbl_form.Location = new System.Drawing.Point(22, 143);
            this.lbl_form.Name = "lbl_form";
            this.lbl_form.Size = new System.Drawing.Size(100, 23);
            this.lbl_form.TabIndex = 103;
            this.lbl_form.Text = "Form";
            this.lbl_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_doseRes
            // 
            this.lbl_doseRes.AutoSize = true;
            this.lbl_doseRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doseRes.ForeColor = System.Drawing.Color.White;
            this.lbl_doseRes.Location = new System.Drawing.Point(176, 410);
            this.lbl_doseRes.Name = "lbl_doseRes";
            this.lbl_doseRes.Size = new System.Drawing.Size(45, 21);
            this.lbl_doseRes.TabIndex = 102;
            this.lbl_doseRes.Text = "Dose";
            // 
            // lbl_numberOfDosesRes
            // 
            this.lbl_numberOfDosesRes.AutoSize = true;
            this.lbl_numberOfDosesRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numberOfDosesRes.ForeColor = System.Drawing.Color.White;
            this.lbl_numberOfDosesRes.Location = new System.Drawing.Point(176, 375);
            this.lbl_numberOfDosesRes.Name = "lbl_numberOfDosesRes";
            this.lbl_numberOfDosesRes.Size = new System.Drawing.Size(68, 21);
            this.lbl_numberOfDosesRes.TabIndex = 101;
            this.lbl_numberOfDosesRes.Text = "Number";
            // 
            // lbl_dose
            // 
            this.lbl_dose.AutoSize = true;
            this.lbl_dose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dose.ForeColor = System.Drawing.Color.White;
            this.lbl_dose.Location = new System.Drawing.Point(18, 410);
            this.lbl_dose.Name = "lbl_dose";
            this.lbl_dose.Size = new System.Drawing.Size(52, 21);
            this.lbl_dose.TabIndex = 100;
            this.lbl_dose.Text = "Dose:";
            // 
            // lbl_dosesNumber
            // 
            this.lbl_dosesNumber.AutoSize = true;
            this.lbl_dosesNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dosesNumber.ForeColor = System.Drawing.Color.White;
            this.lbl_dosesNumber.Location = new System.Drawing.Point(18, 375);
            this.lbl_dosesNumber.Name = "lbl_dosesNumber";
            this.lbl_dosesNumber.Size = new System.Drawing.Size(120, 21);
            this.lbl_dosesNumber.TabIndex = 99;
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
            this.lbl_firstName.TabIndex = 95;
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
            this.lbl_lastName.TabIndex = 96;
            this.lbl_lastName.Text = "Last Name:";
            // 
            // notePanel
            // 
            this.notePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.notePanel.Controls.Add(this.lbl_result);
            this.notePanel.Location = new System.Drawing.Point(305, 70);
            this.notePanel.Name = "notePanel";
            this.notePanel.Size = new System.Drawing.Size(170, 60);
            this.notePanel.TabIndex = 91;
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
            // lbl_lastNameRes
            // 
            this.lbl_lastNameRes.AutoSize = true;
            this.lbl_lastNameRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastNameRes.ForeColor = System.Drawing.Color.White;
            this.lbl_lastNameRes.Location = new System.Drawing.Point(134, 105);
            this.lbl_lastNameRes.Name = "lbl_lastNameRes";
            this.lbl_lastNameRes.Size = new System.Drawing.Size(84, 21);
            this.lbl_lastNameRes.TabIndex = 98;
            this.lbl_lastNameRes.Text = "Last Name";
            // 
            // txtbx_appointmentNumber
            // 
            this.txtbx_appointmentNumber.BackColor = System.Drawing.Color.White;
            this.txtbx_appointmentNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_appointmentNumber.Location = new System.Drawing.Point(184, 22);
            this.txtbx_appointmentNumber.Name = "txtbx_appointmentNumber";
            this.txtbx_appointmentNumber.Size = new System.Drawing.Size(100, 25);
            this.txtbx_appointmentNumber.TabIndex = 94;
            this.txtbx_appointmentNumber.TextChanged += new System.EventHandler(this.txtbx_appointmentNumber_TextChanged);
            // 
            // lbl_appointmentNumber
            // 
            this.lbl_appointmentNumber.AutoSize = true;
            this.lbl_appointmentNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_appointmentNumber.ForeColor = System.Drawing.Color.White;
            this.lbl_appointmentNumber.Location = new System.Drawing.Point(17, 22);
            this.lbl_appointmentNumber.Name = "lbl_appointmentNumber";
            this.lbl_appointmentNumber.Size = new System.Drawing.Size(184, 21);
            this.lbl_appointmentNumber.TabIndex = 93;
            this.lbl_appointmentNumber.Text = "Appointment Number:";
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
            this.btn_search.TabIndex = 92;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_firstNameRes
            // 
            this.lbl_firstNameRes.AutoSize = true;
            this.lbl_firstNameRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstNameRes.ForeColor = System.Drawing.Color.White;
            this.lbl_firstNameRes.Location = new System.Drawing.Point(134, 70);
            this.lbl_firstNameRes.Name = "lbl_firstNameRes";
            this.lbl_firstNameRes.Size = new System.Drawing.Size(86, 21);
            this.lbl_firstNameRes.TabIndex = 97;
            this.lbl_firstNameRes.Text = "First Name";
            // 
            // frm_modifyAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(493, 444);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.lbl_form);
            this.Controls.Add(this.lbl_doseRes);
            this.Controls.Add(this.lbl_numberOfDosesRes);
            this.Controls.Add(this.lbl_dose);
            this.Controls.Add(this.lbl_dosesNumber);
            this.Controls.Add(this.lbl_firstName);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.notePanel);
            this.Controls.Add(this.lbl_lastNameRes);
            this.Controls.Add(this.txtbx_appointmentNumber);
            this.Controls.Add(this.lbl_appointmentNumber);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_firstNameRes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_modifyAppointment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frm_modifyAppointment";
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.notePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_closestStation;
        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Label lbl_vaccineType;
        private System.Windows.Forms.ComboBox cbx_vaccineType;
        private System.Windows.Forms.Label lbl_vaccineTime;
        private System.Windows.Forms.DateTimePicker dtp_vaccineTime;
        private System.Windows.Forms.Label lbl_vaccineDate;
        private System.Windows.Forms.DateTimePicker dtp_vaccineDate;
        private System.Windows.Forms.ComboBox cbx_city;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.ComboBox cbx_province;
        private System.Windows.Forms.Label lbl_province;
        private System.Windows.Forms.ComboBox cbx_vaccineStationName;
        private System.Windows.Forms.Label lbl_vaccineStation;
        private System.Windows.Forms.Label lbl_form;
        private System.Windows.Forms.Label lbl_doseRes;
        private System.Windows.Forms.Label lbl_numberOfDosesRes;
        private System.Windows.Forms.Label lbl_dose;
        private System.Windows.Forms.Label lbl_dosesNumber;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Panel notePanel;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_lastNameRes;
        private System.Windows.Forms.TextBox txtbx_appointmentNumber;
        private System.Windows.Forms.Label lbl_appointmentNumber;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_firstNameRes;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_delete;
    }
}