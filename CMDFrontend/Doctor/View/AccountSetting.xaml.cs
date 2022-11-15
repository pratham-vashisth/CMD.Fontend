//using CMDFrontend.ServiceFacade;
using CMDFrontend.Doctor.Business;
using CMDFrontend.Doctor.Model.Entity;
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
    /// Interaction logic for AccountSetting.xaml
    /// </summary>
    public partial class AccountSetting : Page
    {
        public DoctorEntity loggeddoc = new DoctorEntity() ;
        public AccountSetting()
        {
            InitializeComponent();
        }

        public AccountSetting(DoctorEntity doc)
        {
            loggeddoc = doc;
            InitializeComponent();

            DocName.Text = loggeddoc.Name;
            DocEmail.Text = loggeddoc.EmailId;
            DocLocation.Text = loggeddoc.PracticeLocation;
            DocNpiNumber.Text = loggeddoc.NpiNo;
            DocMobileNumber.Text = loggeddoc.PhoneNo;
            DocSpecialist.Text = loggeddoc.Speciality;
            
            DoctorBusiness business = new DoctorBusiness();
            BitmapImage image = business.ImageConverter(loggeddoc.Image);
           if(image!=null)
            DocUImage.ImageSource = image;

        }

        private void Edit_Button_Click(object sender, RoutedEventArgs e)
        {
           string valid= MessageBox.Show("You are going to change the details check it carefully\n\t....confirm changes.... ", "Warning!",MessageBoxButton.OKCancel).ToString();
            if ( valid.Equals("OK"))
            {
                DoctorBusiness business = new DoctorBusiness();
                DoctorEntity doc = loggeddoc;

                doc.Name= DocName.Text.ToString() ;
                doc.EmailId = DocEmail.Text.ToString();
                doc.PracticeLocation= DocLocation.Text.ToString();  
                doc.PhoneNo= DocMobileNumber.Text.ToString();
                doc.Speciality= DocSpecialist.Text.ToString();

                if(business.UpdateDoctor(doc))
                    MessageBox.Show("Profile Updated");
                else
                    MessageBox.Show("Error occured");
            }
          
            
        }
    }
}
