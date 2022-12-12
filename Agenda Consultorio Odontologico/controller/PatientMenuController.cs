using Agenda_Consultorio_Odontologico.view;

namespace Agenda_Consultorio_Odontologico.controller
{
    public class PatientMenuController
    {
        PatientMenuInterface pmi = new();
        PatientRegistrationInterface pri = new();
        PatientRegistrationController prc = new();
        public void OpenInterface()
        {
            pmi.PatientMenu();
            Options();
        }

        public void Options()
        {
            string inputOption = pmi.InputOption;
            bool parseSuccess = int.TryParse(inputOption, out int value);
            if (parseSuccess)
            {
                switch (value)
                {
                    case 1:
                        prc.AddPatient(pri);
                        pmi.PatientMenu();
                        break;
                    case 2:
                        System.Environment.Exit(0);
                        break;
                    case 3:
                        System.Environment.Exit(0);
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                    case 5:
                        MainMenuController m = new();
                        m.OpenInterface();
                        break;
                    default:
                        pmi.ErrorMessage();
                        pmi.PatientMenu();
                        break;
                }
            }
            else
            {
                pmi.ErrorMessage();
                pmi.PatientMenu();
            }

        }
    }
}
