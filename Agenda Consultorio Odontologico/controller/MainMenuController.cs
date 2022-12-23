using Agenda_Consultorio_Odontologico.controller.appointmentController;
using Agenda_Consultorio_Odontologico.controller.patientControllers;
using Agenda_Consultorio_Odontologico.view;

namespace Agenda_Consultorio_Odontologico.controller
{
    public class MainMenuController
    {
        MainMenuInterface mi = new();
        PatientMenuController pmc = new();
        AppointmentMenuController amc = new();
        public void OpenInterface()
        {
            mi.MainMenu();
            Options();
        }

        public void Options()
        {
            string inputOption = mi.InputOption;
            bool parseSuccess = int.TryParse(inputOption, out int value);
            if(parseSuccess )
            {
                switch(value)
                {
                    case 1:
                        pmc.OpenInterface();
                        break;
                    case 2:
                        amc.OpenInterface();
                        break;
                    case 3:
                        System.Environment.Exit(0);
                        break;
                    default:
                        mi.ErrorMessage();
                        mi.MainMenu();
                        break;
                }
            }
            else
            {
                mi.ErrorMessage();
                mi.MainMenu();
            }
            
        }
    }
}
