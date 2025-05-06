using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.DAL;
using HospitalManagementSystem.Entities;
namespace HospitalManagementSystem.BLL
{
    public class PatientService
    {
        private readonly PatientRepository _patientRepo = new PatientRepository();

        public void AddPatient(Patient patient, List<Appointment> appointments = null, List<PatientMedicalHistory> patientMedicalHistories = null)
        {
            if (string.IsNullOrEmpty(patient.FirstName) || string.IsNullOrEmpty(patient.LastName))
            {
                throw new ArgumentException("First name and last name are required.");

            }
            
            if (patient.DateOfBirth == DateTime.MinValue)
            {
                throw new ArgumentException("Date of birth is required.");
            }
            if (appointments != null)
            {
                foreach (var appointment in appointments)
                {
                    
                    if (appointment.AppointmentDateTime == DateTime.MinValue )
                    {
                        throw new ArgumentException("Appointment date is required.");
                    }
                    if (appointment.DoctorID <= 0 || appointment.PatientID <= 0)
                    {
                        throw new ArgumentException("Doctor ID and Patient ID is required.");
                    }

                }
            }

            if (patientMedicalHistories != null)
            {
                foreach (var medicalHistory in patientMedicalHistories)
                {
                    if (string.IsNullOrEmpty(medicalHistory.Symptoms) || string.IsNullOrEmpty(medicalHistory.Treatment))
                    {
                        throw new ArgumentException("Symtoms and treatment are required.");
                    }
                    if (medicalHistory.VisitDate == DateTime.MinValue)
                    {
                        throw new ArgumentException("Date of diagnosis is required.");
                    }
                }
            }

           


            
            _patientRepo.AddPatient(patient, appointments, patientMedicalHistories);
        }


        public void UpdatePatient(Patient patient, List<Appointment> appointments = null, List<PatientMedicalHistory> patientMedicalHistories = null, List<Prescription> prescriptions = null)
        {
            if (string.IsNullOrEmpty(patient.FirstName) || string.IsNullOrEmpty(patient.LastName))
            {
                throw new ArgumentException("First name and last name are required.");

            }

            if (patient.DateOfBirth == DateTime.MinValue)
            {
                throw new ArgumentException("Date of birth is required.");
            }
            if (appointments != null)
            {
                foreach (var appointment in appointments)
                {

                    if (appointment.AppointmentDateTime == DateTime.MinValue)
                    {
                        throw new ArgumentException("Appointment date is required.");
                    }
                    if (appointment.DoctorID <= 0 || appointment.PatientID <= 0)
                    {
                        throw new ArgumentException("Doctor ID and Patient ID is required.");
                    }

                }
            }

            if (patientMedicalHistories != null)
            {
                foreach (var medicalHistory in patientMedicalHistories)
                {
                    if (string.IsNullOrEmpty(medicalHistory.Symptoms) || string.IsNullOrEmpty(medicalHistory.Treatment))
                    {
                        throw new ArgumentException("Symtoms and treatment are required.");
                    }
                    if (medicalHistory.VisitDate == DateTime.MinValue)
                    {
                        throw new ArgumentException("Date of diagnosis is required.");
                    }
                }
            }

            if (prescriptions != null)
            {
                foreach (var prescription in prescriptions)
                {

                    if (prescription.PatientID <= 0)
                    {
                        throw new ArgumentException("Patient ID is required.");
                    }

                    if (prescription.DoctorID <= 0)
                    {
                        throw new ArgumentException("Doctor ID is required.");
                    }
                    if (prescription.MedicationID <= 0)
                    {
                        throw new ArgumentException("Medication ID is required.");
                    }


                    if ( string.IsNullOrEmpty(prescription.Dosage))
                    {
                        throw new ArgumentException("dosage is required.");
                    }
                    if (prescription.StartDate == DateTime.MinValue)
                    {
                        throw new ArgumentException("Prescription date is required.");
                    }
                }
            }


        }
        public DataTable GetAllPatients()
        {
            return _patientRepo.GetAllPatients();
        }

        public int GetPatientCount()
        {
            return _patientRepo.GetPatientCount();
        }

        public List<Prescription> Prescriptions(int patientId)
        {
            return _patientRepo.GetPrescriptions(patientId);
        }

        public List<Appointment> GetPatientAppointments(int patientId )
        {
            return _patientRepo.GetPatientAppointments(patientId);

        }

        public List<PatientMedicalHistory> GetPatientMedicalHistory(int patientId)
        {
            return _patientRepo.GetPatientMedicalHistory(patientId);

        }

    }
}
