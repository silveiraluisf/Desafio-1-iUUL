using Agenda_Consultorio_Odontologico.model;
using Agenda_Consultorio_Odontologico.view.patientInterface;

namespace Agenda_Consultorio_Odontologico.controller.patientControllers
{
    public class PatientRegistrationController
    {
        PatientRegistrationInterface pri = new();
        PatientDeleteInterface pdi = new();
        string name;
        long cpf;
        DateTime birthDate;
        public void AddPatient()
        {
            pri.GetInformation();
            pri.ShowData();
            NameValidate();
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
        public void PrintPatientsList()
        {
            foreach (Patient patient in Patient.PatientList)
            {
                Console.Write($"Teste 2 = {patient.Name}\n");
            }
        }
        public void NameValidate()
        {
            switch (pri.InputName.Length)
            {
                case 0:
                    pri.FailureMessage();
                    break;
                case < 5:
                    pri.FailureMessage();
                    break;
                case >= 5:
                    name = pri.InputName;
                    CPFValidate();
                    break;
            }
        }
        public void CPFValidate()
        {
            string inputCPF = pri.InputCPF;
            switch (inputCPF.Length)
            {
                case 11:
                    bool parseSuccess = long.TryParse(inputCPF, out long outputCPF);
                    if (parseSuccess)
                    {
                        CPFValidateAllSameNumber(outputCPF);
                    }
                    else
                    {
                        pri.FailureMessage();
                    }
                    break;
                default:
                    pri.FailureMessage();
                    break;
            }
        }
        public void CPFValidateAllSameNumber(long outputCPF)
        {
            switch (outputCPF)
            {
                case 11111111111:
                    pri.FailureMessage();
                    break;
                case 22222222222:
                    pri.FailureMessage();
                    break;
                case 33333333333:
                    pri.FailureMessage();
                    break;
                case 44444444444:
                    pri.FailureMessage();
                    break;
                case 55555555555:
                    pri.FailureMessage();
                    break;
                case 66666666666:
                    pri.FailureMessage();
                    break;
                case 77777777777:
                    pri.FailureMessage();
                    break;
                case 88888888888:
                    pri.FailureMessage();
                    break;
                case 99999999999:
                    pri.FailureMessage();
                    break;
                default:
                    cpf = outputCPF;
                    BirthDateValidate();
                    break;
            }
        }
        public void BirthDateValidate()
        {
            string inputDate = pri.InputDate;
            DateTime now = DateTime.Now;
            TimeSpan eighteenYears = new TimeSpan(6574, 0, 0, 0);
            bool parseSuccess = DateTime.TryParse(inputDate, out DateTime outputDate);
            if (parseSuccess)
            {
                outputDate = Convert.ToDateTime(outputDate);
                TimeIntervalController timeInterval = new(outputDate, now);
                if (timeInterval.Duration > eighteenYears)
                {
                    birthDate = outputDate;
                    Patient patient = new(name, cpf, birthDate);
                    pri.SuccessMessage();
                }
                else
                {
                    pri.FailureMessage(); ;
                }
            }
            else
            {
                pri.FailureMessage();
            }
        }
    }
}
