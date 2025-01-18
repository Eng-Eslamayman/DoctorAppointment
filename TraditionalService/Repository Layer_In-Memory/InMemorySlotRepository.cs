using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraditionalData;

namespace TraditionalService.Repository_Layer_In_Memory
{
    public class InMemorySlotRepository : ISlotRepository
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
    }
}
