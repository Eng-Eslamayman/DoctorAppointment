using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Modules.AppointmentBooking.PublicApi
{
    public class Appointment
    {
        public Guid Id { get; private set; }
        public Guid SlotId { get; private set; }
        public Guid PatientId { get; private set; }
        public string? PatientName { get; private set; }
        public DateTime ReservedAt { get; private set; }
        public bool IsCompleted { get; set; }
        public bool IsCancelled { get; set; }
    }
}
