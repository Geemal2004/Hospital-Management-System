using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.BLL;
using HospitalManagementSystem.Entities;

namespace HMS_C__An_Gr.forms
{
    public partial class Patient_Management : Form
    {
        private readonly PatientService _patientService = new PatientService();
        private List<Appointment> appointments = new List<Appointment>();
        
        public Patient_Management()
        {
             
            InitializeComponent();
            LoadPatients();
            SetupAppointmentGrid();
        }
        private void LoadPatients()
        {
            dataGridViewPatients.DataSource = _patientService.GetAllPatients();
        }

        private void SetupAppointmentGrid()
        {
            
            dataGridViewAppointments.Columns.Add("AppointmentId", "Appointment ID");
            dataGridViewAppointments.Columns.Add("AppointmentDateTime", "Appointment Date");
            dataGridViewAppointments.Columns.Add("DoctorID", "Doctor ID");
            dataGridViewAppointments.Columns.Add("PatientID", "Patient ID");
            dataGridViewAppointments.Columns.Add("Status", "Status");
            dataGridViewAppointments.Columns.Add("Notes", "Notes");
            // Set the DataSource to the appointments list
            dataGridViewAppointments.DataSource = appointments;
        }
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            dataGridViewAppointments.Rows.Add(1, DateTime.Now.AddDays(1).ToString("yyyy-MM-dd HH:mm"), "Scheduled", "");
        }
        private string SanitizeInput(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return input.Replace("{", "").Replace("}", "").Replace(";", "").Trim();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient
            {
                FirstName = SanitizeInput(txtFirstName.Text),
                LastName = SanitizeInput(txtLastName.Text),
                ContactNumber = SanitizeInput(txtGender.Text),
                Address = SanitizeInput(txtAddress.Text),
                EmergencyContact = SanitizeInput(txtEmergencyContact.Text),
                BloodType = SanitizeInput(txtBloodType.Text),
                Gender = SanitizeInput(txtGender.Text),
                DateOfBirth = dtpDateOfBirth.Value,


            }
        }
        */
    }
}
