using Agenda_Consultorio_Odontologico.controller;
using Agenda_Consultorio_Odontologico.model;

namespace Agenda_Consultorio_Odontologico
{
    class Program
    {        
        static public void Main()
        {
            MainMenuController mc = new MainMenuController();


            SaveUsingEntity();
            //mc.OpenInterface();
        }

        private static void SaveUsingEntity()
        {
            var date1 = new DateTime(1992, 9, 13, 0, 0, 0);
            Patient a = new("Luís Fernando", 78978978977, date1);

            var date2 = new DateTime(1997, 11, 29, 0, 0, 0);
            Patient b = new("André Ricardo", 12312312311, date2);

            var date3 = new DateTime(1990, 9, 19, 0, 0, 0);
            Patient c = new("Bárbara", 45645645644, date3);

            var date4 = new DateTime(2022, 8, 26, 0, 0, 0);
            var date5 = new DateTime(2023, 3, 1, 0, 0, 0);

            Appointment appointment1 = new(date4, 1000, 1030, a);
            Appointment appointment2 = new(DateTime.Now, 1000, 1030, b);
            Appointment appointment3 = new(date5, 0900, 0945, a);

            using(var context = new ConsultorioContext())
            {
                context.Patients.Add(a);
                context.SaveChanges();
            }
        }
    }
}
