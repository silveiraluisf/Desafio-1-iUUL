namespace Agenda_Consultorio_Odontologico.view.patientInterface
{
    public class PatientDeleteInterface
    {
        private string _inputCPF;
        public string InputCPF
        {
            get { return _inputCPF; }
            set { _inputCPF = value; }
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
        public void ErrorMessage()
        {
            Console.WriteLine("O CPF não está cadastrado ou não foi digitado corretamente.");
        }
    }
}
