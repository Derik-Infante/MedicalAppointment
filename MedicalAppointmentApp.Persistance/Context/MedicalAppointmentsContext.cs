
using MedicalAppointmentApp.Domain.Entities.System;
using Microsoft.EntityFrameworkCore;


namespace MedicalAppointmentApp.Persistance.Context
{
    public partial class MedicalAppointmentsContext : DbContext
    {
        public MedicalAppointmentsContext(DbContextOptions<MedicalAppointmentsContext> options) : base(options)
        {

        }

        #region "System Entities"
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Status> Status { get; set; }
        #endregion
    }
}