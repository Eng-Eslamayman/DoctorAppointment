using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorAppointment.Modules.DoctorAvailability.PublicApi;
using TraditionalData;
using Slot = TraditionalData.Slot;

namespace TraditionalService.Repository_Layer_In_Memory
{
    public class InMemorySlotRepository : ISlotRepository, ISlotsApi
    {
        private readonly List<Slot> _slots = new List<Slot>();

        public IEnumerable<Slot> GetAvailableSlots()
        {
            return _slots.Where(s => !s.IsReserved);
        }

        public Slot AddSlot(Slot slot)
        {
            _slots.Add(slot);
            return slot;
        }

        public Slot GetAsync(Guid slotId)
        {
            var slot = _slots.Find(s => s.Id == slotId);

            if (slot is null)
                throw new Exception("slot is null");

            return slot;
        }
    }
}
