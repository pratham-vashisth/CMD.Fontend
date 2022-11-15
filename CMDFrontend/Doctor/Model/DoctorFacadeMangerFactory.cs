
using CMDFrontend.CustomException;
using ServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFrontend.Doctor.Model
{
    public class DoctorFacadeMangerFactory
    {
        private DoctorFacadeMangerFactory() { }

        private static DoctorFacadeMangerFactory managerFactory;

        public static DoctorFacadeMangerFactory GetManagerfactory()
        {
            if (managerFactory == null)
            {
                managerFactory = new DoctorFacadeMangerFactory();

            }

            return managerFactory;
        }


        public IDoctorServiceFacadeManager GetManager(string Manager)
        {
            Dictionary<string, IDoctorServiceFacadeManager> Dconn = new Dictionary<string, IDoctorServiceFacadeManager>();
           
            Dconn.Add("WcfManager", new WCFDoctorServiceManagerFacade());
           
            if (Dconn.ContainsKey(Manager))
            {
                return Dconn[Manager];
            }

            else throw new InvalidConnectionSelection("Please put doctor service Connection string");

            
        }

       



    }
}
