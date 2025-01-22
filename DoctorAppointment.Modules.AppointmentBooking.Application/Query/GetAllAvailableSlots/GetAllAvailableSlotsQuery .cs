using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorAppointment.Modules.DoctorAvailability.PublicApi;
using MediatR;

namespace DoctorAppointment.Modules.AppointmentBooking.Application.Query.GetAllAvailableSlots
{
    public class GetAllAvailableSlotsQuery: IRequest<IEnumerable<DoctorAvailableSlotDto>>
    {
    }
}
