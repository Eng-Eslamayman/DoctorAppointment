using System.Reflection;
using DoctorAppointment.Modules.AppointmentBooking.Application;
using DoctorAppointment.Modules.AppointmentBooking.Infrastructure;
using DoctorAppointment.Modules.AppointmentConfirmation.Infrastructure;
using DoctorAppointment.Modules.DoctorAvailability.BusinessLogic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDoctorAvailabilityModule();
builder.Services.AddAppointmentModule();
builder.Services.AddAppointmentConfirmationModule();
builder.Services.AddAppointmentBookingModule();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
