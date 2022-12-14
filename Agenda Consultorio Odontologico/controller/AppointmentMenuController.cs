using Agenda_Consultorio_Odontologico.view;

namespace Agenda_Consultorio_Odontologico.controller
{
    public class AppointmentMenuController
    {
        AppointmentMenuInterface ami = new();
        AppointmentRegistrationInterface ari = new();
        AppointmentRegistrationController arc = new();
        public void OpenInterface()
        {
            ami.AppointmentMenu();
            Options();
        }

        public void Options()
        {
            string inputOption = ami.InputOption;
            bool parseSuccess = int.TryParse(inputOption, out int value);
            if (parseSuccess)
            {
                switch (value)
                {
                    case 1:
                        arc.AddAppointment(ari);
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
                        ami.ErrorMessage();
                        ami.AppointmentMenu();
                        break;
                }
            }
            else
            {
                ami.ErrorMessage();
                ami.AppointmentMenu();
            }

        }
    }
}
