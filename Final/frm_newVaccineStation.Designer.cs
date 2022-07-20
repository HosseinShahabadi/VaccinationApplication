namespace Final
{
    partial class frm_newVaccineStation
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.notePanel = new System.Windows.Forms.Panel();
            this.lbl_note = new System.Windows.Forms.Label();
            this.addressPanel = new System.Windows.Forms.Panel();
            this.txtbx_postalCode = new System.Windows.Forms.TextBox();
            this.lbl_postalCode = new System.Windows.Forms.Label();
            this.cbx_city = new System.Windows.Forms.ComboBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.cbx_province = new System.Windows.Forms.ComboBox();
            this.lbl_province = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.txtbx_stationName = new System.Windows.Forms.TextBox();
            this.lbl_stationName = new System.Windows.Forms.Label();
            this.txtbx_numberOfNurses = new System.Windows.Forms.TextBox();
            this.lbl_numberOfNurses = new System.Windows.Forms.Label();
            this.txtbx_ESS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_ESE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_MSE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_MSS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbx_astraZeneca = new System.Windows.Forms.CheckBox();
            this.lbl_availableDoses = new System.Windows.Forms.Label();
            this.chbx_pfizer = new System.Windows.Forms.CheckBox();
            this.chbx_janssen = new System.Windows.Forms.CheckBox();
            this.chbx_moderna = new System.Windows.Forms.CheckBox();
            this.notePanel.SuspendLayout();
            this.addressPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_submit.Location = new System.Drawing.Point(381, 328);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_submit.Size = new System.Drawing.Size(100, 71);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // notePanel
            // 
            this.notePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.notePanel.Controls.Add(this.lbl_note);
            this.notePanel.Location = new System.Drawing.Point(311, 16);
            this.notePanel.Name = "notePanel";
            this.notePanel.Size = new System.Drawing.Size(170, 60);
            this.notePanel.TabIndex = 51;
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
            this.lbl_note.Text = "Enter Station Information";
            this.lbl_note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressPanel
            // 
            this.addressPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.addressPanel.Controls.Add(this.txtbx_postalCode);
            this.addressPanel.Controls.Add(this.lbl_postalCode);
            this.addressPanel.Controls.Add(this.cbx_city);
            this.addressPanel.Controls.Add(this.lbl_city);
            this.addressPanel.Controls.Add(this.cbx_province);
            this.addressPanel.Controls.Add(this.lbl_province);
            this.addressPanel.Location = new System.Drawing.Point(12, 328);
            this.addressPanel.Name = "addressPanel";
            this.addressPanel.Size = new System.Drawing.Size(297, 71);
            this.addressPanel.TabIndex = 6;
            // 
            // txtbx_postalCode
            // 
            this.txtbx_postalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.txtbx_postalCode.Location = new System.Drawing.Point(206, 30);
            this.txtbx_postalCode.Name = "txtbx_postalCode";
            this.txtbx_postalCode.Size = new System.Drawing.Size(78, 20);
            this.txtbx_postalCode.TabIndex = 2;
            this.txtbx_postalCode.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // lbl_postalCode
            // 
            this.lbl_postalCode.AutoSize = true;
            this.lbl_postalCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_postalCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_postalCode.ForeColor = System.Drawing.Color.White;
            this.lbl_postalCode.Location = new System.Drawing.Point(203, 10);
            this.lbl_postalCode.Name = "lbl_postalCode";
            this.lbl_postalCode.Size = new System.Drawing.Size(81, 17);
            this.lbl_postalCode.TabIndex = 34;
            this.lbl_postalCode.Text = "Postal Code";
            // 
            // cbx_city
            // 
            this.cbx_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_city.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.cbx_city.FormattingEnabled = true;
            this.cbx_city.Location = new System.Drawing.Point(106, 29);
            this.cbx_city.Name = "cbx_city";
            this.cbx_city.Size = new System.Drawing.Size(94, 21);
            this.cbx_city.Sorted = true;
            this.cbx_city.TabIndex = 1;
            this.cbx_city.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_city.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.ForeColor = System.Drawing.Color.White;
            this.lbl_city.Location = new System.Drawing.Point(106, 9);
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
            this.cbx_province.Size = new System.Drawing.Size(88, 21);
            this.cbx_province.Sorted = true;
            this.cbx_province.TabIndex = 0;
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
            // lbl_location
            // 
            this.lbl_location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lbl_location.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_location.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_location.ForeColor = System.Drawing.Color.White;
            this.lbl_location.Location = new System.Drawing.Point(12, 305);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(100, 23);
            this.lbl_location.TabIndex = 49;
            this.lbl_location.Text = "Location";
            this.lbl_location.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbx_stationName
            // 
            this.txtbx_stationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.txtbx_stationName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_stationName.Location = new System.Drawing.Point(145, 36);
            this.txtbx_stationName.Name = "txtbx_stationName";
            this.txtbx_stationName.Size = new System.Drawing.Size(100, 25);
            this.txtbx_stationName.TabIndex = 0;
            this.txtbx_stationName.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // lbl_stationName
            // 
            this.lbl_stationName.AutoSize = true;
            this.lbl_stationName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stationName.ForeColor = System.Drawing.Color.White;
            this.lbl_stationName.Location = new System.Drawing.Point(20, 36);
            this.lbl_stationName.Name = "lbl_stationName";
            this.lbl_stationName.Size = new System.Drawing.Size(119, 21);
            this.lbl_stationName.TabIndex = 35;
            this.lbl_stationName.Text = "Station Name:";
            // 
            // txtbx_numberOfNurses
            // 
            this.txtbx_numberOfNurses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.txtbx_numberOfNurses.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_numberOfNurses.Location = new System.Drawing.Point(184, 94);
            this.txtbx_numberOfNurses.Name = "txtbx_numberOfNurses";
            this.txtbx_numberOfNurses.Size = new System.Drawing.Size(45, 25);
            this.txtbx_numberOfNurses.TabIndex = 1;
            this.txtbx_numberOfNurses.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // lbl_numberOfNurses
            // 
            this.lbl_numberOfNurses.AutoSize = true;
            this.lbl_numberOfNurses.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numberOfNurses.ForeColor = System.Drawing.Color.White;
            this.lbl_numberOfNurses.Location = new System.Drawing.Point(23, 94);
            this.lbl_numberOfNurses.Name = "lbl_numberOfNurses";
            this.lbl_numberOfNurses.Size = new System.Drawing.Size(150, 21);
            this.lbl_numberOfNurses.TabIndex = 53;
            this.lbl_numberOfNurses.Text = "Number Of Nurses:";
            // 
            // txtbx_ESS
            // 
            this.txtbx_ESS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.txtbx_ESS.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_ESS.Location = new System.Drawing.Point(164, 228);
            this.txtbx_ESS.Name = "txtbx_ESS";
            this.txtbx_ESS.Size = new System.Drawing.Size(75, 25);
            this.txtbx_ESS.TabIndex = 4;
            this.txtbx_ESS.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Evening Shift Start:";
            // 
            // txtbx_ESE
            // 
            this.txtbx_ESE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.txtbx_ESE.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_ESE.Location = new System.Drawing.Point(164, 259);
            this.txtbx_ESE.Name = "txtbx_ESE";
            this.txtbx_ESE.Size = new System.Drawing.Size(75, 25);
            this.txtbx_ESE.TabIndex = 5;
            this.txtbx_ESE.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Evening Shift End:";
            // 
            // txtbx_MSE
            // 
            this.txtbx_MSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.txtbx_MSE.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_MSE.Location = new System.Drawing.Point(164, 185);
            this.txtbx_MSE.Name = "txtbx_MSE";
            this.txtbx_MSE.Size = new System.Drawing.Size(75, 25);
            this.txtbx_MSE.TabIndex = 3;
            this.txtbx_MSE.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Morning Shift End:";
            // 
            // txtbx_MSS
            // 
            this.txtbx_MSS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.txtbx_MSS.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_MSS.Location = new System.Drawing.Point(164, 154);
            this.txtbx_MSS.Name = "txtbx_MSS";
            this.txtbx_MSS.Size = new System.Drawing.Size(75, 25);
            this.txtbx_MSS.TabIndex = 2;
            this.txtbx_MSS.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Morning Shift Start:";
            // 
            // chbx_astraZeneca
            // 
            this.chbx_astraZeneca.AutoSize = true;
            this.chbx_astraZeneca.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbx_astraZeneca.ForeColor = System.Drawing.Color.White;
            this.chbx_astraZeneca.Location = new System.Drawing.Point(314, 185);
            this.chbx_astraZeneca.Name = "chbx_astraZeneca";
            this.chbx_astraZeneca.Size = new System.Drawing.Size(88, 17);
            this.chbx_astraZeneca.TabIndex = 15;
            this.chbx_astraZeneca.Text = "AstraZeneca";
            this.chbx_astraZeneca.UseVisualStyleBackColor = true;
            // 
            // lbl_availableDoses
            // 
            this.lbl_availableDoses.AutoSize = true;
            this.lbl_availableDoses.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_availableDoses.ForeColor = System.Drawing.Color.White;
            this.lbl_availableDoses.Location = new System.Drawing.Point(308, 154);
            this.lbl_availableDoses.Name = "lbl_availableDoses";
            this.lbl_availableDoses.Size = new System.Drawing.Size(110, 17);
            this.lbl_availableDoses.TabIndex = 64;
            this.lbl_availableDoses.Text = "Available Doses:";
            // 
            // chbx_pfizer
            // 
            this.chbx_pfizer.AutoSize = true;
            this.chbx_pfizer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbx_pfizer.ForeColor = System.Drawing.Color.White;
            this.chbx_pfizer.Location = new System.Drawing.Point(314, 208);
            this.chbx_pfizer.Name = "chbx_pfizer";
            this.chbx_pfizer.Size = new System.Drawing.Size(54, 17);
            this.chbx_pfizer.TabIndex = 7;
            this.chbx_pfizer.Text = "Pfizer";
            this.chbx_pfizer.UseVisualStyleBackColor = true;
            // 
            // chbx_janssen
            // 
            this.chbx_janssen.AutoSize = true;
            this.chbx_janssen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbx_janssen.ForeColor = System.Drawing.Color.White;
            this.chbx_janssen.Location = new System.Drawing.Point(314, 231);
            this.chbx_janssen.Name = "chbx_janssen";
            this.chbx_janssen.Size = new System.Drawing.Size(66, 17);
            this.chbx_janssen.TabIndex = 8;
            this.chbx_janssen.Text = "Janssen";
            this.chbx_janssen.UseVisualStyleBackColor = true;
            // 
            // chbx_moderna
            // 
            this.chbx_moderna.AutoSize = true;
            this.chbx_moderna.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbx_moderna.ForeColor = System.Drawing.Color.White;
            this.chbx_moderna.Location = new System.Drawing.Point(314, 254);
            this.chbx_moderna.Name = "chbx_moderna";
            this.chbx_moderna.Size = new System.Drawing.Size(73, 17);
            this.chbx_moderna.TabIndex = 9;
            this.chbx_moderna.Text = "Moderna";
            this.chbx_moderna.UseVisualStyleBackColor = true;
            // 
            // frm_newVaccineStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(493, 444);
            this.ControlBox = false;
            this.Controls.Add(this.chbx_moderna);
            this.Controls.Add(this.chbx_janssen);
            this.Controls.Add(this.chbx_pfizer);
            this.Controls.Add(this.lbl_availableDoses);
            this.Controls.Add(this.chbx_astraZeneca);
            this.Controls.Add(this.txtbx_MSS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_MSE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_ESE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_ESS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_numberOfNurses);
            this.Controls.Add(this.lbl_numberOfNurses);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.notePanel);
            this.Controls.Add(this.addressPanel);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.txtbx_stationName);
            this.Controls.Add(this.lbl_stationName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_newVaccineStation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frm_newVaccineStation";
            this.notePanel.ResumeLayout(false);
            this.addressPanel.ResumeLayout(false);
            this.addressPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Panel notePanel;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Panel addressPanel;
        private System.Windows.Forms.ComboBox cbx_city;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.ComboBox cbx_province;
        private System.Windows.Forms.Label lbl_province;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.TextBox txtbx_stationName;
        private System.Windows.Forms.Label lbl_stationName;
        private System.Windows.Forms.TextBox txtbx_numberOfNurses;
        private System.Windows.Forms.Label lbl_numberOfNurses;
        private System.Windows.Forms.TextBox txtbx_ESS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_ESE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_MSE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_MSS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbx_astraZeneca;
        private System.Windows.Forms.Label lbl_availableDoses;
        private System.Windows.Forms.CheckBox chbx_pfizer;
        private System.Windows.Forms.CheckBox chbx_janssen;
        private System.Windows.Forms.CheckBox chbx_moderna;
        private System.Windows.Forms.TextBox txtbx_postalCode;
        private System.Windows.Forms.Label lbl_postalCode;
    }
}