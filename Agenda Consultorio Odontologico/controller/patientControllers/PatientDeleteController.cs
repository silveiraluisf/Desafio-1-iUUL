using Agenda_Consultorio_Odontologico.model;
using Agenda_Consultorio_Odontologico.view.patientInterface;

namespace Agenda_Consultorio_Odontologico.controller.patientControllers
{
    public class PatientDeleteController
    {
        PatientDeleteInterface pdi = new();
        public void DeletePatient()
        {
            pdi.GetInformation();
            bool parseSuccess = long.TryParse(pdi.InputCPF, out long outputCPF);
            if (parseSuccess)
            {
                for (int i = 0; i < Patient.PatientList.Count; i++)
                {
                    Patient patient = Patient.PatientList[i];
                    if (patient.CPF == outputCPF)
                    {
                        CheckAppointments(patient);
                    }
                }
            }
        }
        public void CheckAppointments(Patient patient)
        {
            for (int i = 0; i < Appointment.AppointmentList.Count; i++)
            {
                Appointment appointment = Appointment.AppointmentList[i];
                if (appointment.Patient == patient)
                {
                    CheckAppointmentTime(appointment, patient);
                }
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
