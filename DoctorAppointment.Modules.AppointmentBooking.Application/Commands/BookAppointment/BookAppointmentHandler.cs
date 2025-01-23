using DoctorAppointment.Modules.AppointmentBooking.Application.Exceptions;
using DoctorAppointment.Modules.AppointmentBooking.Domain.Appointment;
using DoctorAppointment.Modules.AppointmentConfirmation.Infrastructure.Services;
using DoctorAppointment.Modules.DoctorAvailability.PublicApi;
using MediatR;

namespace DoctorAppointment.Modules.AppointmentBooking.Application.Commands.BookAppointment
{
    public class BookAppointmentHandler(IAppointmentRepository appointmentRepository, ISlotApi slotApi, NotificationService notificationService) : IRequestHandler<BookAppointmentCommand, Guid>
    {
        public async Task<Guid> Handle(BookAppointmentCommand request, CancellationToken cancellationToken)
        {
            var slot = await slotApi.GetAsync(request.SlotId);

            if (slot is null)
                throw new Exception("Slot not available");

            var appointment = Appointment.Create(
                Guid.NewGuid(),
                request.SlotId,
                Guid.NewGuid(),
                request.PatientName,
                DateTime.UtcNow
            );

            await appointmentRepository.AddAsync(appointment);

            notificationService.SendConfirmation(appointment.PatientName, slot);

            return appointment.Id;
        }
    }
}
