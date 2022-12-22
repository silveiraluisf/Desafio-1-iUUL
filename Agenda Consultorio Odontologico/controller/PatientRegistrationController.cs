using Agenda_Consultorio_Odontologico.view;
using Agenda_Consultorio_Odontologico.model;

namespace Agenda_Consultorio_Odontologico.controller
{
    public class PatientRegistrationController
    {
        PatientRegistrationInterface pri = new();
        string name;
        long cpf;
        DateTime bd;
        public void AddPatient()
        {
            pri.GetInformation();
            pri.ShowData();
            PatientValidator();
            Patient patient = new(this.name , this.cpf, this.bd);
            Console.Write($"Teste 1 = {patient.Name} | {patient.CPF} | {patient.BirthDate}\n");                                  
        }
        public void PatientValidator()
        {
            NameValidate(pri);
            CPFValidate(pri);
            BirthDateValidate(pri);
        }
        public void PrintPatientsList()
        {
            foreach (Patient pat in Patient.PatientList)
            {
                Console.Write($"Teste 2 = {pat.Name}\n");
            }
        }
        public void NameValidate(PatientRegistrationInterface a)
        {
            switch (a.InputName.Length)
            {
                case 0:
                    a.ErrorMessages(0);
                    break;
                case < 5:
                    a.ErrorMessages(1);
                    break;
                case >= 5:
                    this.name = a.InputName;
                    //NameValidated(name);

                    break;
            }
        }
        public void CPFValidate(PatientRegistrationInterface a)
        {
            string inputCPF = a.InputCPF;
            switch (inputCPF.Length)
            {
                case 11:
                    bool parseSuccess = long.TryParse(inputCPF, out long outputCPF);
                    if (parseSuccess)
                    {
                        CPFValidateAllSameNumber(a, outputCPF);
                    }
                    else
                    {
                        a.ErrorMessages(2);
                        CPFValidate(a);
                    }
                    break;
                default:
                    a.ErrorMessages(2);
                    CPFValidate(a);
                    break;
            }
        }
        public void CPFValidateAllSameNumber(PatientRegistrationInterface a, long outputCPF)
        {
            switch (outputCPF)
            {
                case 11111111111:
                    a.ErrorMessages(2);
                    //CPFValidate(a, c);
                    break;
                case 22222222222:
                    a.ErrorMessages(2);
                    //CPFValidate(a, c);
                    break;
                case 33333333333:
                    a.ErrorMessages(2);
                    //CPFValidate(a, c);
                    break;
                case 44444444444:
                    a.ErrorMessages(2);
                    //CPFValidate(a, c);
                    break;
                case 55555555555:
                    a.ErrorMessages(2);
                    //CPFValidate(a, c);
                    break;
                case 66666666666:
                    a.ErrorMessages(2);
                    //CPFValidate(a, c);
                    break;
                case 77777777777:
                    a.ErrorMessages(2);
                    //CPFValidate(a, c);
                    break;
                case 88888888888:
                    a.ErrorMessages(2);
                    //CPFValidate(a, c);
                    break;
                case 99999999999:
                    a.ErrorMessages(2);
                    //CPFValidate(a, c);
                    break;
                default:
                    //CPFValidateVerificatorNumbers(c, outputCPF);
                    //CPFValidated(outputCPF);
                    this.cpf = outputCPF;
                    break;
            }
        }
        public void BirthDateValidate(PatientRegistrationInterface a)
        {
            string inputDate = a.InputDate;
            DateTime now = DateTime.Now;
            TimeSpan eighteenYears = new TimeSpan(6574, 0, 0, 0);
            bool parseSuccess = DateTime.TryParse(inputDate, out DateTime outputDate);
            if (parseSuccess)
            {
                outputDate = Convert.ToDateTime(outputDate);
                TimeIntervalController timeInterval = new(outputDate, now);
                if (timeInterval.Duration > eighteenYears)
                {
                    //BirthDateValidated(outputDate);
                    this.bd = outputDate;
                }
                else
                {
                    a.ErrorMessages(3);
                    //BirthDateValidate(a);
                }
            }
            else
            {
                a.ErrorMessages(4);
                //BirthDateValidate(a);
            }
        }
    }
}
