using DoctorAppointment.Modules.AppointmentBooking.Domain.Appointment;

namespace DoctorAppointment.Modules.AppointmentBooking.Infrastructure.Appointment
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private static List<Domain.Appointment.Appointment> _appointments = new();

        public Task AddAsync(Domain.Appointment.Appointment appointment)
        { 
             _appointments.Add(appointment);
             return Task.CompletedTask;
        }

        public async Task<Domain.Appointment.Appointment?> GetByIdAsync(Guid id)
        {
            
            return _appointments.SingleOrDefault(a => a.Id == id);
        }
    }
}
