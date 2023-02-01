using Agenda_Consultorio_Odontologico.view.appointment;

namespace Agenda_Consultorio_Odontologico.controller.appointment
{
    public class AppointmentListMenuController
    {
        AppointmentListMenuInterface almi = new();
        AppointmentListController alc = new();
        public void OpenInterface()
        {
            almi.AppointmentListMenu();
            Options();
        }

        public void Options()
        {
            MainMenuController m = new();
            string inputOption = almi.InputOption;
            bool parseSuccess = int.TryParse(inputOption, out int value);
            if (parseSuccess)
            {
                switch (value)
                {
                    case 1:
                        alc.PrintFullAppointmentList();
                        m.OpenMenu();
                        break;
                    case 2:
                        alc.PrintAppointmentListByPeriod();
                        m.OpenMenu();
                        break;
                    default:
                        almi.ErrorMessages(0);
                        almi.AppointmentListMenu();
                        break;
                }
            }
            else
            {
                almi.ErrorMessages(0);
                almi.AppointmentListMenu();
            }

        }
    }
}
