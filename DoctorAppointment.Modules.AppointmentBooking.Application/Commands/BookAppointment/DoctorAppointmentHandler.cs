using DoctorAppointment.Modules.AppointmentBooking.Application.Exceptions;
using DoctorAppointment.Modules.AppointmentBooking.Domain.Appointment;
using DoctorAppointment.Modules.DoctorAvailability.PublicApi;
using MediatR;

namespace DoctorAppointment.Modules.AppointmentBooking.Application.Commands.BookAppointment
{
    public class DoctorAppointmentHandler(ISlotApi slotsApi, IAppointmentRepository appointmentRepository) : IRequestHandler<BookAppointmentCommand, Guid>
    {
        public async Task<Guid> Handle(BookAppointmentCommand request, CancellationToken cancellationToken)
        {
            var slot = await slotsApi.GetAsync(request.SlotId);
            

            if (slot == null || slot.IsReserved)
            {
                throw new SlotUnavailableException("The slot is unavailable or already reserved.");
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
