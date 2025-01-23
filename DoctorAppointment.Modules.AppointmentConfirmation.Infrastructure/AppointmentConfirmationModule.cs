using DoctorAppointment.Modules.AppointmentConfirmation.Infrastructure.Services;
using DoctorAppointment.Modules.DoctorAvailability.PublicApi;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorAppointment.Modules.AppointmentConfirmation.Infrastructure;

public static class DoctorAvailabilityModule
{
    public static IServiceCollection AddAppointmentConfirmationModule(
        this IServiceCollection services)
    {
        services.AddInfrastructure();
        return services;
    }

    private static void AddInfrastructure(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<NotificationService>();
    }
}