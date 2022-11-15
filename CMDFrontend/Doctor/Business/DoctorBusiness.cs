using AutoMapper;
using CMDFrontend.Appointment.Model.Entity;
using CMDFrontend.Appointment.Model;
using CMDFrontend.Doctor.Model;
using CMDFrontend.Doctor.Model.Entity;
using CMDFrontend.Patient.Model.Entity;
using ServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using CMDFrontend.Patient.Model;
using ServiceFacade.DoctorService;
using System.Security.Cryptography;
using System.Windows.Controls;
using CMDFrontend.Patient.Model.Business;

namespace CMDFrontend.Doctor.Business
{
    public class DoctorBusiness
    {
        public  bool AddDoctor(ServiceFacade.DoctorService.Doctor doc)
        {

            DoctorFacadeMangerFactory factory = DoctorFacadeMangerFactory.GetManagerfactory();
            IDoctorServiceFacadeManager doctor = factory.GetManager("WcfManager");
            if (doctor.Add(doc))
            { return true; }
            else { return false; }
        }

        public List<AppointmentData> allAppointments(string NpiNo)
        {
            AppointmentFacadeManagerFactory afactory = AppointmentFacadeManagerFactory.GetManagerfactory();
            IAppointmentServiceFacadeManager appoint = afactory.GetManager("WcfManager");

            PatientFacadeManagerFactory pfactory = PatientFacadeManagerFactory.GetManagerfactory();
            IPatientServiceFacadeManager pat = pfactory.GetManager("WcfManager");


            List<PatientEnity> patients = new List<PatientEnity>();
            List<AppointmentEntity> app = new List<AppointmentEntity>();
            List<AppointmentData> data = new List<AppointmentData>();


            foreach (var a in appoint.getAllForDoctor(NpiNo))
            {

                Mapper.CreateMap<ServiceFacade.PatientService.Patient, PatientEnity>();
                PatientEnity patientEntity = Mapper.Map<ServiceFacade.PatientService.Patient, PatientEnity>(pat.GetById(a.patientId));
                AppointmentData da = new AppointmentData();
                da.PatientName = patientEntity.Name;
                da.PatImage = ImageConverter(patientEntity.Image);
                da.Issue = a.Issue;
                da.TimeSlot = a.TimeSlot;
                da.ReasonForVisit = a.ReasonForVisit;
                da.Appointment_status = a.Appointment_status;
                da.PatEmail = patientEntity.EmailId;
                data.Add(da);
               // patients.Add(patientEntity);

            }
            return data;
        }



        public string AllAppointmentsBooked( string NpiNo)
        {
            AppointmentFacadeManagerFactory afactory = AppointmentFacadeManagerFactory.GetManagerfactory();
            IAppointmentServiceFacadeManager appoint = afactory.GetManager("WcfManager");
            string number = appoint.getAllForDoctor(NpiNo).Count().ToString();
            return number;
        }

        public string AcceptedAppointmentsBook(string NpiNo)
        {
            AppointmentFacadeManagerFactory afactory = AppointmentFacadeManagerFactory.GetManagerfactory();
            IAppointmentServiceFacadeManager appoint = afactory.GetManager("WcfManager");
            string number = appoint.getAllAccToStatus("active").GroupBy(a => a.doctorId.Equals(NpiNo)).Count().ToString();
            return number;
        }

        public string CancelledAppointmentsBook(string NpiNo)
        {
            AppointmentFacadeManagerFactory afactory = AppointmentFacadeManagerFactory.GetManagerfactory();
            IAppointmentServiceFacadeManager appoint = afactory.GetManager("WcfManager");
            string number = appoint.getAllAccToStatus("cancel").GroupBy(a=>a.doctorId.Equals(NpiNo)).Count().ToString();
            return number;
        }


        public bool DoctorLogin(string uname, string pass)
        { bool valid = false;
            DoctorFacadeMangerFactory factory = DoctorFacadeMangerFactory.GetManagerfactory();
            IDoctorServiceFacadeManager doctor = factory.GetManager("WcfManager");

            if (doctor.Validate(uname, pass))
            {
                ServiceFacade.DoctorService.Doctor serviceDoctor = doctor.GetDoctorByEmailid(uname);

                Mapper.CreateMap<ServiceFacade.DoctorService.Doctor, DoctorEntity>();
                DoctorEntity doctorEntity = Mapper.Map<ServiceFacade.DoctorService.Doctor, DoctorEntity>(serviceDoctor);

                if (doctorEntity != null && doctorEntity.EmailId.Length!=0)
                {
                    Doctor.View.HomePage phomePage = new Doctor.View.HomePage(doctorEntity);

                    phomePage.Show();
                    valid = true;
                }

            }
            else
            {
                MessageBox.Show("Wrong Username or password");
            }

            return valid;
        }

        public BitmapImage ImageConverter(string url)
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();

            if (Uri.IsWellFormedUriString(url, UriKind.Relative))
            {
                image.UriSource = new Uri(url, UriKind.Relative);
                image.EndInit();
                return image;
            }
            else if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                image.UriSource = new Uri(url, UriKind.Absolute);
                image.EndInit();
                return image;
            }
            return null;
        }


        public bool UpdateDoctor(DoctorEntity doc)
        {
            DoctorFacadeMangerFactory factory = DoctorFacadeMangerFactory.GetManagerfactory();
            IDoctorServiceFacadeManager doctor = factory.GetManager("WcfManager");
                
            Mapper.CreateMap< DoctorEntity, ServiceFacade.DoctorService.Doctor>();               
            ServiceFacade.DoctorService.Doctor ServiceDoctor = Mapper.Map<DoctorEntity, ServiceFacade.DoctorService.Doctor>(doc);
               
            if(doctor.Update(ServiceDoctor,ServiceDoctor.NpiNo))
            {
                return true;
            }
            return false;
        }

       public List<PatientEnity> AllPatients()
        {
            List<PatientEnity> patients = new List<PatientEnity>();
            PatientFacadeManagerFactory pfactory = PatientFacadeManagerFactory.GetManagerfactory();
            IPatientServiceFacadeManager pat = pfactory.GetManager("WcfManager");

            foreach (var a in pat.GetAllPatients() )
            {

                Mapper.CreateMap<ServiceFacade.PatientService.Patient, PatientEnity>();
                PatientEnity patientEntity = Mapper.Map<ServiceFacade.PatientService.Patient, PatientEnity>(a);
                patients.Add(patientEntity);
            }
            return patients;
        }
        
    }
}
