using CMDFrontend.Doctor.Model.Entity;
using CMDFrontend.Patient.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// Interaction logic for Step2.xaml
    /// </summary>
    public partial class Step2 : Window
    {
        DoctorEntity LoggedDoctor = null;
        PatientEnity patient = null;
        public Step2(DoctorEntity loggedDoctor,PatientEnity pat)
        {
            LoggedDoctor = loggedDoctor;
            patient = pat;
            InitializeComponent();
        }

        private void Step2Confirmation(object sender, RoutedEventArgs e)
        {
            Step3 step3 = new Step3(LoggedDoctor,IssueTextBox.Text,ReasonTextBox.Text,patient);  
            step3.Show();
            this.Close();
        }
    }
}
