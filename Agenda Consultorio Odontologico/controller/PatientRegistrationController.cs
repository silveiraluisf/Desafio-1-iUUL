using Agenda_Consultorio_Odontologico.view;
using Agenda_Consultorio_Odontologico.model;

namespace Agenda_Consultorio_Odontologico.controller
{
    public class PatientRegistrationController
    {
        public void AddPatient(PatientRegistrationInterface pri)
        {
            pri.GetInformation();
            pri.ShowData();       
        }
        public void PatientValidator(PatientRegistrationInterface pri, PatientListController plc,  PatientList pl, Patient p)
        {
            NameValidate(pri, p);
            CPFValidate(pri, p);
            BirthDateValidate(pri, p);
            plc.AddPatientToList(pl, p);
        }
        public void NameValidate(PatientRegistrationInterface a, Patient p)
        {
            string name = a.InputName;
            switch (name.Length)
            {
                case 0:
                    a.ErrorMessages(0);
                    break;
                case < 5:
                    a.ErrorMessages(1);
                    break;
                case >= 5:
                    p.Name = name;
                    break;
            }
        }
        public void CPFValidate(PatientRegistrationInterface a, Patient c)
        {
            string inputCPF = a.InputCPF;
            long outputCPF;
            switch (inputCPF.Length)
            {
                case 11:
                    bool parseSuccess = long.TryParse(inputCPF, out outputCPF);
                    if (parseSuccess)
                    {
                        CPFValidateAllSameNumber(a, c, outputCPF);
                    }
                    else
                    {
                        a.ErrorMessages(2);
                        CPFValidate(a, c);
                    }
                    break;
                default:
                    a.ErrorMessages(2);
                    CPFValidate(a, c);
                    break;
            }
        }
        public void CPFValidateAllSameNumber(PatientRegistrationInterface a, Patient c, long outputCPF)
        {
            switch (outputCPF)
            {
                case 11111111111:
                    a.ErrorMessages(2);
                    a.GetCPF();
                    CPFValidate(a, c);
                    break;
                case 22222222222:
                    a.ErrorMessages(2);
                    a.GetCPF();
                    CPFValidate(a, c);
                    break;
                case 33333333333:
                    a.ErrorMessages(2);
                    a.GetCPF();
                    CPFValidate(a, c);
                    break;
                case 44444444444:
                    a.ErrorMessages(2);
                    a.GetCPF();
                    CPFValidate(a, c);
                    break;
                case 55555555555:
                    a.ErrorMessages(2);
                    a.GetCPF();
                    CPFValidate(a, c);
                    break;
                case 66666666666:
                    a.ErrorMessages(2);
                    a.GetCPF();
                    CPFValidate(a, c);
                    break;
                case 77777777777:
                    a.ErrorMessages(2);
                    a.GetCPF();
                    CPFValidate(a, c);
                    break;
                case 88888888888:
                    a.ErrorMessages(2);
                    a.GetCPF();
                    CPFValidate(a, c);
                    break;
                case 99999999999:
                    a.ErrorMessages(2);
                    a.GetCPF();
                    CPFValidate(a, c);
                    break;
                default:
                    CPFValidateVerificatorNumbers(c, outputCPF);
                    break;
            }
        }
        public void CPFValidateVerificatorNumbers(Patient c, long outputCPF)
        {
            string DigitsCPF = outputCPF.ToString("0000000000");
            Console.WriteLine(outputCPF);
            int[] listOfDigits = Array.Empty<int>();
            for (int i = 0; i <= 10; i++)
            {
                string d = DigitsCPF.Substring(i, 1);
                int.TryParse(d, out int n);
                listOfDigits.Append(n);
                Console.WriteLine($"teste2 {n}");
            }
            c.CPF = outputCPF;
        }
        public void BirthDateValidate(PatientRegistrationInterface a, Patient c)
        {
            string inputDate = a.InputDate;
            DateTime outputDate;
            DateTime now = DateTime.Now;
            TimeSpan eighteenYears = new TimeSpan(6574, 0, 0, 0);
            bool parseSuccess = DateTime.TryParse(inputDate, out outputDate);
            if (parseSuccess)
            {
                c.BirthDate = Convert.ToDateTime(outputDate);
                TimeIntervalController timeInterval = new(outputDate, now);
                if (timeInterval.Duration > eighteenYears)
                {
                    outputDate = c.BirthDate;
                }
                else
                {
                    a.ErrorMessages(3);
                    a.GetDate();
                    BirthDateValidate(a, c);
                }
            }
            else
            {
                a.ErrorMessages(4);
                a.GetDate();
                BirthDateValidate(a, c);
            }
        }                  
    }
}
