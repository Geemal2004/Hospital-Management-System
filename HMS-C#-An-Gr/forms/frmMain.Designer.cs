namespace HospitalManagementSystem.UI
{
    partial class frmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDashboardOverview = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelOpenRooms = new System.Windows.Forms.Panel();
            this.lblOpenRoomsValue = new System.Windows.Forms.Label();
            this.lblOpenRoomsText = new System.Windows.Forms.Label();
            this.panelAppointmentsToday = new System.Windows.Forms.Panel();
            this.lblAppointmentsTodayValue = new System.Windows.Forms.Label();
            this.lblAppointmentsTodayText = new System.Windows.Forms.Label();
            this.panelTotalDoctors = new System.Windows.Forms.Panel();
            this.lblTotalDoctorsValue = new System.Windows.Forms.Label();
            this.lblTotalDoctorsText = new System.Windows.Forms.Label();
            this.panelTotalPatients = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPatientsValue = new System.Windows.Forms.Label();
            this.lblSystemModules = new System.Windows.Forms.Label();
            this.btnPatientManagement = new System.Windows.Forms.Button();
            this.btnAppointmentManagement = new System.Windows.Forms.Button();
            this.btnBillingSystem = new System.Windows.Forms.Button();
            this.btnDoctorManagement = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelOpenRooms.SuspendLayout();
            this.panelAppointmentsToday.SuspendLayout();
            this.panelTotalDoctors.SuspendLayout();
            this.panelTotalPatients.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(294, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, [Username] ([Role])";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.Logout.Location = new System.Drawing.Point(700, 25);
            this.Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(77, 32);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panelHeader.Controls.Add(this.Logout);
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 60);
            this.panelHeader.TabIndex = 2;
            // 
            // lblDashboardOverview
            // 
            this.lblDashboardOverview.AutoSize = true;
            this.lblDashboardOverview.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblDashboardOverview.Location = new System.Drawing.Point(11, 9);
            this.lblDashboardOverview.Name = "lblDashboardOverview";
            this.lblDashboardOverview.Size = new System.Drawing.Size(302, 29);
            this.lblDashboardOverview.TabIndex = 5;
            this.lblDashboardOverview.Text = "DASHBOARD OVERVIEW";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelOpenRooms);
            this.panel1.Controls.Add(this.panelAppointmentsToday);
            this.panel1.Controls.Add(this.panelTotalDoctors);
            this.panel1.Controls.Add(this.panelTotalPatients);
            this.panel1.Controls.Add(this.lblDashboardOverview);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 121);
            this.panel1.TabIndex = 4;
            // 
            // panelOpenRooms
            // 
            this.panelOpenRooms.BackColor = System.Drawing.Color.Red;
            this.panelOpenRooms.Controls.Add(this.lblOpenRoomsValue);
            this.panelOpenRooms.Controls.Add(this.lblOpenRoomsText);
            this.panelOpenRooms.Location = new System.Drawing.Point(592, 46);
            this.panelOpenRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOpenRooms.Name = "panelOpenRooms";
            this.panelOpenRooms.Size = new System.Drawing.Size(171, 71);
            this.panelOpenRooms.TabIndex = 6;
            // 
            // lblOpenRoomsValue
            // 
            this.lblOpenRoomsValue.AutoSize = true;
            this.lblOpenRoomsValue.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblOpenRoomsValue.ForeColor = System.Drawing.Color.White;
            this.lblOpenRoomsValue.Location = new System.Drawing.Point(3, 37);
            this.lblOpenRoomsValue.Name = "lblOpenRoomsValue";
            this.lblOpenRoomsValue.Size = new System.Drawing.Size(44, 32);
            this.lblOpenRoomsValue.TabIndex = 6;
            this.lblOpenRoomsValue.Text = "12";
            // 
            // lblOpenRoomsText
            // 
            this.lblOpenRoomsText.AutoSize = true;
            this.lblOpenRoomsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOpenRoomsText.ForeColor = System.Drawing.Color.White;
            this.lblOpenRoomsText.Location = new System.Drawing.Point(3, 9);
            this.lblOpenRoomsText.Name = "lblOpenRoomsText";
            this.lblOpenRoomsText.Size = new System.Drawing.Size(107, 20);
            this.lblOpenRoomsText.TabIndex = 7;
            this.lblOpenRoomsText.Text = "Open Rooms";
            // 
            // panelAppointmentsToday
            // 
            this.panelAppointmentsToday.BackColor = System.Drawing.Color.Orange;
            this.panelAppointmentsToday.Controls.Add(this.lblAppointmentsTodayValue);
            this.panelAppointmentsToday.Controls.Add(this.lblAppointmentsTodayText);
            this.panelAppointmentsToday.Location = new System.Drawing.Point(396, 46);
            this.panelAppointmentsToday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAppointmentsToday.Name = "panelAppointmentsToday";
            this.panelAppointmentsToday.Size = new System.Drawing.Size(171, 71);
            this.panelAppointmentsToday.TabIndex = 6;
            // 
            // lblAppointmentsTodayValue
            // 
            this.lblAppointmentsTodayValue.AutoSize = true;
            this.lblAppointmentsTodayValue.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblAppointmentsTodayValue.ForeColor = System.Drawing.Color.White;
            this.lblAppointmentsTodayValue.Location = new System.Drawing.Point(3, 37);
            this.lblAppointmentsTodayValue.Name = "lblAppointmentsTodayValue";
            this.lblAppointmentsTodayValue.Size = new System.Drawing.Size(132, 32);
            this.lblAppointmentsTodayValue.TabIndex = 8;
            this.lblAppointmentsTodayValue.Text = "35 Today";
            // 
            // lblAppointmentsTodayText
            // 
            this.lblAppointmentsTodayText.AutoSize = true;
            this.lblAppointmentsTodayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAppointmentsTodayText.ForeColor = System.Drawing.Color.White;
            this.lblAppointmentsTodayText.Location = new System.Drawing.Point(3, 9);
            this.lblAppointmentsTodayText.Name = "lblAppointmentsTodayText";
            this.lblAppointmentsTodayText.Size = new System.Drawing.Size(161, 20);
            this.lblAppointmentsTodayText.TabIndex = 9;
            this.lblAppointmentsTodayText.Text = "Appointments Today";
            // 
            // panelTotalDoctors
            // 
            this.panelTotalDoctors.BackColor = System.Drawing.Color.Cyan;
            this.panelTotalDoctors.Controls.Add(this.lblTotalDoctorsValue);
            this.panelTotalDoctors.Controls.Add(this.lblTotalDoctorsText);
            this.panelTotalDoctors.Location = new System.Drawing.Point(204, 46);
            this.panelTotalDoctors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTotalDoctors.Name = "panelTotalDoctors";
            this.panelTotalDoctors.Size = new System.Drawing.Size(171, 71);
            this.panelTotalDoctors.TabIndex = 6;
            // 
            // lblTotalDoctorsValue
            // 
            this.lblTotalDoctorsValue.AutoSize = true;
            this.lblTotalDoctorsValue.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalDoctorsValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalDoctorsValue.Location = new System.Drawing.Point(3, 37);
            this.lblTotalDoctorsValue.Name = "lblTotalDoctorsValue";
            this.lblTotalDoctorsValue.Size = new System.Drawing.Size(44, 32);
            this.lblTotalDoctorsValue.TabIndex = 10;
            this.lblTotalDoctorsValue.Text = "24";
            // 
            // lblTotalDoctorsText
            // 
            this.lblTotalDoctorsText.AutoSize = true;
            this.lblTotalDoctorsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalDoctorsText.ForeColor = System.Drawing.Color.White;
            this.lblTotalDoctorsText.Location = new System.Drawing.Point(3, 9);
            this.lblTotalDoctorsText.Name = "lblTotalDoctorsText";
            this.lblTotalDoctorsText.Size = new System.Drawing.Size(111, 20);
            this.lblTotalDoctorsText.TabIndex = 11;
            this.lblTotalDoctorsText.Text = "Total Doctors";
            // 
            // panelTotalPatients
            // 
            this.panelTotalPatients.BackColor = System.Drawing.Color.Green;
            this.panelTotalPatients.Controls.Add(this.label1);
            this.panelTotalPatients.Controls.Add(this.lblTotalPatientsValue);
            this.panelTotalPatients.Location = new System.Drawing.Point(15, 46);
            this.panelTotalPatients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTotalPatients.Name = "panelTotalPatients";
            this.panelTotalPatients.Size = new System.Drawing.Size(171, 71);
            this.panelTotalPatients.TabIndex = 5;
            this.panelTotalPatients.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTotalPatients_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Patients";
            // 
            // lblTotalPatientsValue
            // 
            this.lblTotalPatientsValue.AutoSize = true;
            this.lblTotalPatientsValue.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalPatientsValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalPatientsValue.Location = new System.Drawing.Point(4, 37);
            this.lblTotalPatientsValue.Name = "lblTotalPatientsValue";
            this.lblTotalPatientsValue.Size = new System.Drawing.Size(59, 32);
            this.lblTotalPatientsValue.TabIndex = 5;
            this.lblTotalPatientsValue.Text = "156";
            // 
            // lblSystemModules
            // 
            this.lblSystemModules.AutoSize = true;
            this.lblSystemModules.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblSystemModules.Location = new System.Drawing.Point(27, 215);
            this.lblSystemModules.Name = "lblSystemModules";
            this.lblSystemModules.Size = new System.Drawing.Size(239, 29);
            this.lblSystemModules.TabIndex = 5;
            this.lblSystemModules.Text = "SYSTEM MODULES";
            // 
            // btnPatientManagement
            // 
            this.btnPatientManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientManagement.Location = new System.Drawing.Point(3, 2);
            this.btnPatientManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPatientManagement.Name = "btnPatientManagement";
            this.btnPatientManagement.Size = new System.Drawing.Size(381, 75);
            this.btnPatientManagement.TabIndex = 6;
            this.btnPatientManagement.Text = "Patient Management";
            this.btnPatientManagement.UseVisualStyleBackColor = true;
            this.btnPatientManagement.Click += new System.EventHandler(this.btnPatientManagement_Click);
            // 
            // btnAppointmentManagement
            // 
            this.btnAppointmentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentManagement.Location = new System.Drawing.Point(3, 83);
            this.btnAppointmentManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAppointmentManagement.Name = "btnAppointmentManagement";
            this.btnAppointmentManagement.Size = new System.Drawing.Size(381, 75);
            this.btnAppointmentManagement.TabIndex = 7;
            this.btnAppointmentManagement.Text = "Appointment Management";
            this.btnAppointmentManagement.UseVisualStyleBackColor = true;
            this.btnAppointmentManagement.Click += new System.EventHandler(this.btnAppointmentManagement_Click);
            // 
            // btnBillingSystem
            // 
            this.btnBillingSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillingSystem.Location = new System.Drawing.Point(391, 83);
            this.btnBillingSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBillingSystem.Name = "btnBillingSystem";
            this.btnBillingSystem.Size = new System.Drawing.Size(381, 75);
            this.btnBillingSystem.TabIndex = 8;
            this.btnBillingSystem.Text = "Billing System";
            this.btnBillingSystem.UseVisualStyleBackColor = true;
            this.btnBillingSystem.Click += new System.EventHandler(this.btnBillingSystem_Click);
            // 
            // btnDoctorManagement
            // 
            this.btnDoctorManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorManagement.Location = new System.Drawing.Point(391, 2);
            this.btnDoctorManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoctorManagement.Name = "btnDoctorManagement";
            this.btnDoctorManagement.Size = new System.Drawing.Size(381, 75);
            this.btnDoctorManagement.TabIndex = 9;
            this.btnDoctorManagement.Text = "Doctor Management";
            this.btnDoctorManagement.UseVisualStyleBackColor = true;
            this.btnDoctorManagement.Click += new System.EventHandler(this.btnDoctorManagement_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnDoctorManagement, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAppointmentManagement, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBillingSystem, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPatientManagement, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 265);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 162);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblSystemModules);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System - Dashboard";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelOpenRooms.ResumeLayout(false);
            this.panelOpenRooms.PerformLayout();
            this.panelAppointmentsToday.ResumeLayout(false);
            this.panelAppointmentsToday.PerformLayout();
            this.panelTotalDoctors.ResumeLayout(false);
            this.panelTotalDoctors.PerformLayout();
            this.panelTotalPatients.ResumeLayout(false);
            this.panelTotalPatients.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblDashboardOverview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTotalPatients;
        private System.Windows.Forms.Panel panelOpenRooms;
        private System.Windows.Forms.Panel panelAppointmentsToday;
        private System.Windows.Forms.Panel panelTotalDoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPatientsValue;
        private System.Windows.Forms.Label lblOpenRoomsValue;
        private System.Windows.Forms.Label lblOpenRoomsText;
        private System.Windows.Forms.Label lblAppointmentsTodayValue;
        private System.Windows.Forms.Label lblAppointmentsTodayText;
        private System.Windows.Forms.Label lblTotalDoctorsValue;
        private System.Windows.Forms.Label lblTotalDoctorsText;
        private System.Windows.Forms.Label lblSystemModules;
        private System.Windows.Forms.Button btnPatientManagement;
        private System.Windows.Forms.Button btnAppointmentManagement;
        private System.Windows.Forms.Button btnBillingSystem;
        private System.Windows.Forms.Button btnDoctorManagement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}