namespace Agenda_Consultorio_Odontologico.model
{
    public class Patient
    {
        private string _name;
        private long _cpf;
        private DateTime _bornDate;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public long CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        public DateTime BirthDate
        {
            get { return _bornDate; }
            set { _bornDate = value; }
        }
    }
}
