using DoctorAppointment.Modules.DoctorAvailability.BusinessLogic.PublicApi;
using DoctorAppointment.Modules.DoctorAvailability.BusinessLogic.Services;
using DoctorAppointment.Modules.DoctorAvailability.BusinessLogic.Services.Interfaces;
using DoctorAppointment.Modules.DoctorAvailability.DAL.Repositories;
using DoctorAppointment.Modules.DoctorAvailability.DAL.Repositories.Interfaces;
using DoctorAppointment.Modules.DoctorAvailability.PublicApi;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorAppointment.Modules.DoctorAvailability.BusinessLogic;

public static class DoctorAvailabilityModule
{
    public static IServiceCollection AddDoctorAvailabilityModule(
        this IServiceCollection services)
    {
        services.AddInfrastructure();
        return services;
    }

    private static void AddInfrastructure(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ISlotRepository, SlotRepository>();
        serviceCollection.AddScoped<ISlotService, SlotService>();
        serviceCollection.AddScoped<ISlotApi, SlotApi>();
    }
}