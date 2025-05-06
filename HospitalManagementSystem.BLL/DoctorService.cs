using System;
using HospitalManagementSystem.DAL;
using HospitalManagementSystem.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace HospitalManagementSystem.BLL
{
    public class DoctorService
    {
        private readonly DoctorRepository _doctorRepo = new DoctorRepository();
        private readonly UserRepository _userRepo = new UserRepository();   
        public void AddDoctor(User user, Doctor doctor, List<DoctorAvailability> availabilitySlots = null, List<DoctorQualifications> qualifications = null)
        {
            // Validate user role
            User existingUser = _userRepo.GetUserByUsername(user.UserName);
            if (existingUser != null)
            {
                if (existingUser.Role != "Doctor")
                    throw new ArgumentException("The user must have the role 'Doctor'.");
            }
            else
            {
                if (user.Role != "Doctor")
                    throw new ArgumentException("The user must have the role 'Doctor'.");
            }
            // Business logic: Validate data
            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password))
                throw new ArgumentException("Username and password are required.");
            if (string.IsNullOrEmpty(doctor.FirstName) || string.IsNullOrEmpty(doctor.LastName))
                throw new ArgumentException("First name and last name are required.");
            if (string.IsNullOrEmpty(doctor.Specialization) || string.IsNullOrEmpty(doctor.LicenseNumber))
                throw new ArgumentException("Specialization and license number are required.");

            if (availabilitySlots != null)
            {
                foreach (var slot in availabilitySlots)
                {
                    if (string.IsNullOrEmpty(slot.DayOfWeek) || slot.StartTime >= slot.EndTime)
                        throw new ArgumentException("Invalid availability slot: DayOfWeek is required, and StartTime must be less than EndTime.");
                }
            }

            if (qualifications != null)
            {
                foreach (var qualification in qualifications)
                {
                    if (string.IsNullOrEmpty(qualification.QualificationName) || string.IsNullOrEmpty(qualification.Institution))
                        throw new ArgumentException("Qualification name and institution are required.");
                    if (qualification.YearObtained < 1900 || qualification.YearObtained > DateTime.Now.Year)
                        throw new ArgumentException("Year obtained must be between 1900 and the current year.");
                }
            }

            _doctorRepo.AddDoctor(user, doctor, availabilitySlots, qualifications);
        }

        public void UpdateDoctor(int userId, User user, Doctor doctor,List<DoctorAvailability> availabilitySlots = null, List<DoctorQualifications> qualifications = null)
        {
            // Validate user role
            User existingUser = _userRepo.GetUserByUsername(user.UserName);
            if (existingUser != null)
            {
                if (existingUser.Role != "Doctor")
                    throw new ArgumentException("The user must have the role 'Doctor'.");
            }
            else
            {
                if (user.Role != "Doctor")
                    throw new ArgumentException("The user must have the role 'Doctor'.");
            }
            // Business logic: Validate data
            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password))
                throw new ArgumentException("Username and password are required.");
            if (string.IsNullOrEmpty(doctor.FirstName) || string.IsNullOrEmpty(doctor.LastName))
                throw new ArgumentException("First name and last name are required.");
            if (string.IsNullOrEmpty(doctor.Specialization) || string.IsNullOrEmpty(doctor.LicenseNumber))
                throw new ArgumentException("Specialization and license number are required.");
            if (availabilitySlots != null)
            {
                foreach (var slot in availabilitySlots)
                {
                    if (string.IsNullOrEmpty(slot.DayOfWeek) || slot.StartTime >= slot.EndTime)
                        throw new ArgumentException("Invalid availability slot: DayOfWeek is required, and StartTime must be less than EndTime.");
                }
            }
            if (qualifications != null)
            {
                foreach (var qualification in qualifications)
                {
                    if (string.IsNullOrEmpty(qualification.QualificationName) || string.IsNullOrEmpty(qualification.Institution))
                        throw new ArgumentException("Qualification name and institution are required.");
                    if (qualification.YearObtained < 1900 || qualification.YearObtained > DateTime.Now.Year)
                        throw new ArgumentException("Year obtained must be between 1900 and the current year.");
                }
            }
            _doctorRepo.UpdateDoctor(userId, user, doctor, availabilitySlots, qualifications);
        }

        /*public void DeleteDoctor(int userId,User user)
        {
            User existingUser = _userRepo.GetUserByUsername(user.UserName);
            if (existingUser != null)
            {
                if (existingUser.Role != "Doctor")
                    throw new ArgumentException("The user must have the role 'Doctor'.");
                _doctorRepo.DeleteDoctor(userId);
            }
            else
            {
                if (user.Role != "Doctor")
                    throw new ArgumentException("The user must have the role 'Doctor'.");
            }

        }
        */

        public void DeleteDoctor(int userId)
        {
            if (userId <= 0)
                throw new ArgumentException("Invalid UserID.");

            _doctorRepo.DeleteDoctor(userId);
        }

        public DataTable GetAllDoctors()
        {
            return _doctorRepo.GetAllDoctors();
        }

        public List<DoctorAvailability> GetDoctorAvailability(int doctorId)
        {
            return _doctorRepo.GetDoctorAvailability(doctorId);
        }
        public List<DoctorQualifications> GetDoctorQualifications(int doctorId)
        {
            return _doctorRepo.GetDoctorQualifications(doctorId);
        }
    }
}