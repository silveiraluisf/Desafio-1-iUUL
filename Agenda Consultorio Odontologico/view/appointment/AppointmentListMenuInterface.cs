namespace Agenda_Consultorio_Odontologico.view.appointment
{
    public class AppointmentListMenuInterface
    {
        private string _inputOption;
        private string _inputStartDate;
        private string _inputEndDate;
        private List<string> _errorList;
        public string InputOption
        {
            get { return _inputOption; }
            set { _inputOption = value; }
        }
        public string InputStartDate
        {
            get { return _inputStartDate; }
            set { _inputStartDate = value; }
        }
        public string InputEndDate
        {
            get { return _inputEndDate; }
            set { _inputEndDate = value; }
        }
        public List<string> ErrorList
        {
            get { return _errorList; }
            set { _errorList = value; }
        }
        public void AppointmentListMenu()
        {
            Console.WriteLine("Lista dos agendamentos");
            Console.WriteLine("1- Mostrar lista completa.");
            Console.WriteLine("2- Mostrar lista por período.");
            _inputOption = Console.ReadLine();
        }
        public void ErrorMessages(int n)
        {
            this._errorList = new List<string>
            {
                "Favor insira uma opção válida",
                $"Erro na data: {_inputStartDate} -> Digite a data no formato válido (DD/MM/AAAA).",
                $"Erro na hora: {_inputEndDate} -> Digite a data no formato válido (DD/MM/AAAA).",
                "A data inicial não pode ser posterior à data final!",
            };
            Console.WriteLine($"{ErrorList[n]}");
        }
        public void GetDates()
        {
            Console.WriteLine("Insira a data de início do período: ");
            _inputStartDate = Console.ReadLine();
            Console.WriteLine("Insira a data final do período: ");
            _inputEndDate = Console.ReadLine();
        }
    }
}
