using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entities
{
    public class PatientMedicalHistory
    {
        public int MedicalHistoryId { get; set; }
        public int PatientID { get; set; }
        public DateTime VisitDate { get; set; }
        public string Symptoms { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        //public string Prescriptions { get; set; } // List of medications prescribed
        public string Notes { get; set; } // Additional notes from the doctor
    }
}
