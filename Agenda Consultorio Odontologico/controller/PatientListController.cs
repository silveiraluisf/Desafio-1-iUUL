using Agenda_Consultorio_Odontologico.model;
using System;

namespace Agenda_Consultorio_Odontologico.controller
{
    public class PatientListController
    {
        public void AddPatientToList(Patient patient, PatientList patientList)
        {
            if (patient.Name != null && patient.CPF != null && patient.BirthDate != null)
            {
                patientList.Patients?.Add(patient);
                Console.WriteLine("adicionou na lista");
            }
            else
            {
                //consolelog temporário para teste:
                Console.WriteLine("Você digitou alguma coisa errada no cadastro!");
                //estratégia de inserir erros
            }
        }
        public void RemovePatientFromList(Patient patient, PatientList patientList)
        {
            patientList.Patients.Remove(patient);
        }

        public void PrintPatientList(PatientList patientList)
        {
            for (int i = 0; i < patientList.Patients.Count; i++)
            {
                Patient patient = patientList.Patients[i];
                Console.WriteLine($"Nome: {patient.Name}");
                Console.WriteLine($"Nome: {patient.CPF}");
                Console.WriteLine($"Nome: {patient.BirthDate}");
            }
        }
    }
}
