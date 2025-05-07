namespace HMS_C__An_Gr.forms
{
    partial class frmDoctorManagement
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxQualifications = new System.Windows.Forms.GroupBox();
            this.btnAddQualification = new System.Windows.Forms.Button();
            this.dataGridViewQualifications = new System.Windows.Forms.DataGridView();
            this.groupBoxAvailability = new System.Windows.Forms.GroupBox();
            this.btnAddAvailability = new System.Windows.Forms.Button();
            this.dataGridViewAvailability = new System.Windows.Forms.DataGridView();
            this.groupBoxLoginDetails = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.groupBoxDoctorDetails = new System.Windows.Forms.GroupBox();
            this.txtConsultationFee = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.labelConsultationFee = new System.Windows.Forms.Label();
            this.labelLicenseNumber = new System.Windows.Forms.Label();
            this.labelSpecialization = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.groupBoxQualifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQualifications)).BeginInit();
            this.groupBoxAvailability.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailability)).BeginInit();
            this.groupBoxLoginDetails.SuspendLayout();
            this.groupBoxDoctorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(143)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(982, 76);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Management";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.btnUpdate);
            this.pnlMain.Controls.Add(this.dataGridViewDoctors);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.groupBoxQualifications);
            this.pnlMain.Controls.Add(this.groupBoxAvailability);
            this.pnlMain.Controls.Add(this.groupBoxLoginDetails);
            this.pnlMain.Controls.Add(this.groupBoxDoctorDetails);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 76);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(11, 14, 11, 14);
            this.pnlMain.Size = new System.Drawing.Size(982, 577);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(9, 427);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Doctor";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(164, 427);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Doctor";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.AllowUserToAddRows = false;
            this.dataGridViewDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(14, 484);
            this.dataGridViewDoctors.MultiSelect = false;
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.ReadOnly = true;
            this.dataGridViewDoctors.RowHeadersWidth = 51;
            this.dataGridViewDoctors.RowTemplate.Height = 24;
            this.dataGridViewDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(952, 81);
            this.dataGridViewDoctors.TabIndex = 5;
            this.dataGridViewDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctors_CellContentClick);
            this.dataGridViewDoctors.SelectionChanged += new System.EventHandler(this.dataGridViewDoctors_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(320, 427);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Doctor";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // groupBoxQualifications
            // 
            this.groupBoxQualifications.Controls.Add(this.btnAddQualification);
            this.groupBoxQualifications.Controls.Add(this.dataGridViewQualifications);
            this.groupBoxQualifications.Location = new System.Drawing.Point(471, 220);
            this.groupBoxQualifications.Name = "groupBoxQualifications";
            this.groupBoxQualifications.Size = new System.Drawing.Size(500, 200);
            this.groupBoxQualifications.TabIndex = 3;
            this.groupBoxQualifications.TabStop = false;
            this.groupBoxQualifications.Text = "Qualifications";
            // 
            // btnAddQualification
            // 
            this.btnAddQualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddQualification.Location = new System.Drawing.Point(3, 161);
            this.btnAddQualification.Name = "btnAddQualification";
            this.btnAddQualification.Size = new System.Drawing.Size(494, 36);
            this.btnAddQualification.TabIndex = 1;
            this.btnAddQualification.Text = "+ Add Qualification";
            this.btnAddQualification.UseVisualStyleBackColor = true;
            this.btnAddQualification.Click += new System.EventHandler(this.btnAddQualification_Click_1);
            // 
            // dataGridViewQualifications
            // 
            this.dataGridViewQualifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQualifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewQualifications.Location = new System.Drawing.Point(3, 21);
            this.dataGridViewQualifications.Name = "dataGridViewQualifications";
            this.dataGridViewQualifications.RowHeadersWidth = 51;
            this.dataGridViewQualifications.RowTemplate.Height = 24;
            this.dataGridViewQualifications.Size = new System.Drawing.Size(494, 140);
            this.dataGridViewQualifications.TabIndex = 0;
            // 
            // groupBoxAvailability
            // 
            this.groupBoxAvailability.Controls.Add(this.btnAddAvailability);
            this.groupBoxAvailability.Controls.Add(this.dataGridViewAvailability);
            this.groupBoxAvailability.Location = new System.Drawing.Point(471, 10);
            this.groupBoxAvailability.Name = "groupBoxAvailability";
            this.groupBoxAvailability.Size = new System.Drawing.Size(500, 200);
            this.groupBoxAvailability.TabIndex = 2;
            this.groupBoxAvailability.TabStop = false;
            this.groupBoxAvailability.Text = "Availability Slots";
            // 
            // btnAddAvailability
            // 
            this.btnAddAvailability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddAvailability.Location = new System.Drawing.Point(3, 161);
            this.btnAddAvailability.Name = "btnAddAvailability";
            this.btnAddAvailability.Size = new System.Drawing.Size(494, 36);
            this.btnAddAvailability.TabIndex = 1;
            this.btnAddAvailability.Text = "+ Add Availability\n\n";
            this.btnAddAvailability.UseVisualStyleBackColor = true;
            this.btnAddAvailability.Click += new System.EventHandler(this.btnAddAvailability_Click_1);
            // 
            // dataGridViewAvailability
            // 
            this.dataGridViewAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailability.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewAvailability.Location = new System.Drawing.Point(3, 21);
            this.dataGridViewAvailability.Name = "dataGridViewAvailability";
            this.dataGridViewAvailability.RowHeadersWidth = 51;
            this.dataGridViewAvailability.RowTemplate.Height = 24;
            this.dataGridViewAvailability.Size = new System.Drawing.Size(494, 140);
            this.dataGridViewAvailability.TabIndex = 0;
            // 
            // groupBoxLoginDetails
            // 
            this.groupBoxLoginDetails.Controls.Add(this.txtUsername);
            this.groupBoxLoginDetails.Controls.Add(this.txtPassword);
            this.groupBoxLoginDetails.Controls.Add(this.labelPassword);
            this.groupBoxLoginDetails.Controls.Add(this.labelUsername);
            this.groupBoxLoginDetails.Location = new System.Drawing.Point(11, 300);
            this.groupBoxLoginDetails.Name = "groupBoxLoginDetails";
            this.groupBoxLoginDetails.Size = new System.Drawing.Size(450, 100);
            this.groupBoxLoginDetails.TabIndex = 1;
            this.groupBoxLoginDetails.TabStop = false;
            this.groupBoxLoginDetails.Text = "Login Details";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(120, 28);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 25);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 63);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 25);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(10, 65);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 19);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(10, 30);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(74, 19);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // groupBoxDoctorDetails
            // 
            this.groupBoxDoctorDetails.Controls.Add(this.txtConsultationFee);
            this.groupBoxDoctorDetails.Controls.Add(this.txtContact);
            this.groupBoxDoctorDetails.Controls.Add(this.txtLicenseNumber);
            this.groupBoxDoctorDetails.Controls.Add(this.txtSpecialization);
            this.groupBoxDoctorDetails.Controls.Add(this.txtEmail);
            this.groupBoxDoctorDetails.Controls.Add(this.txtLastName);
            this.groupBoxDoctorDetails.Controls.Add(this.txtFirstName);
            this.groupBoxDoctorDetails.Controls.Add(this.labelConsultationFee);
            this.groupBoxDoctorDetails.Controls.Add(this.labelLicenseNumber);
            this.groupBoxDoctorDetails.Controls.Add(this.labelSpecialization);
            this.groupBoxDoctorDetails.Controls.Add(this.labelEmail);
            this.groupBoxDoctorDetails.Controls.Add(this.labelContact);
            this.groupBoxDoctorDetails.Controls.Add(this.labelLastName);
            this.groupBoxDoctorDetails.Controls.Add(this.labelFirstName);
            this.groupBoxDoctorDetails.Location = new System.Drawing.Point(11, 10);
            this.groupBoxDoctorDetails.Name = "groupBoxDoctorDetails";
            this.groupBoxDoctorDetails.Size = new System.Drawing.Size(450, 283);
            this.groupBoxDoctorDetails.TabIndex = 0;
            this.groupBoxDoctorDetails.TabStop = false;
            this.groupBoxDoctorDetails.Text = "Doctor Details\n\n";
            // 
            // txtConsultationFee
            // 
            this.txtConsultationFee.Location = new System.Drawing.Point(181, 238);
            this.txtConsultationFee.Name = "txtConsultationFee";
            this.txtConsultationFee.Size = new System.Drawing.Size(150, 25);
            this.txtConsultationFee.TabIndex = 14;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(181, 98);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(150, 25);
            this.txtContact.TabIndex = 12;
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(181, 203);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(150, 25);
            this.txtLicenseNumber.TabIndex = 11;
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.Location = new System.Drawing.Point(181, 168);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.Size = new System.Drawing.Size(150, 25);
            this.txtSpecialization.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(181, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 25);
            this.txtEmail.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(181, 63);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 25);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(181, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 25);
            this.txtFirstName.TabIndex = 7;
            // 
            // labelConsultationFee
            // 
            this.labelConsultationFee.AutoSize = true;
            this.labelConsultationFee.Location = new System.Drawing.Point(10, 240);
            this.labelConsultationFee.Name = "labelConsultationFee";
            this.labelConsultationFee.Size = new System.Drawing.Size(115, 19);
            this.labelConsultationFee.TabIndex = 6;
            this.labelConsultationFee.Text = "Consultation Fee:";
            // 
            // labelLicenseNumber
            // 
            this.labelLicenseNumber.AutoSize = true;
            this.labelLicenseNumber.Location = new System.Drawing.Point(10, 205);
            this.labelLicenseNumber.Name = "labelLicenseNumber";
            this.labelLicenseNumber.Size = new System.Drawing.Size(110, 19);
            this.labelLicenseNumber.TabIndex = 5;
            this.labelLicenseNumber.Text = "License Number:";
            // 
            // labelSpecialization
            // 
            this.labelSpecialization.AutoSize = true;
            this.labelSpecialization.Location = new System.Drawing.Point(10, 170);
            this.labelSpecialization.Name = "labelSpecialization";
            this.labelSpecialization.Size = new System.Drawing.Size(93, 19);
            this.labelSpecialization.TabIndex = 4;
            this.labelSpecialization.Text = "Specialization:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(10, 135);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 19);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email:";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(10, 100);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(60, 19);
            this.labelContact.TabIndex = 2;
            this.labelContact.Text = "Contact:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(10, 65);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(77, 19);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(10, 30);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(78, 19);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // frmDoctorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDoctorManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System - Doctor Managemen";
            this.Load += new System.EventHandler(this.frmDoctorManagement_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.groupBoxQualifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQualifications)).EndInit();
            this.groupBoxAvailability.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailability)).EndInit();
            this.groupBoxLoginDetails.ResumeLayout(false);
            this.groupBoxLoginDetails.PerformLayout();
            this.groupBoxDoctorDetails.ResumeLayout(false);
            this.groupBoxDoctorDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox groupBoxDoctorDetails;
        private System.Windows.Forms.Label labelConsultationFee;
        private System.Windows.Forms.Label labelLicenseNumber;
        private System.Windows.Forms.Label labelSpecialization;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox txtConsultationFee;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBoxLoginDetails;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.GroupBox groupBoxAvailability;
        private System.Windows.Forms.DataGridView dataGridViewAvailability;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBoxQualifications;
        private System.Windows.Forms.Button btnAddQualification;
        private System.Windows.Forms.DataGridView dataGridViewQualifications;
        private System.Windows.Forms.Button btnAddAvailability;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
    }
}