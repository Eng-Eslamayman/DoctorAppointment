using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraditionalData;

namespace TraditionalService.Abstracts
{
    public interface IDoctorAvailabilityService:IScopedService
    {
        IEnumerable<Slot> GetAvailableSlots();
        Slot AddSlot(Slot slot);
    }
}
