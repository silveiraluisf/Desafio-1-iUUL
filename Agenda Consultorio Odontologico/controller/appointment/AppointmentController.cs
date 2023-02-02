using Agenda_Consultorio_Odontologico.controller.appointment;
using Agenda_Consultorio_Odontologico.controller.appointmentControllers;
using Agenda_Consultorio_Odontologico.view.appointment;
using Agenda_Consultorio_Odontologico.view.appointmentInterface;

namespace Agenda_Consultorio_Odontologico.controller.appointmentController
{
    public class AppointmentController
    {
        CreateAppointmentController createAppointmentController = new();        
        DeleteAppointmentController deleteAppointmentController = new();
        AppointmentMenu appointmentMenu = new();

        public void CreateAppointment()
        {
            if (createAppointmentController.ValidateAppointment())
            {
                createAppointmentController.CreateAppointment();
                AppointmentForm.SuccessMessage();
            }
                
            else
                appointmentMenu.Menu();
        }
        public void RemoveAppointment()
        {
            if (deleteAppointmentController.ValidateAppointment())
            {
                deleteAppointmentController.RemoveAppointment();
                DeleteAppointmentForm.SuccessMessage();
            }
        }

        public void PrintFullAppointmentList()
        {
            AppointmentsMenuController almc = new();
            almc.OpenInterface();
        }
    }
}
