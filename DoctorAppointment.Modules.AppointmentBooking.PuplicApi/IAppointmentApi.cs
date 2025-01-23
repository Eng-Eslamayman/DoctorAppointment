using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Modules.AppointmentBooking.PublicApi
{
    public interface IAppointmentApi
    {
        IEnumerable<Appointment> GetUpcomingAppointments();
        Appointment? GetById(Guid id);
    }
}
