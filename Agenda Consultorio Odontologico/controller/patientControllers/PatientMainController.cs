using Agenda_Consultorio_Odontologico.model;
using Agenda_Consultorio_Odontologico.view.patientInterface;

namespace Agenda_Consultorio_Odontologico.controller.patientControllers
{
    public class PatientMainController
    {
        PatientValidatorController pvc = new();
        PatientDeleteInterface pdi = new();
        PatientListInterface pli = new();

        
        public void AddPatient()
        {
            pvc.PatientValidator();
        }
        public void RemovePatient()
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
                            Patient.PatientList.Remove(patient);
                            pdi.SuccessMessage();
                        }
                    }
                    pdi.ErrorMessage();
                }
                else
                {
                    pdi.ErrorMessage();
                }                          
        }
        public void PrintPatientsListByCPF()
        {
            pli.Title();
            pli.Header();
            foreach (Patient patient in Patient.PatientList.OrderBy(x => x.CPF))
            {
                pli.ShowPatientsList(patient);
            }
            pli.Footer();
        }
        public void PrintPatientsListByName()
        {
            pli.Title();
            pli.Header();
            foreach (Patient patient in Patient.PatientList.OrderBy(x=>x.Name))
            {
                pli.ShowPatientsList(patient);
            }
            pli.Footer();
        }
        
    }
}
