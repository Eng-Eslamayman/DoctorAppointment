using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Modules.AppointmentBooking.Domain.Appointment;

public class Appointment(Guid slotId, Guid patientId, string patientName, DateTime reservedAt)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Guid SlotId { get; private set; } = slotId;
    public Guid PatientId { get; private set; } = patientId;
    public string? PatientName { get; private set; } = patientName;
    public DateTime ReservedAt { get; private set; } = reservedAt;
}

