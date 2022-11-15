using CMDFrontend.Doctor.Business;
using CMDFrontend.Doctor.Business.CustomException;
using CMDFrontend.Doctor.View;
using CMDFrontend.Patient.Model.Business;
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
    /// Interaction logic for PatientSignUpForm.xaml
    /// </summary>
    public partial class PatientSignUpForm : Window
    {
        public PatientSignUpForm()
        {

            SizeChanged += (o, e) =>
            {
                var r = SystemParameters.WorkArea;
                Left = r.Right - ActualWidth;
                Top = r.Bottom - ActualHeight;
            };
            InitializeComponent();
        }

      

        private void AddPatient(object sender, RoutedEventArgs e)
        {
            ServiceFacade.PatientService.Patient pat = new ServiceFacade.PatientService.Patient();

            PasswordCheck PCheck = new PasswordCheck();
            PhoneNumberCheck check = new PhoneNumberCheck();
            EntryCheck entry = new EntryCheck();

            try
            {
                bool pass = check.Validate(PatientMobileNumber.Text);
                bool valid = PCheck.Validate(PatientPassword.Text, PatientConfirmPassword.Password.ToString());

                pat.Name = PatientName.Text;
                pat.Gender = PatientGender.Text;
                pat.Location = $"{PatientCity.Text}" + "," + $"{PatientState.Text}" + "," + $"{PatientCountry.Text}";
                pat.BloodGroup = PatientBloodGroup.Text;
                pat.Password = PatientPassword.Text;
                pat.EmailId = PatientEmail.Text;
                pat.Image = PatientImageTB.Text;
                pat.PhoneNumber = PatientMobileNumber.Text;

                valid = entry.Validate(pat, PatientCity.Text, PatientState.Text, PatientCountry.Text);

                if (pass && valid)
                {
                    PatientBusiness business = new PatientBusiness();
                    if (business.NewPatient(pat))
                    {
                        this.Close();
                        MessageBox.Show("Sign Up Successfull");
                    }

                    else MessageBox.Show("Error occured");
                }
                else
                {
                    this.Close();
                }

            }
            catch (InvalidPhoneNumberException ex)
            {
                MessageBox.Show(ex.Message);
                // this.Close();
            }
            catch (InvalidPasswordNotMatchException ex)
            {
                MessageBox.Show(ex.Message);
                // this.Close();
            }
            catch (InvalidNullEntryException ex)
            {
                MessageBox.Show(ex.Message);
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // this.Close();
            }



        }

        private void checkpatimagebutton_Click(object sender, RoutedEventArgs e)
        {
            Doctor.Business.DoctorBusiness business = new DoctorBusiness();
            BitmapImage img = business.ImageConverter(PatientImageTB.Text);
            patuploadimage.Source = img;
        }
        private void Exit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
