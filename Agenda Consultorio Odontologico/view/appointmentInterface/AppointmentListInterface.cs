using Agenda_Consultorio_Odontologico.model;

namespace Agenda_Consultorio_Odontologico.view.appointmentInterface
{
    public class AppointmentListInterface
    {
        public void Title()
        {
            Console.WriteLine("Lista de agendamentos \n");
        }
        public void Header()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("   Data        H.Ini  H.Fim   Tempo   Nome           Dt.Nac    ");
            Console.WriteLine("---------------------------------------------------------------");
        }
        public void ShowAppointmentsList(Appointment appointment)
        {
            Console.WriteLine($"-- {appointment.Date.ToString("dd/MM/yyyy")}  {appointment.Start.ToString("0000")}   {appointment.End.ToString("0000")}    {appointment.Time} min  {appointment.Patient.Name}  {appointment.Patient.BirthDate.ToString("dd/MM/yyyy")}\n");
        }
        public void Footer()
        {
            Console.WriteLine("---------------------------------------------------------------");
        }
    }
}
