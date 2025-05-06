using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entities
{
    public class Prescription
    {

        public int PrescriptionId { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public int MedicationID { get; set; }
        public string Dosage { get; set; } 
        public string Frequency { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Instructions { get; set; } 


    }
}
