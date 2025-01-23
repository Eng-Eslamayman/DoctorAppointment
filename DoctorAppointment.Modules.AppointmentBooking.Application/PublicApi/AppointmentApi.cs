using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorAppointment.Modules.AppointmentBooking.Domain.Appointment;
using DoctorAppointment.Modules.AppointmentBooking.PublicApi;
using Appointment = DoctorAppointment.Modules.AppointmentBooking.PublicApi.Appointment;

namespace DoctorAppointment.Modules.AppointmentBooking.Application.PublicApi
{
    public class AppointmentApi(IAppointmentRepository appointmentRepository) : IAppointmentApi
    {
        public Appointment? GetById(Guid id)
        {
            var appointment = appointmentRepository.GetById(id);

            if (appointment is null)
                throw new Exception("appointment not found..");

            return new Appointment
            {
                Id = appointment.Id,
                SlotId = appointment.SlotId,
                PatientId = appointment.PatientId,
                PatientName = appointment.PatientName,
                IsCancelled = appointment.IsCancelled,
                IsCompleted = appointment.IsCompleted
            };

        }

        public IEnumerable<Appointment> GetUpcomingAppointments()
        {
            return appointmentRepository.GetAll().Where(a => !a.IsCompleted && !a.IsCancelled) as IEnumerable<Appointment>;
        }
    }
}
