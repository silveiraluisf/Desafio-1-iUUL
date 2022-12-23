using Agenda_Consultorio_Odontologico.controller.appointmentControllers;
using Agenda_Consultorio_Odontologico.model;
using Agenda_Consultorio_Odontologico.view.appointmentInterface;

namespace Agenda_Consultorio_Odontologico.controller.appointmentController
{
    public class AppointmentMainController
    {
        AppointmentValidatorController avc = new();
        AppointmentListInterface ali = new();
        public void AddAppointment()
        {
            avc.AppointmentValidator();
        }
        public void RemoveAppointment()
        {
            //to do
        }
        public void PrintFullAppointmentList()
        {
            foreach(Appointment appointment in Appointment.AppointmentList.OrderBy(x => x.Date))
            {
                ali.ShowAppointmentsList(appointment);
            }
        }
    }
}
