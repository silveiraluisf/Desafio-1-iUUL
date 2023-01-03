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
            foreach(Appointment appointment in Appointment.AppointmentList)
            {
                if(appointment.Patient == patient && appointment.Date >= DateTime.Today)
                {
                    Console.WriteLine($"             Agendado para: {appointment.Date.ToString("dd/MM/yyyy")}");
                    Console.WriteLine($"             {appointment.Start} às {appointment.End}");
                }
            }
        }
        public void Footer()
        {
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
