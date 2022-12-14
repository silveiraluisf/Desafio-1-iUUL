using Agenda_Consultorio_Odontologico.model;

namespace Agenda_Consultorio_Odontologico.view
{
    public class PatientRegistrationInterface
    {
        private string _inputName;
        private string _inputCPF;
        private string _inputDate;
        private List<string> _errorList;

        public string InputName
        {
            get { return _inputName; }
            set { _inputName = value; }
        }
        public string InputCPF
        {
            get { return _inputCPF; }
            set { _inputCPF = value; }
        }
        public string InputDate
        {
            get { return _inputDate; }
            set { _inputDate = value; }
        }
        public List<string> ErrorList
        {
            get { return _errorList; }
            set { _errorList = value; }
        }
        public void Title()
        {
            Console.WriteLine("Cadastro do paciente \n");
        }
        public void GetName()
        {
            Console.WriteLine("Insira o nome do cliente: ");
            this._inputName = Console.ReadLine();
        }
        public void GetCPF()
        {
            Console.WriteLine("Insira o CPF: ");
            this._inputCPF = Console.ReadLine();
        }
        public void GetDate()
        {
            Console.WriteLine("Insira da data de nascimento (dd/mm/aaaa): ");
            this._inputDate = Console.ReadLine();
        }
        public void ShowData()
        {
            Console.WriteLine($"--------------------------------------------");
            Console.WriteLine($"CPF: {this.InputCPF}");
            Console.WriteLine($"Nome: {this.InputName}");
            Console.WriteLine($"Data de nascimento: {this.InputDate} \n");
            Console.WriteLine("Paciente cadastrado com sucesso!\n");
        }
        public void ErrorMessages(int n)
        {
            this._errorList = new List<string>
            {
                $"Erro no nome: {_inputName} -> O nome não pode ser vazio!" ,
                $"Erro no nome: {_inputName} -> O nome deve possuir pelo menos 5 caracteres",
                $"Erro no CPF: {_inputCPF} -> Favor insira um CPF válido (11 caracteres, apenas números).",
                $"Erro na data de nascimento: {_inputDate} -> O cliente deve ter pelo menos 18 anos!",
                $"Erro na data de nascimento: { _inputDate} -> Favor insira uma data no formato DD,MM,AAAA. ",
            };
            Console.WriteLine($"{ErrorList[n]}");
        }
    }
}
