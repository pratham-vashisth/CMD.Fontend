using CMDFrontend.CustomException;
using CMDFrontend.Patient.Model;
using ServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFrontend.Appointment.Model
{
    public class AppointmentFacadeManagerFactory
    {

        private AppointmentFacadeManagerFactory() { }
         

        private static AppointmentFacadeManagerFactory managerFactory;

        public static AppointmentFacadeManagerFactory GetManagerfactory()
        {
            if (managerFactory == null)
            {
                managerFactory = new AppointmentFacadeManagerFactory();

            }

            return managerFactory;
        }


        public IAppointmentServiceFacadeManager GetManager(string Manager)
        {
            Dictionary<string, IAppointmentServiceFacadeManager> Aconn = new Dictionary<string, IAppointmentServiceFacadeManager>();

            Aconn.Add("WcfManager", new WCFAppointmentServiceManagerFacade());
            if (Aconn.ContainsKey(Manager))
            {
                return Aconn[Manager];
            }

            
            else throw new InvalidConnectionSelection("Please Put Correct Appointment service connection string");
        }






    }
}
