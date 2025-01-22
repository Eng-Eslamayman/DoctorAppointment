namespace DoctorAppointment.Modules.AppointmentBooking.Application.Exceptions;

public class SlotUnavailableException(string message) : Exception(message);