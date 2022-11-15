using CMDFrontend.Doctor.Business;
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
using System.Windows.Shapes;

namespace CMDFrontend.Patient.View
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public  PatientEnity LoggedPatient { get; set; }

       
         void initlize(PatientEnity patient)
         {
            LoggedPatient=patient;
         }
        public HomePage()
        {
            InitializeComponent();
        }
        public HomePage(PatientEnity patient)
        {
            initlize(patient);


            DoctorBusiness business = new DoctorBusiness();
            BitmapImage image = business.ImageConverter(LoggedPatient.Image);
            
           
            InitializeComponent();
           
            LoggedUsername.Content = LoggedPatient.Name;
            if(patient.Image != null)
            LoggedUserImage.ImageSource = image;
           
        }

        private void pDashboardExtend(object sender, MouseEventArgs e)
        {
            Maintab.Width = 150;
            homepage.Margin = new Thickness(150, 0, 0, 0);
        }

        private void pdashboardShrink(object sender, MouseEventArgs e)
        {
            Maintab.Width = 30;
            homepage.Margin = new Thickness(30, 0, 0, 0);
        }

        private void pLogOut(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void pDashboardButton(object sender, RoutedEventArgs e)
        {
            Pmain_frame.Navigate(new Dashboard(LoggedPatient));
        }

        private void pSetting(object sender, RoutedEventArgs e)
        {
           Pmain_frame.Navigate(new AccountSetting(LoggedPatient));
        }

        private void MenupLogOut(object sender, RoutedEventArgs e)
        {

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
