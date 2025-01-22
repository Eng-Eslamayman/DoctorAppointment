using DoctorAppointment.Modules.DoctorAvailability.PublicApi;
using MediatR;

namespace DoctorAppointment.Modules.AppointmentBooking.Application.Query.GetAllAvailableSlots;

public class GetAllAvailableSlotsHandler(ISlotApi slotApi) :
    IRequestHandler<GetAllAvailableSlotsQuery, IEnumerable<DoctorAvailableSlotDto>>
{
    public Task<IEnumerable<DoctorAvailableSlotDto>> Handle(GetAllAvailableSlotsQuery request, CancellationToken cancellationToken)
    {
        return slotApi.GetAvailableSlots();
    }
}