using ServiceFacade.AppointmentService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFacade
{
    public class WCFAppointmentServiceManagerFacade : IAppointmentServiceFacadeManager
    {
        AppointmentServiceClient appointmentService = new AppointmentServiceClient();

        List<AppointmentDTO> result = new List<AppointmentDTO>();

        public bool Add(AppointmentDTO appointment)
        {
            return appointmentService.AddAppointment(appointment);
        }

        public List<AppointmentDTO> getAllAccToStatus(string status)
        {
           
            foreach (var a in appointmentService.getAllAppointmentsAccToStatus(status))
            {
                result.Add(a);
            }

            return result;
        }

        public List<AppointmentDTO> getAllForDoctor(string Doc_id)
        {
            foreach (var a in appointmentService.getAllAppointmentsOfDoctor(Doc_id))
            {
                result.Add(a);
            }

            return result;
        }

        public List<AppointmentDTO> getAllForPatient(string Pat_id)
        {
           
            foreach (var a in appointmentService.getAllAppointmentsOfPatient(Pat_id))
            {
                result.Add(a);
            }

            return result;
        }

        public List<AppointmentDTO> getById(long App_id)
        {
            foreach (var a in appointmentService.getAppointmentById(App_id))
            {
                result.Add(a);
            }

            return result;
        }

        public bool SetStatus(string app_id, string status)
        {
            return appointmentService.SetAppointmentStatus(app_id, status);
        }
    }
}
