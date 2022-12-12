using Agenda_Consultorio_Odontologico.view;

namespace Agenda_Consultorio_Odontologico.controller
{
    public class PatientMenuController
    {
        PatientMenuInterface p = new();
        public void OpenInterface()
        {
            p.PatientMenu();
            Options();
        }

        public void Options()
        {
            string inputOption = p.InputOption;
            bool parseSuccess = int.TryParse(inputOption, out int value);
            if (parseSuccess)
            {
                switch (value)
                {
                    case 1:
                        System.Environment.Exit(0);
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
                        p.ErrorMessage();
                        p.PatientMenu();
                        break;
                }
            }
            else
            {
                p.ErrorMessage();
                p.PatientMenu();
            }

        }
    }
}
