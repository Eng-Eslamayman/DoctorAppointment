using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraditionalData;

namespace TraditionalService.Implementations
{
    public class NotificationService
    {
        public void SendConfirmation(Appointment appointment)
        {
            Console.WriteLine($"Confirmation: Appointment for {appointment.PatientName} with Doctor at {appointment.ReservedAt}.");
        }
    }

}
