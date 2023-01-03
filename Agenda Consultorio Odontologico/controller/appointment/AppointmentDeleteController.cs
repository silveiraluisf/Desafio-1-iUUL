using Agenda_Consultorio_Odontologico.model;
using Agenda_Consultorio_Odontologico.view.appointment;
using Agenda_Consultorio_Odontologico.view.appointmentInterface;
using System;

namespace Agenda_Consultorio_Odontologico.controller.appointment
{
    public class AppointmentDeleteController
    {
        AppointmentDeleteInterface adi = new();
        AppointmentMenuInterface ami = new();
        Appointment? appointment;
        bool hasConflit = false;
        public void DeletePatient()
        {
            adi.GetInformation();
            CheckDate();        
            CheckCPF();
            CheckAppointmentDateAndHour();
            if (!hasConflit)
            {
                Appointment.AppointmentList.Remove(appointment);
                adi.SuccessMessage();
            }
        }
        public void CheckDate()
        {
            bool parseSuccess = DateTime.TryParse(adi.InputDate, out DateTime outputDate);
            if (parseSuccess)
            {
                if (outputDate < DateTime.Today)
                {
                    adi.ErrorMessages(0);
                    hasConflit = true;
                }
                else if (outputDate == DateTime.Today) CheckHour(); 
            }
            else
            {
                adi.ErrorMessages(1);
                hasConflit = true;
            }
        }
        public void CheckHour()
        {
            bool parseSuccess = int.TryParse(adi.InputStart, out int outputStart);
            if (parseSuccess)
            {
                if(outputStart < DateTime.Today.Hour) 
                { 
                    adi.ErrorMessages(0);
                    hasConflit = true;
                }
            }
            else
            {
                adi.ErrorMessages(2);
                hasConflit = true;
            }
        }
        public void CheckCPF()
        {
            List<Appointment> list = new();
            bool parseSuccess = long.TryParse(adi.InputCPF, out long outputCPF);
            if (parseSuccess)
            {
                for (int i = 0; i < Appointment.AppointmentList.Count; i++)
                {
                    Appointment a = Appointment.AppointmentList[i];
                    if (a.Patient.CPF.Equals(outputCPF))
                    {
                        list.Add(a);
                    }
                }
                if (list.Count == 0)
                {
                    adi.ErrorMessages(3);
                    hasConflit = true;
                }
            }
        }
        public void CheckAppointmentDateAndHour()
        {
            bool parseSuccess = DateTime.TryParse(adi.InputDate, out DateTime outputDate);
            List<Appointment> list = new();
            if (parseSuccess)
            {
                for (int i = 0; i < Appointment.AppointmentList.Count; i++)
                {
                    Appointment a = Appointment.AppointmentList[i];
                    if (a.Date.Day == outputDate.Day)
                    {
                        if (a.Start.ToString("0000") == adi.InputStart)
                        {
                            list.Add(a);
                            appointment = a;
                        }
                    }
                }
                if (list.Count == 0)
                {
                    adi.ErrorMessages(4);
                    hasConflit = true;
                }
            }                
        }
    }
}
