using AutoMapper;
using CMDFrontend.Appointment.Model;
using CMDFrontend.Patient.Model;
using CMDFrontend.Patient.Model.Entity;
using ServiceFacade;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFrontend.Appointment.Business
{
    public class AppointmentBusiness
    {

        public PatientEnity CheckPatient(string Emailid)
        {
            PatientFacadeManagerFactory pfactory = PatientFacadeManagerFactory.GetManagerfactory();
            IPatientServiceFacadeManager patient = pfactory.GetManager("WcfManager");
           
            
            Mapper.CreateMap<ServiceFacade.PatientService.Patient, PatientEnity>();
            PatientEnity patientEntity = Mapper.Map<ServiceFacade.PatientService.Patient, PatientEnity>(patient.GetById(Emailid));


            if (patientEntity != null)
            { return patientEntity; }
            else return null;

        }

        public bool AddAppointment(string patEmail,string DocNpi,string Issue,string TimeSlot,string Reason )
        {


            AppointmentFacadeManagerFactory afactory = AppointmentFacadeManagerFactory.GetManagerfactory();
            IAppointmentServiceFacadeManager Appointment = afactory.GetManager("WcfManager");

            ServiceFacade.AppointmentService.AppointmentDTO appointment = new ServiceFacade.AppointmentService.AppointmentDTO();
            appointment.patientId = patEmail;
            appointment.doctorId = DocNpi;
            appointment.Issue = Issue;
            appointment.TimeSlot = TimeSlot;
            appointment.ReasonForVisit = Reason;
            appointment.Appointment_status = "pending";

            if(Appointment.Add(appointment))
            { return true; }
            else
            return false;
        }
    }
}
