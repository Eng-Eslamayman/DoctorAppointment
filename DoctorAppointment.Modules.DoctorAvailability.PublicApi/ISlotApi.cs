namespace DoctorAppointment.Modules.DoctorAvailability.PublicApi;

public interface ISlotApi
{
    Task<Slot> GetAsync(Guid slotId);

    Task<IEnumerable<DoctorAvailableSlotDto>> GetAvailableSlots();
}

public class Slot
{
    public Slot(Guid id, DateTime time, Guid doctorId, string doctorName, bool isReserved, decimal cost)
    {
        Id = Guid.NewGuid();
        Time = time;
        DoctorId = doctorId;
        DoctorName = doctorName;
        IsReserved = false;
        Cost = cost;
    }

    public Guid Id { get; set; }
    public DateTime Time { get; set; }
    public Guid DoctorId { get; set; }
    public string DoctorName { get; set; }
    public bool IsReserved { get; set; }
    public decimal Cost { get; set; }
}

public class DoctorAvailableSlotDto
{
    public int DoctorId { get; set; }
    public string DoctorName { get; set; }
    public List<AvailableSlotDto> AvailableSlots { get; set; }
}
public class AvailableSlotDto
{
    public DateTime DateTime { get; set; }
}