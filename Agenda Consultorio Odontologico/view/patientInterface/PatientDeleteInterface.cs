namespace Agenda_Consultorio_Odontologico.view.patientInterface
{
    public class PatientDeleteInterface
    {
        private string _inputCPF;
        private List<string> _errorList;
        public string InputCPF
        {
            get { return _inputCPF; }
            set { _inputCPF = value; }
        }
        public List<string> ErrorList
        {
            get { return _errorList; }
            set { _errorList = value; }
        }
        public void Title()
        {
            Console.WriteLine("Remoção de paciente \n");
        }
        public void GetInformation()
        {
            Console.WriteLine("Insira o CPF do paciente que desejas remover: ");
            _inputCPF = Console.ReadLine();

        }
        public void SuccessMessage()
        {
            Console.WriteLine("Paciente removido com sucesso!\n");
        }
        public void ErrorMessages(int n)
        {
            this._errorList = new List<string>
            {
                $"Erro no CPF: {_inputCPF} -> Favor insira um CPF válido (11 caracteres, apenas números).",
                $"Erro no CPF: {_inputCPF} -> O CPF inserido não está cadastrado!",
                $"Você não pode excluir um paciente que possui agendamento programado!",
            };
            Console.WriteLine($"{ErrorList[n]}");
        }
    }
}
