using DoctorAppointment.Modules.DoctorAvailability.Domain;
using DoctorAppointment.Modules.DoctorAvailability.Infrastructure.Repositories;

namespace DoctorAppointment.Modules.DoctorAvailability.Application.Services;

public class SlotService : ISlotService
{
    private readonly ISlotRepository _slotRepository;

    public SlotService(ISlotRepository slotRepository)
    {
        _slotRepository = slotRepository;
    }

    public Task<List<Slot>> GetAvailableSlots() =>
        _slotRepository.GetAllSlots();

    public Task<Slot> AddSlot(Slot slot) =>
        _slotRepository.AddSlot(slot);
}