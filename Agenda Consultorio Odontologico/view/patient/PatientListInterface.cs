using Agenda_Consultorio_Odontologico.model;

namespace Agenda_Consultorio_Odontologico.view.patientInterface
{
    public class PatientListInterface
    {
        public void Title()
        {
            Console.WriteLine("Lista de paciente \n");
        }
        public void Header()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("CPF          Nome                       Dt.Nasc.     Idade");
            Console.WriteLine("----------------------------------------------------------");
        }
        public void ShowPatientsList(Patient patient)
        {
            string cpf = patient.CPF.ToString("00000000000");
            string name = patient.Name;
            string birth = patient.BirthDate.ToString("dd/MM/yyyy");
            string age = patient.Age.ToString();
            Console.WriteLine(cpf.PadRight(13) + name.PadRight(27)+birth+age.PadLeft(6));
            foreach(Appointment appointment in Appointment.AppointmentList)
            {
                if(appointment.Patient == patient && appointment.Date >= DateTime.Today)
                {
                    string date = appointment.Date.ToString("dd/MM/yyyy");
                    string start = appointment.Start.ToString("0000");
                    string end = appointment.End.ToString("0000");
                    Console.WriteLine("             Agendado para: "+date);
                    Console.WriteLine("             "+start+" às "+end);
                }
            }
        }
        public void Footer()
        {
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
