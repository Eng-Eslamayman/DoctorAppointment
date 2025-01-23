namespace DoctorAppointment.Modules.DoctorAvailability.PublicApi;

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
    public static DateTime? Time { get; set; }
    public Guid DoctorId { get; set; }
    public static string? DoctorName { get; set; }
    public bool IsReserved { get; set; }
    public decimal Cost { get; set; }
}