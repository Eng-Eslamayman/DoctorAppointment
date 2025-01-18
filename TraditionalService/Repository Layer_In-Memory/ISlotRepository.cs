
using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraditionalData;

namespace TraditionalService.Repository_Layer_In_Memory
{
    public interface ISlotRepository:IScopedService
    {
        IEnumerable<Slot> GetAvailableSlots();
        Slot AddSlot(Slot slot);
    }
}
