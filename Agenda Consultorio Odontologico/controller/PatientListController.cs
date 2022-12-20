using Agenda_Consultorio_Odontologico.model;

namespace Agenda_Consultorio_Odontologico.controller
{
    public class PatientListController
    {
        public void AddPatientToList(PatientList patients ,Patient patient)
        {
            if (patient.Name != null && patient.CPF != null && patient.BirthDate != null)
            {
                patients.Patients.Add(patient);
            }
            else
            {
                //estratégia de inserir erros
            }
        }
        public void RemovePatientFromList(PatientList patients, Patient patient)
        {
            patients.Patients.Remove(patient);
        }
    }
}
