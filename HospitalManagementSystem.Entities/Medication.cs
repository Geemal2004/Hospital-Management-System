using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entities
{
    public class Medication
    {
        public int MedicationId { get; set; }
        public string MedicationName { get; set; }
        public string GenericName { get; set; }
        public string Strength { get; set; }
        public string Form {  get; set; }
        public string Manufacturer { get; set; }
        public string NMRARegistrationNumber { get; set; }
        public string Classification { get; set; }

    }
}
