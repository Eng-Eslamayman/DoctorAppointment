using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace DoctorAppointment.Modules.AppointmentBooking.Application.Commands.BookAppointment
{
    public class BookAppointmentHandler: IRequestHandler<BookAppointmentCommand,Guid>
    {
        public Task<Guid> Handle(BookAppointmentCommand request, CancellationToken cancellationToken)
        {

            return null;
        }


    }
}
