using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_C__An_Gr.forms;
using HospitalManagementSystem.BLL;
using HospitalManagementSystem.Entities;

namespace HospitalManagementSystem.UI
{
    public partial class frmMain : Form
    {
        private readonly DatabaseService _dbService = new DatabaseService();
        private readonly UserContext _userContext;
        private readonly PatientService _patientService = new PatientService();
        public frmMain(UserContext userContext)
        {
            InitializeComponent();
            _userContext = userContext;
            InitializeForm();

        }
        private void InitializeForm()
        {
            lblWelcome.Text = $"Welcome, {_userContext.UserName} {_userContext.Role}!";
            if (_userContext.Role == "Administrator")
            {
                btnDoctorManagement.Visible = true;
            }
            else
            {
                btnDoctorManagement.Visible = false;
                tableLayoutPanel1.Controls.Remove(btnDoctorManagement);
                btnAppointmentManagement.Location = btnDoctorManagement.Location;
            }

            UpdateDashboardMetrics();
        }

        private void UpdateDashboardMetrics()
        {
            // Example: Update the number of patients and doctors
            lblTotalPatientsValue.Text = _patientService.GetPatientCount().ToString();
            lblTotalDoctorsValue.Text = "24";// _dbService.GetTotalDoctors().ToString();
            lblAppointmentsTodayValue.Text = "35 Today";// _dbService.GetTotalAppointments().ToString();
            lblOpenRoomsValue.Text = "12";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Close();

        }

      

        private void btnPatientManagement_Click(object sender, EventArgs e)
        {
            Patient_Management patientManagementForm = new Patient_Management();
            patientManagementForm.ShowDialog();
        }

        private void btnDoctorManagement_Click(object sender, EventArgs e)
        {
            frmDoctorManagement doctorManagementForm = new frmDoctorManagement();
            doctorManagementForm.ShowDialog();

        }

        private void btnAppointmentManagement_Click(object sender, EventArgs e)
        {
            frmAppointmentManagement appointmentManagementForm = new frmAppointmentManagement();
            appointmentManagementForm.ShowDialog();
        }

        private void btnBillingSystem_Click(object sender, EventArgs e)
        {
            frmBillingManagement billingManagementForm = new frmBillingManagement();
            billingManagementForm.ShowDialog();
        }

        private void panelTotalPatients_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
