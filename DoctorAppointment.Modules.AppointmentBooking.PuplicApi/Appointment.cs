using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Modules.AppointmentBooking.PublicApi
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public Guid SlotId { get; set; }
        public Guid PatientId { get; set; }
        public string? PatientName { get; set; }
        public DateTime ReservedAt { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsCancelled { get; set; }
    }
}
