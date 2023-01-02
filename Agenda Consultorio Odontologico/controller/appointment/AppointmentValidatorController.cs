using Agenda_Consultorio_Odontologico.model;
using Agenda_Consultorio_Odontologico.view.appointmentInterface;
using System.Collections.Generic;

namespace Agenda_Consultorio_Odontologico.controller.appointmentControllers
{
    public class AppointmentValidatorController
    {
        AppointmentRegistrationInterface ari = new();
        AppointmentMenuInterface ami = new();
        DateTime date;
        int start;
        int end;
        Patient patient;

        public void AppointmentValidator()
        {
            ari.GetPatientCPF();
            ari.GetDate();
            ari.GetStart();
            ari.GetEnd();
            ari.ShowData();
            PatientCPFValidate();
            DateValidate();
            StartValidate();
            EndValidate();
            CheckFutureAppointment();
            CheckOverlappingAppointment();
            Appointment a = new(date, start, end, patient);
            ari.SuccessMessage();
        }
        public void PatientCPFValidate()
        {
            List<Patient> list = new();
            bool parseSuccess = long.TryParse(ari.InputPatientCPF, out long outputCPF);
            if (parseSuccess)
            {
                for (int i = 0; i < Patient.PatientList.Count; i++)
                {
                    Patient p = Patient.PatientList[i];
                    if (p.CPF == outputCPF)
                    {
                        list.Add(p);
                        patient = p;
                    }
                }
                if (list.Count == 0)
                {
                    Console.WriteLine("CPF não cadastrado"); //mensagem de erro temporária
                    ari.GetPatientCPF();
                    PatientCPFValidate();
                }
            }
            else
            {
                Console.WriteLine(" Favor insira um CPF válido (11 caracteres, apenas números)."); //mensagem de erro temporária
                ari.GetPatientCPF();
                PatientCPFValidate();
            }
        }
        public void DateValidate()
        {
            DateTime today = DateTime.Today;
            bool parseSuccess = DateTime.TryParse(ari.InputDate, out DateTime outputDate);
            if (parseSuccess)
            {
                if (outputDate >= today)
                {
                    date = outputDate;
                }
                else
                {
                    Console.WriteLine("A data não pode ser anterior à hoje!"); //mensagem de erro temporária 
                    ari.GetDate();
                    DateValidate();
                }
            }
            else
            {
                Console.WriteLine("Favor insira uma data no formato DD,MM,AAAA."); //mensagem de erro temporária 
                ari.GetDate();
                DateValidate();
            }
        }
        public void StartValidate()
        {
            if (ari.InputStart.Length > 0 && ari.InputStart.Length < 5)
            {
                bool parseSuccess = int.TryParse(ari.InputStart, out int outputStart);
                if (parseSuccess)
                {
                    if (outputStart > 0800 && outputStart < 1846)
                    {
                        start = outputStart;
                    }
                    else
                    {
                        Console.WriteLine("Horário digitado inválido ou fora do horário de atendimento!");
                        ari.GetStart();
                        StartValidate();
                    }
                }
            }
            else
            {
                Console.WriteLine("Favor digite um horário no formato 0900, 1345, 1730");
                ari.GetStart();
                StartValidate();
            }            
        }
        public void EndValidate()
        {
            if (ari.InputEnd.Length > 0 && ari.InputEnd.Length < 5)
            {
                bool parseSuccess = int.TryParse(ari.InputEnd, out int outputEnd);
                if (parseSuccess)
                {
                    if (outputEnd > start)
                    {
                        if (outputEnd > 0815 && outputEnd < 1901)
                        {
                            end = outputEnd;
                        }
                        else
                        {
                            ari.GetEnd();
                            EndValidate();
                            Console.WriteLine("Horário digitado inválido ou fora do horário de atendimento!");
                        }
                    }
                    else
                    {
                        ari.GetEnd();
                        EndValidate();
                        Console.WriteLine("A hora final não pode ser menor que a hora inicial!");
                    }
                }
            }
            else 
            {
                ari.GetEnd();
                EndValidate();
                Console.WriteLine("Favor digite um horário no formato 0900, 1345, 1730");
            }
        }
        public void CheckFutureAppointment()
        {
            for (int i = 0; i < Appointment.AppointmentList.Count; i++)
            {
                Appointment appointment = Appointment.AppointmentList[i];
                if (DateTime.Today.Day < appointment.Date.Day)
                {
                    if(appointment.Patient == patient)
                    {
                        Console.WriteLine("Não pode haver dois agendamentos futuros para um mesmo paciente!");
                        break;
                    }
                }
            }
        }
        public void CheckOverlappingAppointment()
        {
            for (int i = 0; i < Appointment.AppointmentList.Count; i++)
            {
                Appointment appointment = Appointment.AppointmentList[i];
                if (appointment.Date.Year == date.Year && appointment.Date.Month == date.Month && appointment.Date.Day == date.Day)
                {
                    if ((start >= appointment.Start && start < appointment.End) || (end > appointment.Start && end <= appointment.End))
                    {
                        Console.WriteLine("Já existe uma consulta marcada para este horário!");
                        break;
                    }
                }                     
            }
        }
    }
}
