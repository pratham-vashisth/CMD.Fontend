using CMDFrontend.Appointment.Model;
using CMDFrontend.Doctor.Model;
using CMDFrontend.Patient.Model;
using ServiceFacade;
using ServiceFacade.AppointmentService;
using ServiceFacade.DoctorService;
using ServiceFacade.PatientService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoctorFacadeMangerFactory factory = DoctorFacadeMangerFactory.GetManagerfactory();
            IDoctorServiceFacadeManager doctor = factory.GetManager("WcfManager");
           
            //List<Doctor> availdoc = doctor.GetAllDoctors();
            //foreach(var d in availdoc)
            //{
            //    Console.WriteLine(d);
            //}

            //Doctor doct = new Doctor();
            //doct.Name = "Pratham";
            //doct.PhoneNo = "13246549";
            //doct.NpiNo = "12354565";
            //doct.Gender = "male";
            //doct.Password = "ooolaalaa";
            //doct.PracticeLocation = "Bangalore kundalahalli";
            //doct.Speciality = "heart";
            //doct.EmailId = "prthm@gmail.com";
          
            //Console.WriteLine(doctor.Add(doct)+"\n\n press any key to proceed further to add patient");
            //Console.Read();

            PatientFacadeManagerFactory pfactory = PatientFacadeManagerFactory.GetManagerfactory();
            IPatientServiceFacadeManager patient= pfactory.GetManager("WcfManager");

            //List<Patient> availpat = patient.GetAllPatients();
            //foreach (var p in availpat)
            //{
            //    Console.WriteLine(p);
            //}


            Patient pat = new Patient();
            pat.Name = "prthm";
            pat.Gender = "male";
            pat.Location = "Ajmer";
            pat.BloodGroup = "B+";
            pat.Password = "jaishreeram";
            pat.EmailId = "mydogcheeku@gmail.com";
            pat.PhoneNumber = "13246579";
            Console.WriteLine(patient.Add(pat) + "\n\n press any key to proceed further to add patient");
            //Console.Read();

            AppointmentFacadeManagerFactory aFactory =AppointmentFacadeManagerFactory.GetManagerfactory();
            IAppointmentServiceFacadeManager Appointment = aFactory.GetManager("WcfManager");
            
           
            //foreach (var d in Appointment.getAllForDoctor(2))
            //{
            //    Console.WriteLine(d.Appointment_status + d.ReasonForVisit + d.patientId + d.doctorId + d.Issue);
            //}


            //AppointmentDTO app = new AppointmentDTO();
            //app.Appointment_status = "Pending";
            //app.Issue = "brain";
            //app.patientId = 1;
            //app.doctorId = 2;
            //app.ReasonForVisit = "checkup";
            //app.TimeSlot = "12/12/2022";
            //Console.WriteLine(Appointment.Add(app));



        }

    }
}
