using CMDFrontend.Doctor.Business;
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
using System.Windows.Shapes;

namespace CMDFrontend.Doctor.View
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public DoctorEntity LoggedDoctor { get; set; }
        public HomePage()
        {
            InitializeComponent();
        }
        public HomePage(DoctorEntity Doctor)
        {
            
            LoggedDoctor = Doctor;

            DoctorBusiness business = new DoctorBusiness();
            BitmapImage image= business.ImageConverter(Doctor.Image);

            InitializeComponent();

           LoggedDocName.Content = LoggedDoctor.Name;
            if (Doctor.Image != null)
                LoggedDocImage.ImageSource = image;

        }
        

        private void dDashboardExtend(object sender, MouseEventArgs e)
        {
            Maintab.Width = 150;
            homepage.Margin = new Thickness(150, 0, 0, 0);
        }

       

        private void dDashboardShrink(object sender, MouseEventArgs e)
        {
            Maintab.Width = 30;
            homepage.Margin = new Thickness(30, 0, 0, 0);
        }

        private void dLogOut(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void dDashboardButton(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard(LoggedDoctor);
            Dmain_frame.Navigate(new Dashboard(LoggedDoctor));
        }

        private void dPatientButton(object sender, RoutedEventArgs e)
        {
            Dmain_frame.Navigate(new Patient());
        }

        private void dSettingButton(object sender, RoutedEventArgs e)
        {
            Dmain_frame.Navigate(new AccountSetting(LoggedDoctor));
        }
    }
}
