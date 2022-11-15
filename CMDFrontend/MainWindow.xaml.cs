using CMDFrontend.Doctor.Business;
using CMDFrontend.Doctor.View;
using CMDFrontend.Patient.Model;
using CMDFrontend.Patient.Model.Business;
using CMDFrontend.Patient.View;
using ServiceFacade;
//using CMDFrontend.ServiceFacade;
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

namespace CMDFrontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DoctorLogIn(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text.Length!=0 && PasswordBox.Password.Length!=0)
            {
                DoctorBusiness doctor = new DoctorBusiness();
                bool valid = doctor.DoctorLogin(UsernameTextBox.Text, PasswordBox.Password.ToString());
                if (valid)
                {
                    this.Close();
                }
            }
            else MessageBox.Show("Enter the Username/Password");


        }

        private void PatientLogIn(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text.Length != 0 && PasswordBox.Password.Length != 0)
            {
                PatientBusiness patient = new PatientBusiness();
                bool valid = patient.PatientLogin(UsernameTextBox.Text, PasswordBox.Password.ToString());
                if (valid)
                {
                    this.Close();
                }
            }
            else MessageBox.Show("Enter the Username/Password");
        }

       

        private void pSignInButton(object sender, RoutedEventArgs e)
        {
            PatientSignUpForm patientSignUpForm = new PatientSignUpForm();
            patientSignUpForm.ShowDialog();
        }

        private void dSignInButton(object sender, RoutedEventArgs e)
        {
            DocSignUp docSignUp = new DocSignUp();
            docSignUp.ShowDialog();
        }

      
    }
}
