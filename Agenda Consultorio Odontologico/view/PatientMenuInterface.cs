using Agenda_Consultorio_Odontologico.model;

namespace Agenda_Consultorio_Odontologico.view
{
    public class PatientMenuInterface
    {
        private string _inputOption;
        public string InputOption
        {
            get { return _inputOption; }
            set { _inputOption = value; }
        }
        public void PatientMenu()
        {
            Console.WriteLine("Menu de Cadastro de Pacientes");
            Console.WriteLine("1- Cadastrar novo paciente");
            Console.WriteLine("2- Excluir paciente");
            Console.WriteLine("3- Listar pacientes (ordenados por CPF)");
            Console.WriteLine("4- Listar pacientes (ordenados por nome)");
            Console.WriteLine("5- Voltar p/ o menu principal");
            this._inputOption = Console.ReadLine();
        }
        public void ErrorMessage()
        {
            Console.WriteLine("Favor insira uma opção válida.");
        }       
    }
}
