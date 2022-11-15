//using CMDFrontend.ServiceFacade;
using CMDFrontend.Doctor.Business;
using CMDFrontend.Doctor.Business.CustomException;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
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
    /// Interaction logic for DocSignUp.xaml
    /// </summary>
    public partial class DocSignUp : Window
    {
        public DocSignUp()
        {
            SizeChanged += (o, e) =>
            {
                var r = SystemParameters.WorkArea;
                Left = r.Right - ActualWidth;
                Top = r.Bottom - ActualHeight;
            };
            InitializeComponent();
        }

       

        public void AddDoctor(object sender, RoutedEventArgs e)
        {
           
            DoctorBusiness business = new DoctorBusiness();
            PasswordCheck PCheck = new PasswordCheck();
            PhoneNumberCheck check = new PhoneNumberCheck();
            EntryCheck entry = new EntryCheck();
            ServiceFacade.DoctorService.Doctor doct = new ServiceFacade.DoctorService.Doctor();

            try
            {   
               
                string cpassword = DoctorConfirmPassword.Password.ToString();
                doct.Name = DoctorName.Text;
                doct.Password = DoctorPassword.Text;
                doct.PhoneNo = DoctorMobileNumber.Text;


                bool pass = PCheck.Validate(cpassword, doct.Password);
                // Exception throw if number is not acceptable
                bool valid = check.Validate(DoctorMobileNumber.Text);


                doct.NpiNo = DoctorNpiNumber.Text;
                doct.Gender = DoctorGender.Text.ToString();

                doct.PracticeLocation = $"{DoctorState.Text}"+" , " +$"{DoctorCountry.Text}";
                doct.Speciality = DoctorSpeciality.Text;
                doct.EmailId = DoctorEmail.Text;
                doct.Image = DocImageURL.Text;

                valid = entry.Validate(doct, DoctorState.Text, DoctorCountry.Text);
               
                if (pass && valid)
                {

                    if (business.AddDoctor(doct))
                    {

                        MessageBox.Show("Sign Up Successfull");
                    }
                    else
                    {
                        MessageBox.Show("error occured pls try again");
                    }
                }
                else this.Close();



            }
            catch(InvalidPhoneNumberException ex) 
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

        private void Image_check_CLick(object sender, RoutedEventArgs e)
        {
            Business.DoctorBusiness business = new DoctorBusiness();
            BitmapImage img= business.ImageConverter(DocImageURL.Text);
            docuploadimage.Source = img;
        }

        private void Exit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
