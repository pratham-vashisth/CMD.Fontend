using CMDFrontend.Appointment.Business;
using CMDFrontend.Appointment.Model.Entity;
using CMDFrontend.Appointment.View;
using CMDFrontend.Doctor.Business;
using CMDFrontend.Doctor.Model.Entity;
using CMDFrontend.Patient.Model.Business;
using CMDFrontend.Patient.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CMDFrontend.Appointment.View
{
    /// <summary>
    /// Interaction logic for AppointmentConfirmation.xaml
    /// </summary>
    public partial class AppointmentConfirmation : Window
    {
        public AppointmentConfirmation(DoctorEntity loggedDoctor, string issue, string reason,string Timeslot, PatientEnity pat)
        {
            AppointmentBusiness business = new AppointmentBusiness();

            AppointmentData appointmentcontext = new AppointmentData();
            DoctorBusiness img = new DoctorBusiness();
            BitmapImage DocImg=  img.ImageConverter(loggedDoctor.Image);
            BitmapImage PatImg = img.ImageConverter(pat.Image);
           
            
            InitializeComponent();
            string datetime = Timeslot.Substring(0, 10) + " " + Timeslot.Substring(20);
            Timeslot = datetime;

            appointmentcontext.Appointment_status = "Pending";
            appointmentcontext.DocImage = DocImg;
            appointmentcontext.PatImage = PatImg;
            appointmentcontext.PatientName = pat.Name;
            appointmentcontext.DoctorName= loggedDoctor.Name;
            appointmentcontext.Issue = issue;
            appointmentcontext.ReasonForVisit = reason;
            appointmentcontext.TimeSlot= Timeslot;
            appointmentcontext.Speciality = loggedDoctor.Speciality;

            this.DataContext = appointmentcontext;
            AppointmentConfirmation1.Items.Clear();
            AppointmentConfirmation1.Items.Add(this.DataContext);

            if (business.AddAppointment(pat.EmailId, loggedDoctor.NpiNo, issue, Timeslot, reason))
            {
                MessageBox.Show("Successfully added");
            }
            else
                MessageBox.Show("Error occured! try again");
            
            
        }

        private void Exit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //Doctor.View.HomePage homePage = new Doctor.View.HomePage();
            //homePage.Show();
        }
    }
}
