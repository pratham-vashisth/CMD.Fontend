//using CMDFrontend.ServiceFacade;
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

namespace CMDFrontend.Patient.View
{
    /// <summary>
    /// Interaction logic for AccountSetting.xaml
    /// </summary>
    public partial class AccountSetting : Page
    {
        PatientEnity Loggedpatient=null;
        public AccountSetting()
        {
            InitializeComponent();
        }
        public AccountSetting(PatientEnity LoggedPatient)
        {
            this.Loggedpatient = LoggedPatient; 

            InitializeComponent();

            NameTxtBx.Text = LoggedPatient.Name;
            PhoneTxtBx.Text = LoggedPatient.PhoneNumber;
            LocationTxtBx.Text   = LoggedPatient.Location;
            EmailTxtBx.Text = LoggedPatient.EmailId;
            BloodTxtBx.Text = LoggedPatient.BloodGroup;
            DoctorBusiness dbusiness = new DoctorBusiness();
            BitmapImage image=dbusiness.ImageConverter(LoggedPatient.Image);
            if (image != null)
                Patimage.ImageSource =image;


        }

        private void Edit_Button_click(object sender, RoutedEventArgs e)
        {

            string valid = MessageBox.Show("You are going to change the details check it carefully\n\t....confirm changes.... ", "Warning!", MessageBoxButton.OKCancel).ToString();
            if (valid.Equals("OK"))
            {
                PatientBusiness business = new PatientBusiness();
                PatientEnity pat = Loggedpatient;

                //pat.Name= NameTxtBx.Text;
                pat.PhoneNumber = PhoneTxtBx.Text;
                pat.Location = LocationTxtBx.Text;
                //pat.EmailId = EmailTxtBx.Text;
                pat.BloodGroup = BloodTxtBx.Text;

                if (business.UpdatePatient(pat))
                    MessageBox.Show("Profile Updated");
                else
                    MessageBox.Show("Error occured");
            }
        }   
    }
}
