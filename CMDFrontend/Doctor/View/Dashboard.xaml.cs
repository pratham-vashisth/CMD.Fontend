using CMDFrontend.Appointment.Model.Entity;
using CMDFrontend.Appointment.View;
using CMDFrontend.Doctor.Business;
using CMDFrontend.Doctor.Model.Entity;
using CMDFrontend.Patient.Model.Business;
using CMDFrontend.Patient.Model.Entity;
using System;
using System.Collections.Generic;
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

namespace CMDFrontend.Doctor.View
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        DoctorBusiness Doc = new DoctorBusiness();

        DoctorEntity LoggedDoctor = null;

        public Dashboard(DoctorEntity loggedDoctor)
        {
            LoggedDoctor=loggedDoctor;
            InitializeComponent();
            
            AcceptedAppointmentsDash.Content = Doc.AcceptedAppointmentsBook(loggedDoctor.NpiNo);
            CancelledAppointmentsDash.Content = Doc.CancelledAppointmentsBook(loggedDoctor.NpiNo);
            TotalAppointmentsDash.Content = Doc.AllAppointmentsBooked(loggedDoctor.NpiNo);



            DocAllAppointmentList.Items.Clear();
            
            foreach (AppointmentData a in Doc.allAppointments(loggedDoctor.NpiNo).ToList())
            {
                AppointmentData data = new AppointmentData();
                data.PatientName = a.PatientName;
                data.PatImage = a.PatImage;
                data.Issue = a.Issue;
                data.AppTime=a.TimeSlot.Substring(10);
                data.AppDate = a.TimeSlot.Substring(0, 10);
                data.PatEmail = a.PatEmail;
                data.ReasonForVisit = a.ReasonForVisit;

                this.DataContext = data;
                DocAllAppointmentList.Items.Add(this.DataContext);

            }
        }

       

        private void dFeedBack(object sender, RoutedEventArgs e)
        {
            FeedbackForm feedbackForm = new FeedbackForm();
            feedbackForm.ShowDialog();
        }

        private void Appointment(object sender, RoutedEventArgs e)
        {
            Step1 step1 = new Step1(LoggedDoctor);
            step1.Show();
          
            
        }

        
    }
}
