using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entities
{
    public class Doctor
    {
        public int DoctorID {  get; set; }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber {  get; set; }
        public string Email { get; set; }
        public string Specialization { get; set; }
        public string LicenseNumber { get; set; }
        public decimal ConsultationFee { get; set; }
        //public List<DoctorQualification> Qualifications { get; set; } = new List<DoctorQualification>();
    }
}
