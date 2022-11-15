using CMDFrontend.Doctor.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace CMDFrontend.Doctor.Business.CustomException
{
    public class PasswordCheck
    { 
        public bool Validate(string p1,string p2)
        {
            bool check = false;

            if (!p1.Equals(p2))
            {
                //MessageBox.Show("Password Not Match ! Please try again");
                throw new InvalidPasswordNotMatchException("Password Not Match : Please try again !");
                
            }
            else if (p1.Length <= 6 || p1.Equals(""))
            {
                //MessageBox.Show("Password Too Short");
                throw new InvalidPasswordNotMatchException("Password Too Short : try again !\n Length should be 6> ");


            }
            else
                check = true;

            return check;
        }
    }
}
