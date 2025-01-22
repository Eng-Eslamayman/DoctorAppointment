using DoctorAppointment.Modules.DoctorAvailability.Domain;

namespace DoctorAppointment.Modules.DoctorAvailability.DAL.Repositories.Interfaces
{
    public interface ISlotRepository
    {
        IEnumerable<Slot> GetAvailableSlots();
        Task<Slot> AddSlot(Slot slot);
        Task<Slot?> GetAsync(Guid slotId);
    }
}
