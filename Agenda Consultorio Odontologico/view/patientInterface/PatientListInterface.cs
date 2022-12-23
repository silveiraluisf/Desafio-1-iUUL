using Agenda_Consultorio_Odontologico.model;

namespace Agenda_Consultorio_Odontologico.view.patientInterface
{
    public class PatientListInterface
    {
        public void Title()
        {
            Console.WriteLine("Lista de paciente \n");
        }
        public void ShowPatientsList(Patient patient)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("              -- CPF Nome Dt.Nasc. Idade");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"-- {patient.CPF.ToString("00000000000")} {patient.Name} {patient.BirthDate.ToString("dd/MM/yyyy")}");
            Console.WriteLine("            999 Agendado para: 99/99/9999");
            Console.WriteLine("            HH:MM às HH:MM");
            Console.WriteLine("99999999999   yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy  99/99/9999");
            Console.WriteLine("999      99999999999      zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");
            Console.WriteLine("99/99/9999               999                   99999999999");
            Console.WriteLine("wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww       99/99/9999      999");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
