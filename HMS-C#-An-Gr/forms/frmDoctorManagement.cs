using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.BLL;
using HospitalManagementSystem.Entities;

namespace HMS_C__An_Gr.forms
{
    public partial class frmDoctorManagement : Form
    {
        private readonly DoctorService _doctorService = new DoctorService();
        private List<DoctorAvailability> availabilitySlots = new List<DoctorAvailability>();
        private List<DoctorQualifications> qualifications = new List<DoctorQualifications>();
        private int selectedUserId = -1;
        public frmDoctorManagement()
        {
            InitializeComponent();
            LoadDoctors();
            SetupAvailabilityGrid();
            SetupQualificationsGrid();
        }
        private void LoadDoctors()
        {
            dataGridViewDoctors.DataSource = _doctorService.GetAllDoctors();
        }


        private void SetupAvailabilityGrid()
        {
            dataGridViewAvailability.Columns.Add("DayOfWeek", "Day of Week");
            dataGridViewAvailability.Columns.Add("StartTime", "Start Time (HH:mm)");
            dataGridViewAvailability.Columns.Add("EndTime", "End Time (HH:mm)");
        }

        private void SetupQualificationsGrid()
        {
            dataGridViewQualifications.Columns.Add("QualificationName", "Qualification Name");
            dataGridViewQualifications.Columns.Add("Institution", "Institution");
            dataGridViewQualifications.Columns.Add("YearObtained", "Year Obtained");
        }

        private void btnAddAvailability_Click(object sender, EventArgs e)
        {
            dataGridViewAvailability.Rows.Add("Monday", "09:00", "17:00");
        }

        private void btnAddQualification_Click(object sender, EventArgs e)
        {
            dataGridViewQualifications.Rows.Add("MBBS", "Harvard Medical School", DateTime.Now.Year);
        }

        private string SanitizeInput(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return input.Replace("{", "").Replace("}", "").Replace(";", "").Trim();
        }


        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            User user = new User
            {
                UserName = SanitizeInput( txtUsername.Text),
                Password = SanitizeInput( txtPassword.Text),
                Role = "Doctor"
            };

            Doctor doctor = new Doctor
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                ContactNumber = txtContact.Text,
                Email = txtEmail.Text,
                Specialization = txtSpecialization.Text,
                LicenseNumber = txtLicenseNumber.Text,
                //ConsultationFee = Convert.ToDecimal(txtConsultationFee.Text)
                //ConsultationFee = decimal.TryParse(txtConsultationFee.Text, out decimal fee) ? fee : (decimal?)null

            };
            if (!decimal.TryParse(txtConsultationFee.Text, out decimal fee))
            {
                MessageBox.Show("Please enter a valid Consultation Fee (e.g., 100.00).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            doctor.ConsultationFee = fee;

            // Collect availability slots
            availabilitySlots.Clear();
            foreach (DataGridViewRow row in dataGridViewAvailability.Rows)
            {
                if (row.IsNewRow) continue;
                try
                {
                    string dayOfWeek = SanitizeInput(row.Cells["DayOfWeek"].Value?.ToString());
                    string startTime = SanitizeInput(row.Cells["StartTime"].Value?.ToString());
                    string endTime = SanitizeInput(row.Cells["EndTime"].Value?.ToString());

                    availabilitySlots.Add(new DoctorAvailability
                    {
                        DayOfWeek = dayOfWeek,
                        StartTime = TimeSpan.Parse(startTime),
                        EndTime = TimeSpan.Parse(endTime)
                    });

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Invalid time format in availability slot: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Collect qualifications
            qualifications.Clear();
            foreach (DataGridViewRow row in dataGridViewQualifications.Rows)
            {
                if (row.IsNewRow) continue;
                try
                {

                    string qualificationName = SanitizeInput(row.Cells["QualificationName"].Value?.ToString());
                    string institution = SanitizeInput(row.Cells["Institution"].Value?.ToString());
                    string yearObtained = SanitizeInput(row.Cells["YearObtained"].Value?.ToString());
                    qualifications.Add(new DoctorQualifications
                    {
                        QualificationName = qualificationName,
                        Institution = institution,
                        YearObtained = int.Parse(yearObtained)
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Invalid format in qualification: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                _doctorService.AddDoctor(user, doctor, availabilitySlots, qualifications);
                LoadDoctors();
                ClearForm();
                MessageBox.Show("Doctor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewDoctors_SelectionChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"SelectionChanged event fired. SelectedRows: {dataGridViewDoctors.SelectedRows.Count}");
            if (dataGridViewDoctors.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewDoctors.SelectedRows[0];
                try
                {
                    selectedUserId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
                    int doctorId = Convert.ToInt32(selectedRow.Cells["DoctorID"].Value);
                    Console.WriteLine($"Selected UserID: {selectedUserId}, DoctorID: {doctorId}");

                    txtFirstName.Text = selectedRow.Cells["FirstName"].Value?.ToString() ?? "";
                    txtLastName.Text = selectedRow.Cells["LastName"].Value?.ToString() ?? "";
                    txtContact.Text = selectedRow.Cells["ContactNumber"].Value?.ToString() ?? "";
                    txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString() ?? "";
                    txtSpecialization.Text = selectedRow.Cells["Specialization"].Value?.ToString() ?? "";
                    txtLicenseNumber.Text = selectedRow.Cells["LicenseNumber"].Value?.ToString() ?? "";
                    txtConsultationFee.Text = selectedRow.Cells["ConsultationFee"].Value?.ToString() ?? "";
                    txtUsername.Text = selectedRow.Cells["UserName"].Value?.ToString() ?? "";

                    // Load availability slots
                    dataGridViewAvailability.Rows.Clear();
                    var availabilitySlots = _doctorService.GetDoctorAvailability(doctorId);
                    foreach (var slot in availabilitySlots)
                    {
                        dataGridViewAvailability.Rows.Add(slot.DayOfWeek, slot.StartTime.ToString(@"hh\:mm"), slot.EndTime.ToString(@"hh\:mm"));
                    }

                    dataGridViewQualifications.Rows.Clear();
                    var qualifications = _doctorService.GetDoctorQualifications(doctorId);
                    foreach (var qualification in qualifications)
                    {
                        dataGridViewQualifications.Rows.Add(qualification.QualificationName, qualification.Institution, qualification.YearObtained);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in SelectionChanged: {ex.Message}");
                    selectedUserId = -1;
                }
            }
            else
            {
                Console.WriteLine("No rows selected.");
                selectedUserId = -1;
            }
        }








        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtSpecialization.Clear();
            txtLicenseNumber.Clear();
            txtConsultationFee.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            dataGridViewAvailability.Rows.Clear();
            dataGridViewQualifications.Rows.Clear();
        }
        private void btnAddAvailability_Click_1(object sender, EventArgs e)
        {
            dataGridViewAvailability.Rows.Add("Monday", "09:00", "17:00");
        }

        private void btnAddQualification_Click_1(object sender, EventArgs e)
        {
            dataGridViewQualifications.Rows.Add("MBBS", "Harvard Medical School", DateTime.Now.Year);
        }

        private void frmDoctorManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            {
                if (selectedUserId <= 0)
                {
                    MessageBox.Show("Please select a doctor to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                User user = new User
                {

                    UserName = txtUsername.Text,
                    Password = txtPassword.Text,
                    Role = "Doctor"
                };

                Doctor doctor = new Doctor
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    ContactNumber = txtContact.Text,
                    Email = txtEmail.Text,
                    Specialization = txtSpecialization.Text,
                    LicenseNumber = txtLicenseNumber.Text,
                    //ConsultationFee = decimal.TryParse(txtConsultationFee.Text, out decimal fee) ? fee : (decimal?)null
                };

                if (!decimal.TryParse(txtConsultationFee.Text, out decimal fee))
                {
                    MessageBox.Show("Please enter a valid Consultation Fee (e.g., 100.00).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                doctor.ConsultationFee = fee;

                availabilitySlots.Clear();
                foreach (DataGridViewRow row in dataGridViewAvailability.Rows)
                {
                    if (row.IsNewRow) continue;
                    try
                    {
                        availabilitySlots.Add(new DoctorAvailability
                        {
                            DayOfWeek = row.Cells["DayOfWeek"].Value?.ToString(),
                            StartTime = TimeSpan.Parse(row.Cells["StartTime"].Value?.ToString()),
                            EndTime = TimeSpan.Parse(row.Cells["EndTime"].Value?.ToString())
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Invalid time format in availability slot: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                qualifications.Clear();
                foreach (DataGridViewRow row in dataGridViewQualifications.Rows)
                {
                    if (row.IsNewRow) continue;
                    try
                    {
                        qualifications.Add(new DoctorQualifications
                        {
                            QualificationName = row.Cells["QualificationName"].Value?.ToString(),
                            Institution = row.Cells["Institution"].Value?.ToString(),
                            YearObtained = int.Parse(row.Cells["YearObtained"].Value?.ToString())
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Invalid format in qualification: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                try
                {
                    _doctorService.UpdateDoctor(selectedUserId, user, doctor, availabilitySlots, qualifications);
                    LoadDoctors();

                    dataGridViewAvailability.Rows.Clear();
                    dataGridViewQualifications.Rows.Clear();
                    selectedUserId = -1;
                    MessageBox.Show("Doctor updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            {
                if (selectedUserId <= 0)
                {
                    MessageBox.Show("Please select a doctor to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure you want to delete this doctor?  This will also delete their availability and qualifications.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }

                try
                {
                    _doctorService.DeleteDoctor(selectedUserId);
                    LoadDoctors();
                    dataGridViewAvailability.Rows.Clear();
                    dataGridViewQualifications.Rows.Clear();
                    selectedUserId = -1;
                    MessageBox.Show("Doctor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
