using SuperDoc.Services.Appointments.Models;
using SuperDoc.Services.Appointments.Models.Enums;
using System.Collections.Generic;

namespace SuperDoc.Services.Appointments
{
    public interface IAppointmentService
    {
        bool Create(
            string patientId, 
            string physicianId, 
            string date, 
            string hour);

        AllMyAppointmentsQueryServiceModel All(
                string id,
                AppointmentSorting sorting,
                int CurrentPage,
                int appointmentsPerPage);

        IEnumerable<AppointmentServiceModel> GetAppointments(string id);

        AppointmentServiceModel GetAppointment(string id);

        void ChangeApprovalStatus(string appointmentId);
    }
}
