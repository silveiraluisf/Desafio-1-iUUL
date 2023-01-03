namespace Agenda_Consultorio_Odontologico.model
{
    public class Appointment
    {
        private static List<Appointment> _appointmentList = new();
        public DateTime Date { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public Patient Patient { get; set; }
        public int Time;
        public static List<Appointment> AppointmentList { get { return _appointmentList; } set { _appointmentList = value; } }
        public Appointment(DateTime date, int start, int end, Patient patient)
        {
            Date = date;
            Start = start;
            End = end;
            Patient = patient;
            Time = End - Start ;
            _appointmentList.Add(this);
        }
    }
}
