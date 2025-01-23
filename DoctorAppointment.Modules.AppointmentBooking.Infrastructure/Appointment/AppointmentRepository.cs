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

        public IEnumerable<Domain.Appointment.Appointment> GetAll()
        {
            return _appointments;
        }

        public Domain.Appointment.Appointment? GetById(Guid id)
        {
            var appointment = _appointments.SingleOrDefault(a => a.Id == id)!;
            return appointment;
        }

        public void Update(Domain.Appointment.Appointment appointment)
        {
            var existingAppointment = _appointments.FirstOrDefault(a => a.Id == appointment.Id);

            if (existingAppointment != null)
            {
                existingAppointment.IsCompleted = appointment.IsCompleted;
                existingAppointment.IsCancelled = appointment.IsCancelled;
            }
            else
            {
                throw new Exception("Appointment not found.");
            }
        }
    }
}
