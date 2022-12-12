using Agenda_Consultorio_Odontologico.controller;

namespace Agenda_Consultorio_Odontologico
{
    class Program
    {
        static public void Main()
        {
            SystemController s = new SystemController();
            s.OpenInterface();
        }
    }
}
