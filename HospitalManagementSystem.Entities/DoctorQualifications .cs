using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entities
{
    public class DoctorQualifications
    {
        public int QualificationID { get; set; }
        public int DoctorID { get; set; }
        public string QualificationName { get; set; }
        public string Institution {  get; set; }
        public int YearObtained { get; set; }
    }
}
