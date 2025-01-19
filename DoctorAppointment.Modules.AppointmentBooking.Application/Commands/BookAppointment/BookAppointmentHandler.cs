using DoctorAppointment.Modules.AppointmentBooking.Domain.Appointment;
using DoctorAppointment.Modules.DoctorAvailability.PublicApi;
using MediatR;

namespace DoctorAppointment.Modules.AppointmentBooking.Application.Commands.BookAppointment
{
    public class BookAppointmentHandler(ISlotsApi slotsApi, IAppointmentRepository appointmentRepository) : IRequestHandler<BookAppointmentCommand, Guid>
    {
        public async Task<Guid> Handle(BookAppointmentCommand request, CancellationToken cancellationToken)
        {
            var slot = slotsApi.GetAsync(request.SlotId);

            if (slot == null)
            {
                throw new Exception("Slot is unavailable.");
            }

            var appointment = Appointment.Create(
                Guid.NewGuid(),
                request.SlotId,
                request.PatientId,
                request.PatientName,
                DateTime.UtcNow
            );

            slot.IsReserved = true;  
            await appointmentRepository.AddAsync(appointment);
            return appointment.Id;
        }
    }
}
