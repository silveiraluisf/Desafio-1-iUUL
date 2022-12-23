namespace Agenda_Consultorio_Odontologico.view.appointmentInterface
{
    public class AppointmentRegistrationInterface
    {
        private string _inputPatientCPF;
        private string _inputDate;
        private string _inputStart;
        private string _inputEnd;
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
            Console.WriteLine("Agendamento realizado com sucesso!\n");
        }
    }
}
