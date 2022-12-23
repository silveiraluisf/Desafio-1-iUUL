using Agenda_Consultorio_Odontologico.model;

namespace Agenda_Consultorio_Odontologico.view.appointmentInterface
{
    public class AppointmentListInterface
    {
        public void Title()
        {
            Console.WriteLine("Lista de agendamentos \n");
        }
        public void ShowAppointmentsList(Appointment appointment)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("          -- Data   H.Ini   H.Fim   Tempo   Nome   Dt.Nac ");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"-- {appointment.Date} {appointment.Start} {appointment.End} {appointment.Patient.Name}");
            Console.WriteLine("            99/99/9999 08:15 09:00 00:45 yyyyyyyyyyyyyyyyyyyyy");
            Console.WriteLine("            99/99/9999");
            Console.WriteLine("10:00 11:30 01:30 zzzzzzzzzzzzzzzzzzzzz 99/99/9999");
            Console.WriteLine("03/01/2022 10:15 12:15 02:00 wwwwwwwwwwwwwwwwwwwww");
            Console.WriteLine("99/99/9999 05/01/2022 14:30 15:15 00:45");
            Console.WriteLine("rrrrrrrrrrrrrrrrrrrrr 99/99/9999 16:45 19:00 02:15");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxx 99/99/9999");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
