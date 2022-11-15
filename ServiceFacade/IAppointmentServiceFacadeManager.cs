using ServiceFacade.AppointmentService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFacade
{
    public interface IAppointmentServiceFacadeManager
    {

        bool Add(AppointmentDTO appointment);

        List<AppointmentDTO> getById(long App_id);


        List<AppointmentDTO> getAllForDoctor(string Doc_id);


        List<AppointmentDTO> getAllForPatient(string Pat_id);


        List<AppointmentDTO> getAllAccToStatus(String status);


        bool SetStatus(String app_id, String status);

    }
}
