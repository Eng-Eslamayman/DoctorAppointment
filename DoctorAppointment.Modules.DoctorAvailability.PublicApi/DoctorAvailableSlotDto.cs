namespace DoctorAppointment.Modules.DoctorAvailability.PublicApi;

public class DoctorAvailableSlotDto
{
    public int DoctorId { get; set; }
    public string DoctorName { get; set; }
    public List<AvailableSlotDto> AvailableSlots { get; set; }
}