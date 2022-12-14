namespace Agenda_Consultorio_Odontologico.model
{
    public class Appointment
    {
        private DateTime _Date;
        private int _start;
        private int _end;
        private Patient _patient;
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        public int Start
        {
            get { return _start; }
            set { _start = value; }
        }
        public int End
        { 
            get { return _end; } 
            set { _end = value; } 
        }
        public Patient Patient { 
            get { return this._patient; }
        }
    }    
}
