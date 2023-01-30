using Microsoft.EntityFrameworkCore;

namespace Agenda_Consultorio_Odontologico
{
    public class ConsultorioContext : DbContext 
    {
        public DbSet<model.Patient> Patients { get; set; }
        public DbSet<model.Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ConsultorioDB;Trusted_Connection=true;");
        }
    }
}