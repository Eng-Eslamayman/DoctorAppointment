using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Modules.AppointmentBooking.Domain.Appointment;

public class Appointment
{
    private Appointment(Guid id, Guid slotId, Guid patientId, string patientName, DateTime reservedAt)
    {
        Id = id;
        SlotId = slotId;
        PatientId = patientId;
        PatientName = patientName;
        ReservedAt = reservedAt;
    }

    public static Appointment Create(Guid id, Guid slotId, Guid patientId, string patientName, DateTime reservedAt)
    {
        return new Appointment(id, slotId, patientId, patientName, reservedAt);
    }

    public Guid Id { get; private set; } 
    public Guid SlotId { get; private set; }
    public Guid PatientId { get; private set; }
    public string? PatientName { get; private set; }
    public DateTime ReservedAt { get; private set; }
}


