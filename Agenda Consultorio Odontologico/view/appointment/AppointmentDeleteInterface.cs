using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Consultorio_Odontologico.view.appointment
{
    public class AppointmentDeleteInterface
    {
        private string _inputCPF;
        private string _inputDate;
        private string _inputStart;
        private List<string> _errorList;
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
        public string InputStart
        {
            get { return _inputStart; }
            set { _inputStart = value; }
        }
        public List<string> ErrorList
        {
            get { return _errorList; }
            set { _errorList = value; }
        }
        public void Title()
        {
            Console.WriteLine("Remoção de agendamento \n");
        }
        public void GetInformation()
        {
            Console.WriteLine("Insira o CPF do paciente que desejas cancelar o agendamento: ");
            _inputCPF = Console.ReadLine();
            Console.WriteLine("Insira a data do agendamento que desejas cancelar: ");
            _inputDate = Console.ReadLine();
            Console.WriteLine("Insira a hora inicial do agendamento que desejas cancelar: ");
            _inputStart = Console.ReadLine();

        }
        public void SuccessMessage()
        {
            Console.WriteLine("Agendamento removido com sucesso!\n");
        }
        public void ErrorMessages(int n)
        {
            this._errorList = new List<string>
            {
                $"Erro na data: {_inputDate} -> Não é possível cancelar um agendamento passado.",
                $"Erro na data: {_inputDate} -> Digite a data no formato válido (DD/MM/AAAA).",
                $"Erro na hora: {_inputStart} -> Digite a hora no formato válido (HHMM).",
                $"Erro no CPF: {_inputCPF} -> CPF não cadastrado ou incorreto.",
                "Não há agendamentos para o paciente/dia/hora informados!",
            };
            Console.WriteLine($"{ErrorList[n]}");
        }
    }
}
