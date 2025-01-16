using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Modules.AppointmentBooking.Domain.Slot
{
    public interface ISlotRepository
    {
        Task GetAllAsync();
    }
}
