using CMDFrontend.Doctor.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CMDFrontend.Doctor.Business.CustomException
{
    public class PhoneNumberCheck
    {
        public bool Validate( string c)
        {
            bool valid = false;
            if(c.Length < 10 || c.Length > 10  )
            {
                // MessageBox.Show("digits should be 10 ");
                throw new InvalidPhoneNumberException("digits in Phhone number should be 10 ");
                
            }
            else if(!c.All(char.IsDigit))
            {
                // MessageBox.Show("No character allowed enter Digits only");
                throw new InvalidPhoneNumberException("No character allowed in the PhoneNumber :\n ~Enter Digits only!");
            }
            else
                valid = true;
            return valid;
        }
    }
}
