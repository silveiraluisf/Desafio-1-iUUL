using Agenda_Consultorio_Odontologico.view;
using Agenda_Consultorio_Odontologico.view.appointmentInterface;

namespace Agenda_Consultorio_Odontologico.controller.appointmentController
{
    public class AppointmentMenuController
    {
        AppointmentMenu appointmentMenu = new();
        AppointmentMainController amc = new();


        public void Menu()
        {
            appointmentMenu.Menu();
            Options();
        }

        public void Options()
        {
            MainMenuController m = new();
            string inputOption = appointmentMenu.InputOption;
            bool parseSuccess = int.TryParse(inputOption, out int value);
            if (parseSuccess)
            {
                switch (value)
                {
                    case 1:
                        amc.CreateAppointment();
                        m.OpenMenu();
                        break;
                    case 2:
                        amc.RemoveAppointment();    
                        m.OpenMenu();
                        break;
                    case 3:
                        amc.PrintFullAppointmentList();
                        m.OpenMenu();
                        break;
                    case 4:
                        m.OpenMenu();
                        break;
                    default:
                        MainMenuView.InvalidOptionMessage();
                        appointmentMenu.Menu();
                        break;
                }
            }
            else
            {
                MainMenuView.InvalidOptionMessage();
                appointmentMenu.Menu();
            }
        }
    }
}
