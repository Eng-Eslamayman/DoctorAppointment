using DoctorAppointment.Modules.DoctorAvailability.Domain;

namespace DoctorAppointment.Modules.DoctorAvailability.Application.Services;

public interface ISlotService
{
    Task<List<Slot>> GetAvailableSlots();
    Task<Slot> AddSlot(Slot slot);
}