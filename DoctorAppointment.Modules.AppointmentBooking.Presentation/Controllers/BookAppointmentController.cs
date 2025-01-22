using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorAppointment.Modules.AppointmentBooking.Application.Commands.BookAppointment;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.Modules.AppointmentBooking.Presentation.Controllers
{
    [ApiController]
    [Route("api/bookAppointment")]
    public class BookAppointmentController(IMediator mediator): ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Book(string patientName)
        {
            var book = await mediator.Send(new BookAppointmentCommand(patientName));

            return Ok(book);
        }
    }
}
