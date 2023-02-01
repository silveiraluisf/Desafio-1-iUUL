using Agenda_Consultorio_Odontologico.model;
using Microsoft.EntityFrameworkCore;

namespace Agenda_Consultorio_Odontologico
{
    internal class ConsultorioContext : DbContext 
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ConsultorioDB;Trusted_Connection=true;");
        }
    }
}