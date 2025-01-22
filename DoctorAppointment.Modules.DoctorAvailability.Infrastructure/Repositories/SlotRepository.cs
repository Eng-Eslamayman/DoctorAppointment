using DoctorAppointment.Modules.DoctorAvailability.DAL.Repositories.Interfaces;
using DoctorAppointment.Modules.DoctorAvailability.Domain;

namespace DoctorAppointment.Modules.DoctorAvailability.DAL.Repositories;

public class SlotRepository : ISlotRepository
{
    private static List<Slot> _slots = new();

    public IEnumerable<Slot> GetAvailableSlots()
    {
        var slots = _slots.Where(s => !s.IsReserved);
        return slots;
    }

    public Task<Slot> AddSlot(Slot slot)
    {
        _slots.Add(slot);
        return Task.FromResult(slot);
    }

    public Task<Slot?> GetAsync(Guid slotId) => Task.FromResult(_slots.SingleOrDefault(s => s.Id == slotId));
}