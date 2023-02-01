using Agenda_Consultorio_Odontologico.view;
using Agenda_Consultorio_Odontologico.view.patientInterface;

namespace Agenda_Consultorio_Odontologico.controller.patientControllers
{
    public class PatientMenuController
    {
        PatientMenu pmi = new();
        PatientMainController prc = new();
        public void Menu()
        {
            pmi.Menu();
            Options();
        }
        public void Options()
        {
            MainMenuController m = new();

            bool parseSuccess = int.TryParse(pmi.InputOption, out int value);

            if (parseSuccess)
            {
                switch (value)
                {
                    case 1:
                        prc.AddPatient();
                        m.OpenMenu();
                        break;
                    case 2:
                        prc.RemovePatient();
                        m.OpenMenu();
                        break;
                    case 3:
                        prc.PrintPatientsListByCPF();
                        m.OpenMenu();
                        break;
                    case 4:
                        prc.PrintPatientsListByName();
                        m.OpenMenu();
                        break;
                    case 5:
                        m.OpenMenu();
                        break;
                    default:
                        MainMenuView.InvalidOptionMessage();
                        pmi.Menu();
                        break;
                }
            }
            else
            {
                MainMenuView.InvalidOptionMessage();
                pmi.Menu();
            }

        }
    }
}
