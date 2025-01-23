using DoctorAppointment.Modules.AppointmentBooking.Application.PublicApi;
using DoctorAppointment.Modules.AppointmentBooking.PublicApi;
using DoctorAppointment.Modules.AppointmentConfirmation.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorAppointment.Modules.AppointmentBooking.Application;

public static class AppointmentBookingModule
{
    public static IServiceCollection AddAppointmentBookingModule(
        this IServiceCollection services)
    {
        services.AddInfrastructure();
        return services;
    }

    private static void AddInfrastructure(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IAppointmentApi,AppointmentApi>();
    }
}