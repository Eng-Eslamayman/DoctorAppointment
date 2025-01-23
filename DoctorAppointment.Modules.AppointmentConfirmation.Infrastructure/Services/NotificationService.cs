using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorAppointment.Modules.AppointmentBooking.PublicApi;
using DoctorAppointment.Modules.DoctorAvailability.PublicApi;

namespace DoctorAppointment.Modules.AppointmentConfirmation.Infrastructure.Services
{
    public class NotificationService
    {
        public void SendConfirmation(string patientName, Slot slot)
        {
            Console.WriteLine($"Appointment Confirmed: {patientName} with Dr. {Slot.DoctorName} at {Slot.Time}");
        }
    }
}
