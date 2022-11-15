using ServiceFacade;
using CMDFrontend.Patient.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CMDFrontend.Patient.Model.Entity;
using AutoMapper;
using ServiceFacade.PatientService;
using CMDFrontend.Appointment.Model;
using ServiceFacade.AppointmentService;
using CMDFrontend.Appointment.Model.Entity;
using CMDFrontend.Doctor.Model;
using CMDFrontend.Doctor.Model.Entity;
using System.ServiceModel.Channels;
using System.Windows;

namespace CMDFrontend.Patient.Model.Business
{
    public class PatientBusiness
    {
        public bool PatientLogin( string uname,string pass)
        {
            bool isLoggedin = false;
            
            PatientFacadeManagerFactory pfactory = PatientFacadeManagerFactory.GetManagerfactory();
            IPatientServiceFacadeManager patient = pfactory.GetManager("WcfManager");
            if (patient.Validate(uname,pass))
            {
                ServiceFacade.PatientService.Patient servicepatient= patient.GetById(uname);

                Mapper.CreateMap<ServiceFacade.PatientService.Patient,PatientEnity>();
                PatientEnity patientEntity = Mapper.Map<ServiceFacade.PatientService.Patient, PatientEnity>(servicepatient);

                if(patientEntity!=null)
                {
                  
                    Patient.View.HomePage phomePage = new Patient.View.HomePage(patientEntity);
                    phomePage.Show();
                    isLoggedin= true;
                }
               

               
            }
            else
            {
                MessageBox.Show("Invalid Username/Password");
            }
            return isLoggedin;

        }

        public List<DoctorEntity> allAppointments(string EmailId)
        {
            AppointmentFacadeManagerFactory afactory = AppointmentFacadeManagerFactory.GetManagerfactory();
            IAppointmentServiceFacadeManager appoint = afactory.GetManager("WcfManager");

            DoctorFacadeMangerFactory dfactory = DoctorFacadeMangerFactory.GetManagerfactory();
            IDoctorServiceFacadeManager Doc = dfactory.GetManager("WcfManager");


            List<DoctorEntity> doctors = new List<DoctorEntity>();
           List< AppointmentEntity> app = new List<AppointmentEntity>();

           
            
            foreach (var a in appoint.getAllForPatient(EmailId))
            {

                Mapper.CreateMap<ServiceFacade.DoctorService.Doctor, DoctorEntity>();
                DoctorEntity doctorEntity = Mapper.Map<ServiceFacade.DoctorService.Doctor, DoctorEntity>(Doc.GetByNpiNo(a.doctorId));
                //Mapper.CreateMap<AppointmentDTO, AppointmentEntity>();
                //AppointmentEntity Entity = Mapper.Map<AppointmentDTO, AppointmentEntity>(a);
                doctors.Add(doctorEntity);
            }
            return doctors;
        }


        public bool NewPatient(ServiceFacade.PatientService.Patient pat)
        {
            PatientFacadeManagerFactory pfactory = PatientFacadeManagerFactory.GetManagerfactory();
            IPatientServiceFacadeManager patient = pfactory.GetManager("WcfManager");

            if (patient.Add(pat))
                return true;
            
            return false;
        }

        public bool UpdatePatient(PatientEnity pat)
        {
            PatientFacadeManagerFactory pfactory = PatientFacadeManagerFactory.GetManagerfactory();
            IPatientServiceFacadeManager patient = pfactory.GetManager("WcfManager");


            Mapper.CreateMap<PatientEnity, ServiceFacade.PatientService.Patient>();
            ServiceFacade.PatientService.Patient ServicePatient = Mapper.Map<PatientEnity, ServiceFacade.PatientService.Patient>(pat);

            if (patient.Update(ServicePatient,pat.EmailId))
            {
                return true;
            }
            return false;
        }
    }
}
