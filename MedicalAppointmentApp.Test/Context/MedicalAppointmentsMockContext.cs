

using Microsoft.EntityFrameworkCore;
using MedicalAppointmentApp.Persistance.Context;

namespace MedicalAppointmentApp.Test.Context
{
    public class MedicalAppointmentsMockContext : MedicalAppointmentsContext
    {
        public MedicalAppointmentsMockContext(DbContextOptions<MedicalAppointmentsContext> options): base(options)
        {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("bolectodb");
        }
    }
}
