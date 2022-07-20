namespace Final
{
    partial class frm_vaccineCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_vaccineCard));
            this.notePanel = new System.Windows.Forms.Panel();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_sexRes = new System.Windows.Forms.Label();
            this.lbl_nationalIDRes = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txtbx_nationalID = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_lastNameRes = new System.Windows.Forms.Label();
            this.lbl_firstNameRes = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.QRCodePanel = new System.Windows.Forms.Panel();
            this.pbx_QRCode = new System.Windows.Forms.PictureBox();
            this.lbl_QRCode = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_nationalID = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_dosesRes = new System.Windows.Forms.Label();
            this.lbl_numberOfDosesRes = new System.Windows.Forms.Label();
            this.lbl_doses = new System.Windows.Forms.Label();
            this.lbl_numberOfDoses = new System.Windows.Forms.Label();
            this.notePanel.SuspendLayout();
            this.QRCodePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_QRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // notePanel
            // 
            this.notePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.notePanel.Controls.Add(this.lbl_result);
            this.notePanel.Location = new System.Drawing.Point(311, 68);
            this.notePanel.Name = "notePanel";
            this.notePanel.Size = new System.Drawing.Size(170, 60);
            this.notePanel.TabIndex = 80;
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
            this.lbl_result.Text = "Enter Your National ID";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sexRes
            // 
            this.lbl_sexRes.AutoSize = true;
            this.lbl_sexRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexRes.ForeColor = System.Drawing.Color.White;
            this.lbl_sexRes.Location = new System.Drawing.Point(140, 173);
            this.lbl_sexRes.Name = "lbl_sexRes";
            this.lbl_sexRes.Size = new System.Drawing.Size(34, 21);
            this.lbl_sexRes.TabIndex = 79;
            this.lbl_sexRes.Text = "Sex";
            // 
            // lbl_nationalIDRes
            // 
            this.lbl_nationalIDRes.AutoSize = true;
            this.lbl_nationalIDRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nationalIDRes.ForeColor = System.Drawing.Color.White;
            this.lbl_nationalIDRes.Location = new System.Drawing.Point(140, 138);
            this.lbl_nationalIDRes.Name = "lbl_nationalIDRes";
            this.lbl_nationalIDRes.Size = new System.Drawing.Size(88, 21);
            this.lbl_nationalIDRes.TabIndex = 78;
            this.lbl_nationalIDRes.Text = "National ID";
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
            this.btn_search.Location = new System.Drawing.Point(252, 12);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_search.Size = new System.Drawing.Size(100, 35);
            this.btn_search.TabIndex = 77;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txtbx_nationalID
            // 
            this.txtbx_nationalID.BackColor = System.Drawing.Color.White;
            this.txtbx_nationalID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_nationalID.Location = new System.Drawing.Point(130, 20);
            this.txtbx_nationalID.Name = "txtbx_nationalID";
            this.txtbx_nationalID.Size = new System.Drawing.Size(100, 25);
            this.txtbx_nationalID.TabIndex = 76;
            this.txtbx_nationalID.TextChanged += new System.EventHandler(this.txtbx_nationalID_TextChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(23, 20);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(102, 21);
            this.lbl_id.TabIndex = 75;
            this.lbl_id.Text = "National ID:";
            // 
            // lbl_lastNameRes
            // 
            this.lbl_lastNameRes.AutoSize = true;
            this.lbl_lastNameRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastNameRes.ForeColor = System.Drawing.Color.White;
            this.lbl_lastNameRes.Location = new System.Drawing.Point(140, 103);
            this.lbl_lastNameRes.Name = "lbl_lastNameRes";
            this.lbl_lastNameRes.Size = new System.Drawing.Size(84, 21);
            this.lbl_lastNameRes.TabIndex = 74;
            this.lbl_lastNameRes.Text = "Last Name";
            // 
            // lbl_firstNameRes
            // 
            this.lbl_firstNameRes.AutoSize = true;
            this.lbl_firstNameRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstNameRes.ForeColor = System.Drawing.Color.White;
            this.lbl_firstNameRes.Location = new System.Drawing.Point(140, 68);
            this.lbl_firstNameRes.Name = "lbl_firstNameRes";
            this.lbl_firstNameRes.Size = new System.Drawing.Size(86, 21);
            this.lbl_firstNameRes.TabIndex = 73;
            this.lbl_firstNameRes.Text = "First Name";
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print.Location = new System.Drawing.Point(361, 361);
            this.btn_print.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_print.Size = new System.Drawing.Size(120, 70);
            this.btn_print.TabIndex = 70;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // QRCodePanel
            // 
            this.QRCodePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.QRCodePanel.Controls.Add(this.pbx_QRCode);
            this.QRCodePanel.Location = new System.Drawing.Point(311, 170);
            this.QRCodePanel.Name = "QRCodePanel";
            this.QRCodePanel.Size = new System.Drawing.Size(150, 150);
            this.QRCodePanel.TabIndex = 69;
            // 
            // pbx_QRCode
            // 
            this.pbx_QRCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_QRCode.Image = ((System.Drawing.Image)(resources.GetObject("pbx_QRCode.Image")));
            this.pbx_QRCode.Location = new System.Drawing.Point(0, 0);
            this.pbx_QRCode.Name = "pbx_QRCode";
            this.pbx_QRCode.Size = new System.Drawing.Size(150, 150);
            this.pbx_QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_QRCode.TabIndex = 0;
            this.pbx_QRCode.TabStop = false;
            this.pbx_QRCode.Visible = false;
            // 
            // lbl_QRCode
            // 
            this.lbl_QRCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lbl_QRCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_QRCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QRCode.ForeColor = System.Drawing.Color.White;
            this.lbl_QRCode.Location = new System.Drawing.Point(311, 147);
            this.lbl_QRCode.Name = "lbl_QRCode";
            this.lbl_QRCode.Size = new System.Drawing.Size(100, 23);
            this.lbl_QRCode.TabIndex = 68;
            this.lbl_QRCode.Text = "QR Code";
            this.lbl_QRCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.ForeColor = System.Drawing.Color.White;
            this.lbl_sex.Location = new System.Drawing.Point(24, 173);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(41, 21);
            this.lbl_sex.TabIndex = 67;
            this.lbl_sex.Text = "Sex:";
            // 
            // lbl_nationalID
            // 
            this.lbl_nationalID.AutoSize = true;
            this.lbl_nationalID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nationalID.ForeColor = System.Drawing.Color.White;
            this.lbl_nationalID.Location = new System.Drawing.Point(24, 138);
            this.lbl_nationalID.Name = "lbl_nationalID";
            this.lbl_nationalID.Size = new System.Drawing.Size(102, 21);
            this.lbl_nationalID.TabIndex = 66;
            this.lbl_nationalID.Text = "National ID:";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastName.ForeColor = System.Drawing.Color.White;
            this.lbl_lastName.Location = new System.Drawing.Point(23, 103);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(94, 21);
            this.lbl_lastName.TabIndex = 65;
            this.lbl_lastName.Text = "Last Name:";
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstName.ForeColor = System.Drawing.Color.White;
            this.lbl_firstName.Location = new System.Drawing.Point(23, 68);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(96, 21);
            this.lbl_firstName.TabIndex = 64;
            this.lbl_firstName.Text = "First Name:";
            // 
            // lbl_dosesRes
            // 
            this.lbl_dosesRes.AutoSize = true;
            this.lbl_dosesRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dosesRes.ForeColor = System.Drawing.Color.White;
            this.lbl_dosesRes.Location = new System.Drawing.Point(182, 308);
            this.lbl_dosesRes.Name = "lbl_dosesRes";
            this.lbl_dosesRes.Size = new System.Drawing.Size(52, 21);
            this.lbl_dosesRes.TabIndex = 84;
            this.lbl_dosesRes.Text = "Doses";
            // 
            // lbl_numberOfDosesRes
            // 
            this.lbl_numberOfDosesRes.AutoSize = true;
            this.lbl_numberOfDosesRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numberOfDosesRes.ForeColor = System.Drawing.Color.White;
            this.lbl_numberOfDosesRes.Location = new System.Drawing.Point(182, 273);
            this.lbl_numberOfDosesRes.Name = "lbl_numberOfDosesRes";
            this.lbl_numberOfDosesRes.Size = new System.Drawing.Size(68, 21);
            this.lbl_numberOfDosesRes.TabIndex = 83;
            this.lbl_numberOfDosesRes.Text = "Number";
            // 
            // lbl_doses
            // 
            this.lbl_doses.AutoSize = true;
            this.lbl_doses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doses.ForeColor = System.Drawing.Color.White;
            this.lbl_doses.Location = new System.Drawing.Point(24, 308);
            this.lbl_doses.Name = "lbl_doses";
            this.lbl_doses.Size = new System.Drawing.Size(59, 21);
            this.lbl_doses.TabIndex = 82;
            this.lbl_doses.Text = "Doses:";
            // 
            // lbl_numberOfDoses
            // 
            this.lbl_numberOfDoses.AutoSize = true;
            this.lbl_numberOfDoses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numberOfDoses.ForeColor = System.Drawing.Color.White;
            this.lbl_numberOfDoses.Location = new System.Drawing.Point(24, 273);
            this.lbl_numberOfDoses.Name = "lbl_numberOfDoses";
            this.lbl_numberOfDoses.Size = new System.Drawing.Size(146, 21);
            this.lbl_numberOfDoses.TabIndex = 81;
            this.lbl_numberOfDoses.Text = "Number of Doses:";
            // 
            // frm_vaccineCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(493, 444);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_dosesRes);
            this.Controls.Add(this.lbl_numberOfDosesRes);
            this.Controls.Add(this.lbl_doses);
            this.Controls.Add(this.lbl_numberOfDoses);
            this.Controls.Add(this.notePanel);
            this.Controls.Add(this.lbl_sexRes);
            this.Controls.Add(this.lbl_nationalIDRes);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtbx_nationalID);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_lastNameRes);
            this.Controls.Add(this.lbl_firstNameRes);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.QRCodePanel);
            this.Controls.Add(this.lbl_QRCode);
            this.Controls.Add(this.lbl_sex);
            this.Controls.Add(this.lbl_nationalID);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.lbl_firstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_vaccineCard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frm_vaccineCard";
            this.TopMost = true;
            this.notePanel.ResumeLayout(false);
            this.QRCodePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_QRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel notePanel;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_sexRes;
        private System.Windows.Forms.Label lbl_nationalIDRes;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txtbx_nationalID;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_lastNameRes;
        private System.Windows.Forms.Label lbl_firstNameRes;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Panel QRCodePanel;
        private System.Windows.Forms.Label lbl_QRCode;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_nationalID;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_dosesRes;
        private System.Windows.Forms.Label lbl_numberOfDosesRes;
        private System.Windows.Forms.Label lbl_doses;
        private System.Windows.Forms.Label lbl_numberOfDoses;
        private System.Windows.Forms.PictureBox pbx_QRCode;
    }
}