using Agenda_Consultorio_Odontologico.view;

namespace Agenda_Consultorio_Odontologico.controller
{
    public class AppointmentMenuController
    {
        AppointmentMenuInterface a = new();
        public void OpenInterface()
        {
            a.AppointmentMenu();
            Options();
        }

        public void Options()
        {
            string inputOption = a.InputOption;
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
                        MainMenuController m = new();
                        m.OpenInterface();
                        break;
                    default:
                        a.ErrorMessage();
                        a.AppointmentMenu();
                        break;
                }
            }
            else
            {
                a.ErrorMessage();
                a.AppointmentMenu();
            }

        }
    }
}
