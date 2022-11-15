using CMDFrontend.Doctor.Model.Entity;
using CMDFrontend.Patient.Model.Entity;
using CMDFrontend.Patient.View;
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
    /// Interaction logic for Step1.xaml
    /// </summary>
    public partial class Step1 : Window
    {
        DoctorEntity  LoggedDoctor=null;
        Business.AppointmentBusiness business = new Business.AppointmentBusiness();
        public Step1(DoctorEntity loggedDoctor)
        {
            LoggedDoctor=loggedDoctor;
            InitializeComponent();
           
        }



        private void Step1ConfirmationButton(object sender, RoutedEventArgs e)
        {
            string email = PatientEmailText.Text;
            PatientEnity patient = business.CheckPatient(email);
            if (patient != null)
            {
                Step2 step2 = new Step2(LoggedDoctor,patient);
                step2.Show();
                this.Close();
            }
            else
            {
               string valid= MessageBox.Show("Patient not Found \n want to add new Patient\nClick ok to register new patient","confirm",MessageBoxButton.OKCancel).ToString();
               if(valid.Equals("OK"))
                {
                    this.Close();
                    PatientSignUpForm pat=new PatientSignUpForm();
                   
                    pat.Show();
                }
            }
        }
    }
}
