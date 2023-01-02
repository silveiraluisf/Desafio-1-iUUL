using Agenda_Consultorio_Odontologico.model;
using Agenda_Consultorio_Odontologico.view.patientInterface;

namespace Agenda_Consultorio_Odontologico.controller.patientControllers
{
    public class PatientDeleteController
    {
        PatientDeleteInterface pdi = new();
        public void DeletePatient()
        {
            List<Patient> list = new List<Patient>();
            pdi.GetInformation();
            bool parseSuccess = long.TryParse(pdi.InputCPF, out long outputCPF);
            if (parseSuccess)
            {
                for (int i = 0; i < Patient.PatientList.Count; i++)
                {
                    Patient patient = Patient.PatientList[i];
                    if (patient.CPF == outputCPF)
                    {
                        list.Add(patient);
                    }
                }
                if (list.Count == 0)
                {
                    pdi.ErrorMessages(1);
                }
                else
                {
                    foreach (Patient patient in list)
                    {
                        CheckAppointments(patient);
                    }
                }
            }
            else pdi.ErrorMessages(0);
        }
        public void CheckAppointments(Patient patient)
        {
            List<Appointment> list = new();
            for (int i = 0; i < Appointment.AppointmentList.Count; i++)
            {
                Appointment appointment = Appointment.AppointmentList[i];
                if (appointment.Patient == patient)
                {
                    list.Add(appointment);
                }
            }
            if (list.Count > 0)
            {
                foreach (Appointment appointment in list)
                {
                    CheckAppointmentTime(appointment, patient);
                }
            }
            else
            {
                Patient.PatientList.Remove(patient);
                pdi.SuccessMessage();
            }
        }
        public void CheckAppointmentTime(Appointment appointment, Patient patient)
        {
            if(appointment.Date < DateTime.Today) 
            {
                Appointment.AppointmentList.Remove(appointment);
                Patient.PatientList.Remove(patient);
                pdi.SuccessMessage();
            }
            else pdi.ErrorMessages(2);
        }
    }
}
