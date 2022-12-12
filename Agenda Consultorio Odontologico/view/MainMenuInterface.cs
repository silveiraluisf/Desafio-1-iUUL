namespace Agenda_Consultorio_Odontologico.view
{
    public class MainMenuInterface
    {
        private string _inputOption;
        public string InputOption
        {
            get { return _inputOption; }
            set { _inputOption = value; }
        }
        public void MainMenu()
        {
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1- Cadastro de pacientes");
            Console.WriteLine("2- Agenda");
            Console.WriteLine("3- Fim");
            this._inputOption = Console.ReadLine();
        }
        public void ErrorMessage() 
        { 
            Console.WriteLine("Favor insira uma opção válida. \n"); 
        }
    }
}
