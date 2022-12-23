namespace Agenda_Consultorio_Odontologico.model
{
    public class Patient
    {
        private static List<Patient> _patientsList = new();
        public string Name { get; set; }
        public long CPF { get; set; }
        public int Age;
        public DateTime BirthDate { get; set; }
        public static List<Patient> PatientList { get { return _patientsList; } set { _patientsList = value; } }
        public Patient(string name, long cpf, DateTime birthDate)
        {
            Name = name;
            CPF = cpf;
            BirthDate = birthDate;
            Age = DateTime.Today.Year - BirthDate.Year;
            _patientsList.Add(this);
        }       
    }
}
