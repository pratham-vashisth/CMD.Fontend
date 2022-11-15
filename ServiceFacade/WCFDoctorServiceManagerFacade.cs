using ServiceFacade.DoctorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFacade
{
    public class WCFDoctorServiceManagerFacade : IDoctorServiceFacadeManager
    {

        DoctorServiceClient doc = new DoctorServiceClient();
        public bool Add(Doctor doctor)
        {
            return doc.AddDoctor(doctor) ;
        }

        public List<Doctor> GetAllDoctors()
        {

            List<Doctor> docs = new List<Doctor>();
            foreach (var d in doc.GetAllDoctors())
                docs.Add(d);

            return docs;
        }

        public Doctor GetByNpiNo(string npiNo)
        {
            return doc.GetDoctorByNpiNo(npiNo);
        }

        public bool Remove(string npiNo)
        {
            return doc.RemoveDoctor(npiNo);
        }

        public bool SignOut()
        {
            return doc.SignOut();
        }

        public bool Update(Doctor doctor, string npiNo)
        {
            return doc.UpdateDoctor(doctor,npiNo);
        }

        public bool Validate(string emailId, string password)
        {
            return doc.ValidateDoctor(emailId,password);
        }
        public Doctor GetDoctorByEmailid(String Emailid)
        {
            return doc.GetDoctorByEmailid(Emailid);
        }
    }
}
