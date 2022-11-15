using CMDFrontend.CustomException;
using ServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMDFrontend.Patient.Model
{
    public class PatientFacadeManagerFactory
    {


                
       
            private PatientFacadeManagerFactory() { }

            private static PatientFacadeManagerFactory managerFactory;

            public static PatientFacadeManagerFactory GetManagerfactory()
            {
            

                if (managerFactory == null)
                {
                    managerFactory = new PatientFacadeManagerFactory();

                }

                return managerFactory;
            }


            public IPatientServiceFacadeManager GetManager(string Manager)
            {
               Dictionary<string, IPatientServiceFacadeManager> conn = new Dictionary<string, IPatientServiceFacadeManager>();

               conn.Add("WcfManager",new WCFPatientServiceManagerFacade());

                if (conn.ContainsKey(Manager))
                {

                    return conn[Manager];
                }

      
                else throw new InvalidConnectionSelection("Please put right PatientService connection key");
            }





        

    }
}
