using DoctorAppointment.Modules.AppointmentBooking.Application.Query.GetAllAvailableSlots;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.Modules.AppointmentBooking.Presentation.Controllers
{
    [ApiController]
    [Route("api/availableSlots")]
    public class GetAvailableSlotsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> ShowAvailableSlots()
        {
            var slots = await mediator.Send(new GetAllAvailableSlotsQuery());

            if(!slots.Any())
                return NotFound();

            return Ok(slots);
        }
    }
}
