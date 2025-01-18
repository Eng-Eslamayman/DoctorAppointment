
using Service.Repository_Layer_In_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraditionalData;
using TraditionalService.Abstracts;

namespace TraditionalService.Implementations
{
   

    public class DoctorAvailabilityService : IDoctorAvailabilityService
    {
        private readonly ISlotRepository _slotRepository;

        public DoctorAvailabilityService(ISlotRepository slotRepository)
        {
            _slotRepository = slotRepository;
        }

        public IEnumerable<Slot> GetAvailableSlots()
        {
            return _slotRepository.GetAvailableSlots();
        }

        public Slot AddSlot(Slot slot)
        {
            return _slotRepository.AddSlot(slot);
        }
    }

}
