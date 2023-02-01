using Agenda_Consultorio_Odontologico.view.appointmentInterface;

namespace Agenda_Consultorio_Odontologico.controller.appointmentController
{
    public class AppointmentMenuController
    {
        AppointmentMenuInterface ami = new();
        AppointmentMainController amc = new();
        public void OpenInterface()
        {
            ami.AppointmentMenu();
            Options();
        }

        public void Options()
        {
            MainMenuController m = new();
            string inputOption = ami.InputOption;
            bool parseSuccess = int.TryParse(inputOption, out int value);
            if (parseSuccess)
            {
                switch (value)
                {
                    case 1:
                        amc.AddAppointment();
                        m.OpenInterface();
                        break;
                    case 2:
                        amc.RemoveAppointment();    
                        m.OpenInterface();
                        break;
                    case 3:
                        amc.PrintFullAppointmentList();
                        m.OpenInterface();
                        break;
                    case 4:
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
