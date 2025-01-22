using DoctorAppointment.Modules.DoctorAvailability.DAL.Repositories.Interfaces;
using DoctorAppointment.Modules.DoctorAvailability.Domain;

namespace DoctorAppointment.Modules.DoctorAvailability.DAL.Repositories;

public class InMemorySlotRepository : ISlotRepository
{
    private readonly List<Slot> _slots = new();

    public IEnumerable<Slot> GetAvailableSlots()
    {
        return _slots.Where(s => !s.IsReserved);
    }

    public Task<Slot> AddSlot(Slot slot)
    {
        _slots.Add(slot);
        return Task.FromResult(slot);
    }

    public Task<Slot> GetAsync(Guid slotId) => Task.FromResult(_slots.SingleOrDefault(s => s.Id == slotId));
}