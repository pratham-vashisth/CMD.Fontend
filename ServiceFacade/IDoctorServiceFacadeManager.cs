using ServiceFacade.DoctorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFacade
{
    public interface IDoctorServiceFacadeManager
    {
       
        bool Validate(String emailId, String password);

        
        bool Add(Doctor doctor); //at time of sign up


        List<Doctor> GetAllDoctors();

        Doctor GetByNpiNo(String npiNo);


        bool Update(Doctor doctor, String npiNo);


        bool Remove(String npiNo);


        bool SignOut();
        Doctor GetDoctorByEmailid(String Emailid);
    }
}
