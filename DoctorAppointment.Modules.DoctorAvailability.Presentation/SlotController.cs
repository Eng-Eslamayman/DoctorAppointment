using DoctorAppointment.Modules.DoctorAvailability.BusinessLogic.Services.Interfaces;
using DoctorAppointment.Modules.DoctorAvailability.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.Modules.DoctorAvailability.Presentation
{
    [ApiController]
    [Route("api/slots")]
    public class SlotController(ISlotService slotService) : ControllerBase
    {
        [HttpGet("slots")]
        public IActionResult GetAvailableSlots()
        {
            var slots = slotService.GetAvailableSlots();

            if(!slots.Any())
                return NotFound();  

            return Ok(slots);
        }

        [HttpPost("slots")]
        public async Task<IActionResult> AddSlot([FromForm] SlotDto slotDto)
        {
            var createdSlot = await slotService.AddAsync(slotDto);
            return Ok(createdSlot.Id);
        }
    }
}