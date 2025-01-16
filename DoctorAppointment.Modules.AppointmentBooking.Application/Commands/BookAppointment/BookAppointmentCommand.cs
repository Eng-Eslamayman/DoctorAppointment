using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace DoctorAppointment.Modules.AppointmentBooking.Application.Commands.BookAppointment
{
    public record BookAppointmentCommand(Guid SlotId, Guid PatientId, string PatientName)
        : IRequest<Guid>;
}
