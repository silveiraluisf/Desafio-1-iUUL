using Agenda_Consultorio_Odontologico.controller.appointment;
using Agenda_Consultorio_Odontologico.controller.appointmentControllers;
using Agenda_Consultorio_Odontologico.view.appointmentInterface;

namespace Agenda_Consultorio_Odontologico.controller.appointmentController
{
    public class AppointmentMainController
    {
        CreateAppointmentController createAppointmentController = new();        
        DeleteAppointmentController deleteAppointmentController = new();
        AppointmentListMenuController almc = new();
        AppointmentMenu appointmentMenu = new();

        public void AddAppointment()
        {
            if (createAppointmentController.ValidateAppointment())
            {
                createAppointmentController.CreateAppointment();
                CreateAppointmentForm.SuccessMessage();
            }
                
            else
                appointmentMenu.Menu();
        }
        public void RemoveAppointment()
        {
            if (deleteAppointmentController.ValidateAppointment())
                deleteAppointmentController.RemoveAppointment();
        }

        public void PrintFullAppointmentList()
        {
            almc.OpenInterface();
        }
    }
}
