namespace Agenda_Consultorio_Odontologico.view
{
    public class AppointmentMenuInterface
    {
        private string _inputOption;
        public string InputOption
        {
            get { return _inputOption; }
            set { _inputOption = value; }
        }
        public void AppointmentMenu()
        {
            Console.WriteLine("Agenda");
            Console.WriteLine("1- Agendar consulta");
            Console.WriteLine("2- Cancelar agendamento");
            Console.WriteLine("3- Listar agenda");
            Console.WriteLine("4- Voltar p/ menu principal");
            this._inputOption = Console.ReadLine();
        }
        public void ErrorMessage()
        {
            Console.WriteLine("Favor insira uma opção válida.");
        }
    }
}
