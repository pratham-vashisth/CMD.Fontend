using ServiceFacade.PatientService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFacade
{
    public interface IPatientServiceFacadeManager
    {
        
        bool Add(Patient patient);

       
        List<Patient> GetAllPatients();

       
        Patient GetById(String emailId);

        
        bool Update(Patient patient, String id);

        
        bool Remove(String emailId);
        
        bool Validate(String emailId, String password);
    }
}
