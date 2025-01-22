using DoctorAppointment.Modules.DoctorAvailability.BusinessLogic.Services.Interfaces;
using DoctorAppointment.Modules.DoctorAvailability.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.Modules.DoctorAvailability.Presentation
{
    [ApiController]
    [Route("api/slots")]
    public class SlotController(ISlotService slotService) : ControllerBase
    {
        // Constructor Injection

        [HttpGet("slots")]
        public IActionResult GetAvailableSlots()
        {
            var slots = slotService.GetAvailableSlots();
            return Ok(slots);
        }

        [HttpPost("slots")]
        public IActionResult AddSlot([FromBody] Slot slotDto)
        {
            var createdSlot = slotService.AddAsync(slotDto);
            return CreatedAtAction(nameof(GetAvailableSlots), new { id = createdSlot.Id }, createdSlot);
        }
    }
}