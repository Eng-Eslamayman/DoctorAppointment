using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Modules.AppointmentBooking.Domain.Appointment
{
    public interface IAppointmentRepository
    { 
        Task AddAsync(Appointment appointment);
        Task<Appointment> GetByIdAsync(Guid id);
    }
}
