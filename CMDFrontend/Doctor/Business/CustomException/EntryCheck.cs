using CMDFrontend.Doctor.Model.Entity;
using CMDFrontend.Doctor.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFrontend.Doctor.Business.CustomException
{
    public class EntryCheck
    {
        public bool Validate(ServiceFacade.PatientService.Patient pat,string city,string state,string country)
        { 
            bool Valid=false;

            if (pat == null)
            {
                throw new InvalidNullEntryException("Please enter the data !");
            }
            else if (pat.Name.Equals(""))
            {
                throw new InvalidNullEntryException("Please enter the Name !");
            }
            else if (pat.BloodGroup.Equals(""))
            {
                throw new InvalidNullEntryException("Please enter the Blood group !");
            }
            else if (city.Equals("")||state.Equals("") ||country.Equals(""))
            {
                throw new InvalidNullEntryException("Please enter the city, State and Country ! ");
            }
            else if (pat.EmailId.Equals(""))
            {
                throw new InvalidNullEntryException("Please enter the EmailId !");
            }
            else 
                Valid=true;

            return Valid;
        }


        public bool Validate(ServiceFacade.DoctorService.Doctor doc,string state,string country)
        {
            bool Valid = false;

            if (doc == null)
            {
                throw new InvalidNullEntryException("Please enter the data");
            }
            else if (doc.Name.Equals(""))
            {
                throw new InvalidNullEntryException("Please enter the Name");
            }
            else if (doc.NpiNo.Equals(""))
            {
                throw new InvalidNullEntryException("Please enter the NPI No");
            }
            else if (state.Equals("") || country.Equals(""))
            {
                throw new InvalidNullEntryException("Please enter the State and Country ");
            }
            else if (doc.EmailId.Equals(""))
            {
                throw new InvalidNullEntryException("Please enter the email");
            }
            else
                Valid = true;

            return Valid;
        }
    }
}
