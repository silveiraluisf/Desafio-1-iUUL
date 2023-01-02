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
            Console.WriteLine($"{patient.CPF.ToString("00000000000")}  {patient.Name}  {patient.BirthDate.ToString("dd/MM/yyyy")}   {patient.Age}");
            Console.WriteLine("             Agendado para: 99/99/9999");
            Console.WriteLine("             HH:MM às HH:MM\n");
        }
        public void Footer()
        {
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
