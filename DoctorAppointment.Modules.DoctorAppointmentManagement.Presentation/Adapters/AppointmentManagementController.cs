using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorAppointment.Modules.AppointmentBooking.PublicApi;

namespace DoctorAppointment.Modules.DoctorAppointmentManagement.Presentation.Adapters
{
    [ApiController]
    [Route("api/appointmentManagement")]
    public class AppointmentManagementController(IAppointmentApi appointmentApi) : ControllerBase
    {
        private readonly IAppointmentApi _appointmentApi = appointmentApi;

        [HttpGet("upcoming")]
        public IActionResult GetUpcomingAppointments()
        {
            var appointments = _appointmentApi.GetUpcomingAppointments();
            return Ok(appointments);
        }

        [HttpPost("complete/{id}")]
        public IActionResult MarkAsCompleted(Guid id)
        {
            var appointment = _appointmentApi.GetById(id);

            if (appointment is null)
                return BadRequest();

            appointment.IsCompleted = true;

            return Ok(appointment.Id);
        }

        [HttpPost("cancel/{id}")]
        public IActionResult CancelAppointment(Guid id)
        {
            var appointment = _appointmentApi.GetById(id);

            if (appointment is null)
                return BadRequest();

            appointment.IsCancelled = true;

            return Ok(appointment.Id);
        }
    }
}
