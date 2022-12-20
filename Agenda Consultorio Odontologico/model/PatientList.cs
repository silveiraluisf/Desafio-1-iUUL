namespace Agenda_Consultorio_Odontologico.model
{
    public class PatientList
    {
        private List<Patient>? patients;

        public List<Patient> Patients 
        {
            get { return patients; }
            set { patients = value; }
        }
    }
}
