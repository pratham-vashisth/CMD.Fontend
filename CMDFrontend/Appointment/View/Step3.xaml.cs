using CMDFrontend.Appointment.Model.Entity;
using CMDFrontend.Doctor.Model.Entity;
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

namespace CMDFrontend.Appointment.View
{
    /// <summary>
    /// Interaction logic for Step3.xaml
    /// </summary>
    public partial class Step3 : Window
    {
        DoctorEntity LoggedDoctor = null;
        PatientEnity patient=null;
        string PatIssue = null;
        string PatReason = null;
      
        string TimeSlot = null;

        public Step3(DoctorEntity loggedDoctor,string issue,string reason, PatientEnity pat)
        {
            LoggedDoctor = loggedDoctor;
            patient = pat;
            PatReason= reason;
            PatIssue = issue;

           
            InitializeComponent();
        }

        private void Step3ConfirmButton(object sender, RoutedEventArgs e)
        {
            string SelectedTime = TimeSelection();
            if (SelectedTime.Equals("notselected") != true && Mycalender.SelectedDate!=null)
            {
                TimeSlot = Mycalender.SelectedDate.ToString() + "," + SelectedTime;
               
                AppointmentConfirmation appointmentConfirmation = new AppointmentConfirmation(LoggedDoctor, PatIssue, PatReason, TimeSlot, patient);
                appointmentConfirmation.Show();
                 this.Close();

            }
            else MessageBox.Show("please choose the time and date.");

           
        }
        public string TimeSelection()
        {
            if(button_1100.IsChecked==true)
            { return "11:00"; }
            else if(button_1130.IsChecked==true)
            { return "11:30"; }
            else if(button_1200.IsChecked==true)
            { return "12:00"; }
            else if (button_1230.IsChecked == true)
            { return "12:30"; }
            else if (button_0200.IsChecked == true)
            { return "02:00"; }
            else if (button_0230.IsChecked == true)
            { return "02:30"; }
            else if (button_0300.IsChecked == true)
            { return "03:00"; }
            else if (button_0330.IsChecked == true)
            { return "03:30"; }
            else if (button_0400.IsChecked == true)
            { return "04:00"; }
            else if (button_0430.IsChecked == true)
            { return "04:30"; }
            else if (button_0530.IsChecked == true)
            { return "05:00"; }
            else 
            { return "notselected"; }

        }
    }
}
