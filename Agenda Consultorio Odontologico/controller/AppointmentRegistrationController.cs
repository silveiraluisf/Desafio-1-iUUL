using Agenda_Consultorio_Odontologico.model;
using Agenda_Consultorio_Odontologico.view;

namespace Agenda_Consultorio_Odontologico.controller
{
    public class AppointmentRegistrationController
    {
        public void AddAppointment(AppointmentRegistrationInterface a)
        {
            a.GetPatientCPF();
            a.GetDate();
            a.GetStart();
            a.GetEnd();
            a.ShowData();
        }
        public void RemoveAppointment(AppointmentRegistrationInterface a)
        {
            //to do
        }
        public void PatientCPFValidate(AppointmentRegistrationInterface a, Appointment r)
        {
            //to do
        }
        public void DateValidate(AppointmentRegistrationInterface a, Appointment r)
        {
            //to do
        }
        public void StartValidate(AppointmentRegistrationInterface a, Appointment r)
        {
            //to do
        }
        public void EndValidate(AppointmentRegistrationInterface a, Appointment r)
        {
            //to do
        }
    }
}
