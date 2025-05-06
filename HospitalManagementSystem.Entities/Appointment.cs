using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entities
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public string Status { get; set; } // e.g., Scheduled, Completed, Cancelled
        public string Notes { get; set; } // Additional notes for the appointment
    }
}
