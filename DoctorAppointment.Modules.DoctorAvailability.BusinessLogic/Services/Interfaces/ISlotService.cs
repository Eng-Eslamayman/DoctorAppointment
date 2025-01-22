using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorAppointment.Modules.DoctorAvailability.Domain;
using DoctorAppointment.Modules.DoctorAvailability.PublicApi;
using Slot = DoctorAppointment.Modules.DoctorAvailability.Domain.Slot;

namespace DoctorAppointment.Modules.DoctorAvailability.BusinessLogic.Services.Interfaces
{
    public interface ISlotService
    {
        IEnumerable<Slot> GetAvailableSlots();
        Task<IEnumerable<DoctorAvailability.PublicApi.DoctorAvailableSlotDto>> GetAvailableSlotsGroupedByDoctor();
        Task<Slot> AddAsync(Slot slot);
        Task<Slot> GetAsync(Guid slotId);
    }
}
