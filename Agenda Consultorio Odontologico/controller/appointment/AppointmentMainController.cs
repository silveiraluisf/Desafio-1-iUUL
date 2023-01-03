using Agenda_Consultorio_Odontologico.controller.appointment;
using Agenda_Consultorio_Odontologico.controller.appointmentControllers;
using Agenda_Consultorio_Odontologico.model;
using Agenda_Consultorio_Odontologico.view.appointmentInterface;

namespace Agenda_Consultorio_Odontologico.controller.appointmentController
{
    public class AppointmentMainController
    {
        AppointmentValidatorController avc = new();
        AppointmentListInterface ali = new();
        AppointmentDeleteController adc = new();
        public void AddAppointment()
        {
            avc.AppointmentValidator();
        }
        public void RemoveAppointment()
        {
            adc.DeletePatient();
        }
        public void PrintFullAppointmentList()
        {
            ali.Title();
            ali.Header();
            foreach(Appointment appointment in Appointment.AppointmentList.OrderBy(x => x.Date))
            {
                ali.ShowAppointmentsList(appointment);
            }
            ali.Footer();
        }
    }
}
