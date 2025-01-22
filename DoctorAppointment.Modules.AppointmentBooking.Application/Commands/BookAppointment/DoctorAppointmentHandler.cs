using DoctorAppointment.Modules.AppointmentBooking.Application.Exceptions;
using DoctorAppointment.Modules.AppointmentBooking.Domain.Appointment;
using DoctorAppointment.Modules.DoctorAvailability.PublicApi;
using MediatR;

namespace DoctorAppointment.Modules.AppointmentBooking.Application.Commands.BookAppointment
{
    public class DoctorAppointmentHandler(IAppointmentRepository appointmentRepository) : IRequestHandler<BookAppointmentCommand, Guid>
    {
        public async Task<Guid> Handle(BookAppointmentCommand request, CancellationToken cancellationToken)
        {
            var appointment = Appointment.Create(
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
                request.PatientName,
                DateTime.UtcNow
            );

            await appointmentRepository.AddAsync(appointment);
            return appointment.Id;
        }
    }
}
