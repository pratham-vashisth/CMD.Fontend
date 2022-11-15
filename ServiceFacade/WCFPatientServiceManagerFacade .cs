using ServiceFacade.DoctorService;
using ServiceFacade.PatientService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ServiceFacade
{
    public class WCFPatientServiceManagerFacade : IPatientServiceFacadeManager
    {
        PatientServiceClient PatientService = new PatientServiceClient();
        public bool Add(Patient patient)
        {
            return PatientService.AddPatient(patient);
        }

        public List<Patient> GetAllPatients()
        {

            List<Patient> pats = new List<Patient>();
            foreach (var p in PatientService.GetAllPatients())
                pats.Add(p);

            return pats;
        }

        public Patient GetById(string emailId)
        {
            return PatientService.GetPatientById(emailId);
        }

        public bool Remove(string emailId)
        {
            return PatientService.RemovePatient(emailId);
        }

        public bool Update(Patient patient, string id)
        {
            return PatientService.UpdatePatient(patient,id);
        }

        public bool Validate(string emailId, string password)
        {
            return PatientService.ValidatePatient(emailId, password);
        }
    }
}
