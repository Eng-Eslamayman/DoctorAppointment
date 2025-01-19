using DoctorAppointment.Modules.DoctorAvailability.Domain;
using TraditionalData;

namespace DoctorAppointment.Modules.DoctorAvailability.PublicApi;

public interface ISlotsApi
{
    Slot GetAsync(Guid slotId);
}
