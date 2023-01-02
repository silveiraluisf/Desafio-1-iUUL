namespace Agenda_Consultorio_Odontologico.view.appointmentInterface
{
    public class AppointmentRegistrationInterface
    {
        private string _inputPatientCPF;
        private string _inputDate;
        private string _inputStart;
        private string _inputEnd;
        private List<string> _errorList;
        public string InputPatientCPF
        {
            get { return _inputPatientCPF; }
            set { _inputPatientCPF = value; }
        }
        public string InputDate
        {
            get { return _inputDate; }
            set { _inputDate = value; }
        }
        public string InputStart
        {
            get { return _inputStart; }
            set { _inputStart = value; }
        }
        public string InputEnd
        {
            get { return _inputEnd; }
            set { _inputEnd = value; }
        }
        public List<string> ErrorList
        {
            get { return _errorList; }
            set { _errorList = value; }
        }
        public void Title()
        {
            Console.WriteLine("Agendamento de consulta \n");
        }
        public void GetPatientCPF()
        {
            Console.WriteLine("Insira o CPF do paciente: ");
            _inputPatientCPF = Console.ReadLine();
        }
        public void GetDate()
        {
            Console.WriteLine("Insira a data da consulta (dd/mm/aaaa): ");
            _inputDate = Console.ReadLine();
        }
        public void GetStart()
        {
            Console.WriteLine("Insira o horário de início da consulta (HHMM): ");
            _inputStart = Console.ReadLine();
        }
        public void GetEnd()
        {
            Console.WriteLine("Insira o horário de término da consulta (HHMM): ");
            _inputEnd = Console.ReadLine();
        }
        public void ShowData()
        {
            Console.WriteLine($"--------------------------------------------");
            Console.WriteLine($"CPF: {InputPatientCPF}");
            Console.WriteLine($"Data da consulta: {InputDate}");
            Console.WriteLine($"Hora inicial: {InputStart}");
            Console.WriteLine($"Hora final: {InputEnd} \n");            
        }
        public void SuccessMessage()
        {
            Console.WriteLine("Agendamento realizado com sucesso!\n");
        }
        public void ErrorMessages(int n)
        {
            this._errorList = new List<string>
            {
                $"Erro no CPF: {_inputPatientCPF} -> CPF não cadastrado!" ,
                $"Erro no CPF: {_inputPatientCPF} -> Favor insira um CPF válido (11 caracteres, apenas números).",
                $"Erro na data: {_inputDate} -> A data não pode ser anterior à hoje!",
                $"Erro na data: { _inputDate} -> Favor insira uma data no formato DD,MM,AAAA. ",
                $"Erro no horário de início: {_inputStart} -> Hora inválida ou fora do horário de atendimento (horário de atendimento é das 8h até 19h)",
                $"Erro no horário de início: {_inputStart} -> Favor digite um horário no formato 0900, 1345, 1730." ,
                $"Erro no horário de término: {_inputEnd} -> Hora inválida ou fora do horário de atendimento (horário de atendimento é das 8h até 19h)",
                $"Erro no horário de término: {_inputEnd} -> A hora final não pode ser menor que a hora inicial!)",
                $"Erro no horário de término: {_inputEnd} -> Favor digite um horário no formato 0900, 1345, 1730." ,
                $"Conflito de agendamento: Não pode haver dois agendamentos futuros para um mesmo paciente!" ,
                $"Conflito de agendamento: Já existe uma consulta marcada para este horário!" ,
            };
            Console.WriteLine($"{ErrorList[n]}");
        }
    }
}
