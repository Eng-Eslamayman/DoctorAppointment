using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorAppointment.Modules.DoctorAvailability.Domain;

namespace DoctorAppointment.Modules.DoctorAvailability.Infrastructure.Repositories
{
    public interface ISlotRepository
    {
        Task<List<Slot>> GetAllSlots();
        Task<Slot> AddSlot(Slot slot);
    }
}
