
using MedicalAppointmentApp.Domain.Entities.System;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace MedicalAppointmentApp.Persistance.Context
{
    public partial class MedicalAppointmentsContext : DbContext
    {
        public MedicalAppointmentsContext(DbContextOptions<MedicalAppointmentsContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Agregué esta línea para configurar el comportamiento del esquema en MySQL
            optionsBuilder.UseMySql("Server=localhost;Database=sistema;User ID=root;Password=062403",
                new MySqlServerVersion(new Version(8, 4, 2)),
                mysqlOptions => mysqlOptions.SchemaBehavior(MySqlSchemaBehavior.Ignore));
        }

        #region "System Entities"
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Status> Status { get; set; }
        #endregion

        
    }
}