namespace Agenda_Consultorio_Odontologico.model
{
    public class AppointmentList
    {
        private List<Appointment>? appointments;

        public List<Appointment> Appointments
        {
            get { return appointments; }
            set { appointments = value; }
        }
    }
}
