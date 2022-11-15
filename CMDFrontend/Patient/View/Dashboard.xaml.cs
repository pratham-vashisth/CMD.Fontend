using CMDFrontend.Doctor.Model.Entity;
using CMDFrontend.Doctor.View;
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

namespace CMDFrontend.Patient.View
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        PatientBusiness pat = new PatientBusiness();
        public Dashboard(PatientEnity LoggedPatient)
        {
            InitializeComponent();
           

            Patientappointments.Items.Clear();
            foreach (DoctorEntity a in pat.allAppointments(LoggedPatient.EmailId).ToList())
            {
                this.DataContext = a;
                Patientappointments.Items.Add(this.DataContext);
                
            }


        }

        private void pFeedBackButton(object sender, RoutedEventArgs e)
        {
            Feedback feedback = new Feedback();
            feedback.ShowDialog();
        }
    }
}
