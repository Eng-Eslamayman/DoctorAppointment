using DoctorAppointment.Modules.DoctorAvailability.BusinessLogic.Services.Interfaces;
using DoctorAppointment.Modules.DoctorAvailability.PublicApi;
using Slot = DoctorAppointment.Modules.DoctorAvailability.PublicApi.Slot;

namespace DoctorAppointment.Modules.DoctorAvailability.BusinessLogic.PublicApi
{
    public class SlotApi(ISlotService slotService) : ISlotApi
    {
        public async Task<Slot> GetAsync(Guid slotId)
        {
            var result = await slotService.GetAsync(slotId);

            if (result == null || result.IsReserved)
            {
                throw new Exception("The slot is unavailable or already reserved.");
            }

            return new Slot(
                result.Id,
                result.Time,
                result.DoctorId,
                result.DoctorName,
                result.IsReserved,
                result.Cost
            );
        }

        public Task<IEnumerable<DoctorAvailableSlotDto>> GetAvailableSlots()
        {
            return slotService.GetAvailableSlotsGroupedByDoctor();
        }
    }
}
