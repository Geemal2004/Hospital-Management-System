using System;
using HospitalManagementSystem.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL
{
    public class DoctorRepository
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public void AddDoctor(User user,Doctor doctor,List<DoctorAvailability> availabilitySlots = null, List<DoctorQualifications> qualifications = null)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string userQuery = "INSERT INTO Users (UserName, Password, Role) " + "OUTPUT INSERTED.UserID " + "VALUES (@Username, @Password, 'Doctor')";
                    SqlCommand userCmd = new SqlCommand(userQuery, conn, transaction);
                    userCmd.Parameters.AddWithValue("@Username", user.UserName);
                    userCmd.Parameters.AddWithValue("@Password", user.Password);
                    int userId = (int)userCmd.ExecuteScalar();


                    string doctorQuery = "INSERT INTO Doctors (UserID, FirstName, LastName, ContactNumber, Email, Specialization, LicenseNumber, ConsultationFEE) " + "OUTPUT INSERTED.DoctorID " + "VALUES (@UserID, @FirstName, @LastName, @ContactNumber, @Email, @Specialization, @LicenseNumber, @ConsultationFee)";
                    SqlCommand doctorCmd = new SqlCommand(doctorQuery, conn, transaction);
                    doctorCmd.Parameters.AddWithValue("@UserID", userId);
                    doctorCmd.Parameters.AddWithValue("@FirstName",doctor.FirstName);
                    doctorCmd.Parameters.AddWithValue("@LastName",doctor.LastName);
                    doctorCmd.Parameters.AddWithValue("@ContactNumber", doctor.ContactNumber ?? (object)DBNull.Value);
                    doctorCmd.Parameters.AddWithValue("@Email",doctor.Email ?? (object)DBNull.Value);
                    doctorCmd.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                    doctorCmd.Parameters.AddWithValue("@LicenseNumber", doctor.LicenseNumber);
                    doctorCmd.Parameters.AddWithValue("@ConsultationFee", doctor.ConsultationFee);
                    int doctorId = (int)doctorCmd.ExecuteScalar();


                    if (availabilitySlots != null && availabilitySlots.Any())
                    {
                        foreach(var slot in availabilitySlots)
                        {
                            string availabilityQuery = "INSERT INTO DoctorAvailability (DoctorID, DayOfWeek, StartTime, EndTime) " + "VALUES (@DoctorID, @DayOfWeek, @StartTime, @EndTime)";
                            SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, conn, transaction);
                            availabilityCmd.Parameters.AddWithValue("@DoctorID", doctorId);
                            availabilityCmd.Parameters.AddWithValue("@DayOfWeek", slot.DayOfWeek);
                            availabilityCmd.Parameters.AddWithValue("@StartTime", slot.StartTime);
                            availabilityCmd.Parameters.AddWithValue("@EndTime", slot.EndTime);
                            availabilityCmd.ExecuteNonQuery();

                        }
                    }

                    if (qualifications != null && qualifications.Any())
                    {
                        foreach (var qualification in qualifications)
                        {
                            string qualificationQuery = "INSERT INTO DoctorQualifications (DoctorID, QualificationName, Institution, YearObtained) " +
                                                       "VALUES (@DoctorID, @QualificationName, @Institution, @YearObtained)";
                            SqlCommand qualificationCmd = new SqlCommand(qualificationQuery, conn, transaction);
                            qualificationCmd.Parameters.AddWithValue("@DoctorID", doctorId);
                            qualificationCmd.Parameters.AddWithValue("@QualificationName", qualification.QualificationName);
                            qualificationCmd.Parameters.AddWithValue("@Institution", qualification.Institution);
                            qualificationCmd.Parameters.AddWithValue("@YearObtained", qualification.YearObtained);
                            qualificationCmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();


                } 
                catch
                {
                    transaction.Rollback();
                    throw;
                }
                
            }
        }

        public DataTable GetAllDoctors()
        {
            string query = "Select d.DoctorId, d.UserID, d.FirstName, d.LastName, d.ContactNumber , d.Email, d.Specialization, d.LicenseNumber, d.ConsultationFEE, u.Username " + "From Doctors d " + "JOIN Users u ON d.UserID = u.UserID " + "WHERE u.Role = 'Doctor'";
            return _dbHelper.ExecuteQuery(query);
        }

        public void UpdateDoctor(int userId, User user, Doctor doctor,List<DoctorAvailability> availabilitySlots = null, List<DoctorQualifications> qualifications = null)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string userQuery = "UPDATE Users SET UserName = @Username, Password = @Password " + "WHERE UserID = @UserID";
                    SqlCommand userCmd = new SqlCommand(userQuery, conn, transaction);
                    userCmd.Parameters.AddWithValue("@UserID", userId);
                    userCmd.Parameters.AddWithValue("@Username", user.UserName);
                    userCmd.Parameters.AddWithValue("@Password", user.Password);
                    userCmd.ExecuteNonQuery();

                    string doctorQuery = "UPDATE Doctors SET FirstName = @FirstName, LastName = @LastName, ContactNumber = @ContactNumber, Email = @Email, Specialization = @Specialization, LicenseNumber = @LicenseNumber, ConsultationFEE = @ConsultationFee " + "WHERE UserID = @UserID";
                    SqlCommand doctorCmd = new SqlCommand(doctorQuery, conn, transaction);
                    doctorCmd.Parameters.AddWithValue("@UserID", userId);
                    doctorCmd.Parameters.AddWithValue("@FirstName", doctor.FirstName);
                    doctorCmd.Parameters.AddWithValue("@LastName", doctor.LastName);
                    doctorCmd.Parameters.AddWithValue("@ContactNumber", doctor.ContactNumber ?? (object)DBNull.Value);
                    doctorCmd.Parameters.AddWithValue("@Email", doctor.Email ?? (object)DBNull.Value);
                    doctorCmd.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                    doctorCmd.Parameters.AddWithValue("@LicenseNumber", doctor.LicenseNumber);
                    doctorCmd.Parameters.AddWithValue("@ConsultationFee", doctor.ConsultationFee);
                    doctorCmd.ExecuteNonQuery();

                    string getDoctorIdQuery = "SELECT DoctorID FROM Doctors WHERE UserID = @UserID";
                    SqlCommand getDoctorIdCmd = new SqlCommand(getDoctorIdQuery, conn, transaction);
                    getDoctorIdCmd.Parameters.AddWithValue("@UserID", userId);
                    int doctorId = (int)getDoctorIdCmd.ExecuteScalar();

                    string deleteAvailabilityQuery = "DELETE FROM DoctorAvailability WHERE DoctorID = @DoctorID";
                    SqlCommand deleteAvailabilityCmd = new SqlCommand(deleteAvailabilityQuery, conn, transaction);
                    deleteAvailabilityCmd.Parameters.AddWithValue("@DoctorID", doctorId);
                    deleteAvailabilityCmd.ExecuteNonQuery();

                    if (availabilitySlots != null && availabilitySlots.Any())
                    {
                        foreach (var slot in availabilitySlots)
                        {
                            string availabilityQuery = "INSERT INTO DoctorAvailability (DoctorID, DayOfWeek, StartTime, EndTime) " + "VALUES (@DoctorID, @DayOfWeek, @StartTime, @EndTime)";
                            SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, conn, transaction);
                            availabilityCmd.Parameters.AddWithValue("@DoctorID", doctorId);
                            availabilityCmd.Parameters.AddWithValue("@DayOfWeek", slot.DayOfWeek);
                            availabilityCmd.Parameters.AddWithValue("@StartTime", slot.StartTime);
                            availabilityCmd.Parameters.AddWithValue("@EndTime", slot.EndTime);
                            availabilityCmd.ExecuteNonQuery();
                        }
                    }

                    string deleteQualificationsQuery = "DELETE FROM DoctorQualifications WHERE DoctorID = @DoctorID";
                    SqlCommand deleteQualificationsCmd = new SqlCommand(deleteQualificationsQuery, conn, transaction);
                    deleteQualificationsCmd.Parameters.AddWithValue("@DoctorID", doctorId);
                    deleteQualificationsCmd.ExecuteNonQuery();
                    if (qualifications != null && qualifications.Any())
                    {
                        foreach (var qualification in qualifications)
                        {
                            string qualificationQuery = "INSERT INTO DoctorQualifications (DoctorID, QualificationName, Institution, YearObtained) " +
                                                       "VALUES (@DoctorID, @QualificationName, @Institution, @YearObtained)";
                            SqlCommand qualificationCmd = new SqlCommand(qualificationQuery, conn, transaction);
                            qualificationCmd.Parameters.AddWithValue("@DoctorID", doctorId);
                            qualificationCmd.Parameters.AddWithValue("@QualificationName", qualification.QualificationName);
                            qualificationCmd.Parameters.AddWithValue("@Institution", qualification.Institution);
                            qualificationCmd.Parameters.AddWithValue("@YearObtained", qualification.YearObtained);
                            qualificationCmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;

                }
            }
        }

        public void DeleteDoctor(int userId)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                   string userQuery = "DELETE FROM Users WHERE UserID = @UserID";
                    SqlCommand userCmd = new SqlCommand(userQuery, conn, transaction);
                    userCmd.Parameters.AddWithValue("@UserID", userId);
                    userCmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public List<DoctorAvailability> GetDoctorAvailability(int doctorId)
        {
            List<DoctorAvailability> availabilitySlots = new List<DoctorAvailability>();
            string query = "SELECT AvailabilityID, DoctorID, DayOfWeek, StartTime, EndTime " + "FROM DoctorAvailability " + "WHERE DoctorID = @DoctorID";

            using(SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    availabilitySlots.Add(new DoctorAvailability
                    {
                        AvailabilityID = reader.GetInt32(0),
                        DoctorID = reader.GetInt32(1),
                        DayOfWeek = reader.GetString(2),
                        StartTime = reader.GetTimeSpan(3),
                        EndTime = reader.GetTimeSpan(4)
                    });
                }
            }
            return availabilitySlots;
        }

        public List<DoctorQualifications> GetDoctorQualifications(int doctorId)
        {
            List<DoctorQualifications> qualifications = new List<DoctorQualifications>();
            string query = "SELECT QualificationID, DoctorID, QualificationName, Institution, YearObtained " +
                          "FROM DoctorQualifications " +
                          "WHERE DoctorID = @DoctorID";

            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    qualifications.Add(new DoctorQualifications
                    {
                        QualificationID = reader.GetInt32(0),
                        DoctorID = reader.GetInt32(1),
                        QualificationName = reader.GetString(2),
                        Institution = reader.GetString(3),
                        YearObtained = reader.GetInt32(4)
                    });
                }
            }
            return qualifications;
        }
    }
}
