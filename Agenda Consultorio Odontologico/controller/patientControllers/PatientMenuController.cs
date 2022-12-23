using Agenda_Consultorio_Odontologico.view.patientInterface;

namespace Agenda_Consultorio_Odontologico.controller.patientControllers
{
    public class PatientMenuController
    {
        PatientMenuInterface pmi = new();
        PatientRegistrationController prc = new();
        public void OpenInterface()
        {
            pmi.PatientMenu();
            Options();
        }
        public void Options()
        {
            MainMenuController m = new();
            string inputOption = pmi.InputOption;
            bool parseSuccess = int.TryParse(inputOption, out int value);
            if (parseSuccess)
            {
                switch (value)
                {
                    case 1:
                        prc.AddPatient();
                        m.OpenInterface();
                        break;
                    case 2:
                        prc.RemovePatient();
                        m.OpenInterface();
                        break;
                    case 3:
                        prc.PrintPatientsList();
                        m.OpenInterface();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    case 5:
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
