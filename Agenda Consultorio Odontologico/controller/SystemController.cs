using Agenda_Consultorio_Odontologico.view;

namespace Agenda_Consultorio_Odontologico.controller
{
    public class SystemController
    {
        public void OpenInterface()
        {
            MainMenuInterface m = new();
            m.MainMenu();
        }
    }
}
