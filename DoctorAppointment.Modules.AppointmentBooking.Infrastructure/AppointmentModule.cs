using DoctorAppointment.Modules.AppointmentBooking.Domain.Appointment;
using DoctorAppointment.Modules.AppointmentBooking.Infrastructure.Appointment;
using DoctorAppointment.Modules.DoctorAvailability.BusinessLogic.PublicApi;
using DoctorAppointment.Modules.DoctorAvailability.PublicApi;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorAppointment.Modules.AppointmentBooking.Infrastructure;

public static class AppointmentModule
{
    public static IServiceCollection AddAppointmentModule(
        this IServiceCollection services)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssemblies(Application.AssemblyReference.Assembly);

            
        });
        services.AddInfrastructure();
        return services;
    }

    private static void AddInfrastructure(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IAppointmentRepository, AppointmentRepository>();
        serviceCollection.AddScoped<ISlotApi, SlotApi>();
    }
}