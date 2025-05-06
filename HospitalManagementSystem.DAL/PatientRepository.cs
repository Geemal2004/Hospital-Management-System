using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.Entities;

namespace HospitalManagementSystem.DAL
{
    public class PatientRepository
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        /*public void AddPatient(Patient patient)
        {
            string query = $"INSERT INTO Patients (FirstName, LastName, DateOfBirth ,Gender , ContactNumber, Address, EmergencyContact, BloodType) " + "$VALUES('{patient.FirstName}', '{patient.LastName}', '{patient.DateOfBirth}', '{patient.Gender}', '{patient.ContactNumber}', '{patient.Address}', '{patient.EmergencyContact}', '{patient.BloodType}')";
            _dbHelper.ExecuteNonQuery(query);
        }*/
        public void AddPatient( Patient patient, List<Appointment> appointments = null ,List<PatientMedicalHistory> patientMedicalHistories = null  )
        {
            using (SqlConnection conn = _dbHelper.GetConnection( ) )
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string patientQuery = "INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, ContactNumber, Address, EmergencyContact, BloodType) " + "OUTPUT INSERTED.PatientId " + " VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @ContactNumber, @Address, @EmergencyContact, @BloodType)";
                    SqlCommand userCommand = new SqlCommand(patientQuery, conn, transaction);
                    userCommand.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    userCommand.Parameters.AddWithValue("@LastName", patient.LastName);
                    userCommand.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                    userCommand.Parameters.AddWithValue("@Gender", patient.Gender);
                    userCommand.Parameters.AddWithValue("@ContactNumber", patient.ContactNumber);
                    userCommand.Parameters.AddWithValue("@Address", patient.Address);
                    userCommand.Parameters.AddWithValue("@EmergencyContact", patient.EmergencyContact);
                    userCommand.Parameters.AddWithValue("@BloodType", patient.BloodType);
                    int patientId = (int)userCommand.ExecuteScalar();

                    if (appointments != null)
                    {
                        foreach (var appointment in appointments)
                        {
                            string appointmentQuery = "INSERT INTO Appointments (PatientId, AppointmentDate, DoctorId) " +
                                                       "VALUES (@PatientId, @AppointmentDate, @DoctorId)";
                            SqlCommand appointmentCommand = new SqlCommand(appointmentQuery, conn, transaction);
                            appointmentCommand.Parameters.AddWithValue("@PatientId", patientId);
                            appointmentCommand.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDateTime);
                            appointmentCommand.Parameters.AddWithValue("@DoctorId", appointment.DoctorID);
                            appointmentCommand.Parameters.AddWithValue("@Status", appointment.Status);
                            appointmentCommand.Parameters.AddWithValue("@Notes", appointment.Notes);
                            appointmentCommand.ExecuteNonQuery();
                        }
                    }

                    if (patientMedicalHistories != null)
                    {
                        foreach (var history in patientMedicalHistories)
                        {
                            string historyQuery = "INSERT INTO PatientMedicalHistory (PatientId, VisitDate, Symptoms, Date) " +
                                                  "VALUES (@PatientId, @Condition, @Treatment, @Date)";
                            SqlCommand historyCommand = new SqlCommand(historyQuery, conn, transaction);
                            historyCommand.Parameters.AddWithValue("@PatientId", patientId);
                            historyCommand.Parameters.AddWithValue("@VisitDate", history.VisitDate);
                            historyCommand.Parameters.AddWithValue("@Symptoms", history.Symptoms);
                            historyCommand.Parameters.AddWithValue("@Diagnosis", history.Diagnosis);
                            historyCommand.Parameters.AddWithValue("@Treatment", history.Treatment);
                            historyCommand.Parameters.AddWithValue("@Notes", history.Notes);
                            historyCommand.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error adding patient: " + ex.Message);
                }
            }
        }


        public void UpdatePatient(int patientId, Patient patient, List<Appointment> appointments = null,List<PatientMedicalHistory> patientMedicalHistories = null,List<Prescription> prescriptions = null)
            {
            using (SqlConnection conn =_dbHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string patientQuery = "UPDATE Patients SET FirstName = @FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth, Gender = @Gender, ContactNumber = @ContactNumber, Address = @Address, EmergencyContact = @EmergencyContact, BloodType =@BloodType " + "WHERE PatientId = @PatientId";
                    SqlCommand patientCmd = new SqlCommand(patientQuery, conn, transaction);
                    patientCmd.Parameters.AddWithValue("@PatientId", patientId);
                    patientCmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    patientCmd.Parameters.AddWithValue("@LastName", patient.LastName);
                    patientCmd.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                    patientCmd.Parameters.AddWithValue("Gender", patient.Gender);
                    patientCmd.Parameters.AddWithValue("@ContactNumber", patient.ContactNumber);
                    patientCmd.Parameters.AddWithValue("@Address", patient.Address);
                    patientCmd.Parameters.AddWithValue("@EmergencyContact", patient.EmergencyContact);
                    patientCmd.Parameters.AddWithValue("@BloodType", patient.BloodType);

                    if (patientMedicalHistories != null && patientMedicalHistories.Any())
                    {
                        foreach (var slot in patientMedicalHistories)
                        {
                            string historyQuery = "INSERT INTO PatientMedicalHistory (PatientId, VisitDate, Symptoms, Diagnosis, Treatment, Notes) " +
                                                  "VALUES (@PatientId, @VisitDate, @Symptoms, @Diagnosis, @Treatment, @Notes)";
                            SqlCommand historyCmd = new SqlCommand(historyQuery, conn, transaction);
                            historyCmd.Parameters.AddWithValue("@MedicalHistoryId", slot.MedicalHistoryId);
                            historyCmd.Parameters.AddWithValue("@VisitDate", slot.VisitDate);
                            historyCmd.Parameters.AddWithValue("@Symptoms", slot.Symptoms);
                            historyCmd.Parameters.AddWithValue("@Diagnosis", slot.Diagnosis);
                            historyCmd.Parameters.AddWithValue("@Treatment", slot.Treatment);
                            historyCmd.Parameters.AddWithValue("@Notes", slot.Notes);
                            historyCmd.ExecuteNonQuery();
                        }

                    }

                    if (appointments != null && appointments.Any())
                    {
                        foreach (var appointment in appointments)
                        {
                            string appointmentQuery = "INSERT INTO Appointments (PatientId, AppointmentDate, DoctorId, Status, Notes) " +
                                                       "VALUES (@PatientId, @AppointmentDate, @DoctorId, @Status, @Notes)";
                            SqlCommand appointmentCmd = new SqlCommand(appointmentQuery, conn, transaction);
                            appointmentCmd.Parameters.AddWithValue("@PatientId", patientId);
                            appointmentCmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDateTime);
                            appointmentCmd.Parameters.AddWithValue("@DoctorId", appointment.DoctorID);
                            appointmentCmd.Parameters.AddWithValue("@Status", appointment.Status);
                            appointmentCmd.Parameters.AddWithValue("@Notes", appointment.Notes);
                            appointmentCmd.ExecuteNonQuery();
                        }
                    }

                    if (prescriptions != null && prescriptions.Any())
                    {
                        foreach (var prescription in prescriptions)
                        {
                            string prescriptionQuery = "INSERT INTO Prescriptions (PatientId, DoctorID, Dosage, Frequency, StartDate, EndDate) " +
                                                       "VALUES (@PatientId, @MedicationName, @Dosage, @Frequency, @StartDate, @EndDate)";
                            SqlCommand prescriptionCmd = new SqlCommand(prescriptionQuery, conn, transaction);
                            prescriptionCmd.Parameters.AddWithValue("@PatientId", patientId);
                            prescriptionCmd.Parameters.AddWithValue("@MedicationName", prescription.DoctorID);
                            prescriptionCmd.Parameters.AddWithValue("@MedicationName", prescription.MedicationID);
                            prescriptionCmd.Parameters.AddWithValue("@Dosage", prescription.Dosage);
                            prescriptionCmd.Parameters.AddWithValue("@Frequency", prescription.Frequency);
                            prescriptionCmd.Parameters.AddWithValue("@StartDate", prescription.StartDate);
                            prescriptionCmd.Parameters.AddWithValue("@EndDate", prescription.EndDate);
                            prescriptionCmd.Parameters.AddWithValue("@Instructions", prescription.Instructions);
                            prescriptionCmd.ExecuteNonQuery();

                        }
                    }


                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error updating patient: " + ex.Message);
                }
            }
        }


        public List<Appointment> GetPatientAppointments(int patientId)
        {
            List<Appointment> appointments = new List<Appointment>();
            string query = "SELECT * FROM Appointments WHERE PatientId = @PatientId";
            using (SqlConnection connection = _dbHelper.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientId", patientId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    appointments.Add(new Appointment
                    {
                        AppointmentId = (int)reader["AppointmentId"],
                        AppointmentDateTime = (DateTime)reader["AppointmentDate"],
                        PatientID = (int)reader["PatientId"],
                        DoctorID = (int)reader["DoctorId"],
                        Status = reader["Status"].ToString(),
                        Notes = reader["Notes"].ToString()
                    });
                }
            }
            return appointments;
        }

        public List<PatientMedicalHistory> GetPatientMedicalHistory(int patientId)
        {
            List<PatientMedicalHistory> medicalHistories = new List<PatientMedicalHistory>();
            string query = "SELECT * FROM PatientMedicalHistory WHERE PatientId = @PatientId";
            using (SqlConnection connection = _dbHelper.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientId", patientId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    medicalHistories.Add(new PatientMedicalHistory
                    {
                        MedicalHistoryId = (int)reader["MedicalHistoryId"],
                        PatientID = (int)reader["PatientId"],
                        VisitDate = (DateTime)reader["VisitDate"],
                        Symptoms = reader["Symptoms"].ToString(),
                        Diagnosis = reader["Diagnosis"].ToString(),
                        Treatment = reader["Treatment"].ToString(),
                        Notes = reader["Notes"].ToString()
                    });
                }
            }
            return medicalHistories;
        }

        public List<Prescription> GetPrescriptions(int patientId)
        {
            List<Prescription> prescriptions = new List<Prescription>();
            string query = "SELECT * FROM Prescriptions WHERE  PatientId = @PatientId";
            using (SqlConnection connection = _dbHelper.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PatientId", patientId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    prescriptions.Add(new Prescription
                    {
                        PrescriptionId = (int)reader["PrescriptionId"],
                        PatientID = (int)reader["PatientId"],
                        DoctorID = (int)reader["DoctorId"],
                        MedicationID = (int)reader["MedicationId"],
                        Dosage = reader["Dosage"].ToString(),
                        Frequency = reader["Frequency"].ToString(),
                        StartDate = (DateTime)reader["StartDate"],
                        EndDate = (DateTime)reader["EndDate"],
                        Instructions = reader["Instructions"].ToString()


                    });
                }
            }
            return prescriptions;
        }
        public DataTable GetAllPatients()
        {
            string query = "SELECT * FROM Patients";
            return _dbHelper.ExecuteQuery(query);
        }

        public int GetPatientCount()
        {
            string query = "SELECT COUNT(*) FROM Patients";
            using (SqlConnection connection = _dbHelper.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                return (int)command.ExecuteScalar();
            }
        }

    }
}
