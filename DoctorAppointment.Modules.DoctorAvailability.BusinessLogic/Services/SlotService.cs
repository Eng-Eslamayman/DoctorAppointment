using DoctorAppointment.Modules.DoctorAvailability.BusinessLogic.Services.Interfaces;
using DoctorAppointment.Modules.DoctorAvailability.DAL.Repositories.Interfaces;
using DoctorAppointment.Modules.DoctorAvailability.PublicApi;
using Slot = DoctorAppointment.Modules.DoctorAvailability.Domain.Slot;

namespace DoctorAppointment.Modules.DoctorAvailability.BusinessLogic.Services
{
    public class SlotService(ISlotRepository slotRepository) : ISlotService
    {
        public IEnumerable<Slot> GetAvailableSlots() => slotRepository.GetAvailableSlots();
        public Task<Slot> AddAsync(Slot slot) =>
            slotRepository.AddSlot(slot);

        public Task<Slot> GetAsync(Guid slotId) => slotRepository.GetAsync(slotId);

        public async Task<IEnumerable<DoctorAvailability.PublicApi.DoctorAvailableSlotDto>> GetAvailableSlotsGroupedByDoctor()
        {
            var availableSlots = slotRepository.GetAvailableSlots();

            var groupedSlots = availableSlots
                .GroupBy(slot => new { slot.DoctorId, slot.DoctorName })
                .Select(group => new DoctorAvailableSlotDto
                {
                    DoctorId = group.Key.DoctorId.GetHashCode(),
                    DoctorName = group.Key.DoctorName,
                    AvailableSlots = group
                        .Select(slot => new AvailableSlotDto { DateTime = slot.Time })
                        .ToList()
                })
                .ToList();

            return await Task.FromResult(groupedSlots);
        }
    }
}
