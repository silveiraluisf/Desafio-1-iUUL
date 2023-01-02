using Agenda_Consultorio_Odontologico.model;
using Agenda_Consultorio_Odontologico.view.appointmentInterface;
using System;
using System.Collections.Generic;

namespace Agenda_Consultorio_Odontologico.controller.appointmentControllers
{
    public class AppointmentValidatorController
    {
        AppointmentRegistrationInterface ari = new();
        AppointmentMenuInterface ami = new();
        DateTime date;
        int start;
        int end;
        Patient patient;
        bool hasConflit = false;

        public void AppointmentValidator()
        {
            ari.GetPatientCPF();
            ari.GetDate();
            ari.GetStart();
            ari.GetEnd();
            ari.ShowData();
            PatientCPFValidate();
            DateValidate();
            StartValidate();
            EndValidate();
            CheckFutureAppointment();
            CheckOverlappingAppointment();
            if(!hasConflit) 
            { 
                Appointment a = new(date, start, end, patient);
                ari.SuccessMessage();
            }
            else
            {
                ami.AppointmentMenu();
            }
        }
        public void PatientCPFValidate()
        {
            List<Patient> list = new();
            bool parseSuccess = long.TryParse(ari.InputPatientCPF, out long outputCPF);
            if (parseSuccess)
            {
                for (int i = 0; i < Patient.PatientList.Count; i++)
                {
                    Patient p = Patient.PatientList[i];
                    if (p.CPF == outputCPF)
                    {
                        list.Add(p);
                        patient = p;
                    }
                }
                if (list.Count == 0)
                {
                    ari.ErrorMessages(0);
                    ari.GetPatientCPF();
                    PatientCPFValidate();
                }
            }
            else
            {
                ari.ErrorMessages(1); 
                ari.GetPatientCPF();
                PatientCPFValidate();
            }
        }
        public void DateValidate()
        {
            DateTime today = DateTime.Today;
            bool parseSuccess = DateTime.TryParse(ari.InputDate, out DateTime outputDate);
            if (parseSuccess)
            {
                if (outputDate >= today)
                {
                    date = outputDate;
                }
                else
                {
                    ari.ErrorMessages(2);
                    ari.GetDate();
                    DateValidate();
                }
            }
            else
            {
                ari.ErrorMessages(3);
                ari.GetDate();
                DateValidate();
            }
        }
        public void StartValidate()
        {
            if (ari.InputStart.Length > 0 && ari.InputStart.Length < 5)
            {
                bool parseSuccess = int.TryParse(ari.InputStart, out int outputStart);
                if (parseSuccess)
                {
                    if (outputStart > 0800 && outputStart < 1846)
                    {
                        start = outputStart;
                    }
                    else
                    {
                        ari.ErrorMessages(4);
                        ari.GetStart();
                        StartValidate();
                    }
                }
            }
            else
            {
                ari.ErrorMessages(5);
                ari.GetStart();
                StartValidate();
            }            
        }
        public void EndValidate()
        {
            if (ari.InputEnd.Length > 0 && ari.InputEnd.Length < 5)
            {
                bool parseSuccess = int.TryParse(ari.InputEnd, out int outputEnd);
                if (parseSuccess)
                {
                    if (outputEnd > start)
                    {
                        if (outputEnd > 0815 && outputEnd < 1901)
                        {
                            end = outputEnd;
                        }
                        else
                        {
                            ari.ErrorMessages(6);
                            ari.GetEnd();
                            EndValidate();                           
                        }
                    }
                    else
                    {
                        ari.ErrorMessages(7);
                        ari.GetEnd();
                        EndValidate();                       
                    }
                }
            }
            else 
            {
                ari.ErrorMessages(8);
                ari.GetEnd();
                EndValidate();
            }
        }
        public void CheckFutureAppointment()
        {
            for (int i = 0; i < Appointment.AppointmentList.Count; i++)
            {
                Appointment appointment = Appointment.AppointmentList[i];
                if (DateTime.Today.Day < appointment.Date.Day)
                {
                    if(appointment.Patient == patient)
                    {
                        ari.ErrorMessages(9);
                        hasConflit = true;
                        break;
                    }
                }
            }
        }
        public void CheckOverlappingAppointment()
        {
            for (int i = 0; i < Appointment.AppointmentList.Count; i++)
            {
                Appointment appointment = Appointment.AppointmentList[i];
                if (appointment.Date.Year == date.Year && appointment.Date.Month == date.Month && appointment.Date.Day == date.Day)
                {
                    if ((start >= appointment.Start && start < appointment.End) || (end > appointment.Start && end <= appointment.End))
                    {
                        ari.ErrorMessages(10);
                        hasConflit = true;
                        break;
                    }
                }                     
            }
        }
    }
}
