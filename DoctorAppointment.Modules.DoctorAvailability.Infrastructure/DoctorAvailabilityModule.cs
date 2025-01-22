//using DoctorAppointment.Modules.DoctorAvailability.DAL.Repositories;
//using DoctorAppointment.Modules.DoctorAvailability.DAL.Repositories.Interfaces;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//namespace DoctorAppointment.Modules.DoctorAvailability.DAL;

//public class DoctorAvailabilityModule
//{
//    public static IServiceCollection AddEventsModule(
//        this IServiceCollection services,
//        IConfiguration configuration)
//    {
//        services.AddInfrastructure(configuration);

//        return services;
//    }

//    private static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
//    {
//        services.AddScoped<ISlotRepository, InMemorySlotRepository>();
//    }
//}