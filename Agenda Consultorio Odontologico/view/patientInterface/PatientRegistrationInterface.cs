using Agenda_Consultorio_Odontologico.model;

namespace Agenda_Consultorio_Odontologico.view.patientInterface
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
        public void GetInformation()
        {
            Console.WriteLine("Insira o nome do cliente: ");
            _inputName = Console.ReadLine();

            Console.WriteLine("Insira o CPF: ");
            _inputCPF = Console.ReadLine();

            Console.WriteLine("Insira da data de nascimento (dd/mm/aaaa): ");
            _inputDate = Console.ReadLine();
        }
        public void ShowData()
        {
            Console.WriteLine($"--------------------------------------------");
            Console.WriteLine($"CPF: {InputCPF}");
            Console.WriteLine($"Nome: {InputName}");
            Console.WriteLine($"Data de nascimento: {InputDate} \n");

        }
        public void SuccessMessage()
        {
            Console.WriteLine("Paciente cadastrado com sucesso!\n");
        }
        public void FailureMessage()
        {
            //método temporário enquanto não é feito o tratamento dos erros 
            Console.WriteLine("Opa, algum dado foi inserido errado!\n");
        }
    }
}
