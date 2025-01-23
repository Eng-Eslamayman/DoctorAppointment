namespace DoctorAppointment.Modules.DoctorAvailability.PublicApi;

public interface ISlotApi
{
    Task<Slot> GetAsync(Guid slotId);

    Task<IEnumerable<DoctorAvailableSlotDto>> GetAvailableSlots();
}