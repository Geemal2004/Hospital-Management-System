using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.BLL
{
    internal class AppointmentService
    {
        /*ScheduleAppointment(Appointment appointment): Checks for doctor availability (might need a GetDoctorSchedule method in DoctorRepository), validates patient/doctor existence, checks for conflicts, then calls AppointmentRepository.AddAppointment().
CancelUserAppointment(int appointmentId, int userId): Checks if the user has permission to cancel, then calls AppointmentRepository.CancelAppointment().
GetUpcomingAppointments(int patientId): Retrieves future appointments for a patient.
GetDoctorSchedule(int doctorId, DateTime date): Retrieves appointments for a specific doctor on a given day.
        */
    }
}
