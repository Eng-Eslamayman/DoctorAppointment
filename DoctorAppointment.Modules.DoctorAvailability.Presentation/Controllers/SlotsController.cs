using DoctorAppointment.Modules.DoctorAvailability.Application.Services;
using DoctorAppointment.Modules.DoctorAvailability.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.Modules.DoctorAvailability.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SlotsController : ControllerBase
    {
        private readonly ISlotService _slotService;

        public SlotsController(ISlotService slotService)
        {
            _slotService = slotService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAvailableSlots()
        {
            var slots = await _slotService.GetAvailableSlots();
            return Ok(slots);
        }

        [HttpPost]
        public async Task<IActionResult> AddSlot(Slot slot)
        {
            var addedSlot = await _slotService.AddSlot(slot);
            return Ok(addedSlot);
        }
    }
}
