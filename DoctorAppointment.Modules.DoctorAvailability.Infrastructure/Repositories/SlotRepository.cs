using DoctorAppointment.Modules.DoctorAvailability.Domain;

namespace DoctorAppointment.Modules.DoctorAvailability.Infrastructure.Repositories;

public class SlotRepository : ISlotRepository
{
    private readonly List<Slot> _slots = new();

    public Task<List<Slot>> GetAllSlots() => Task.FromResult(_slots);

    public Task<Slot> AddSlot(Slot slot)
    {
        _slots.Add(slot);
        return Task.FromResult(slot);
    }
}