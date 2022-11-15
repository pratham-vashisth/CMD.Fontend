using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFrontend.Appointment.Model.Entity
{
    public class AppointmentEntity
    {
        public long App_Id { get; set; }

        public long patientId { get; set; }

       
        public long doctorId { get; set; }


        public String Issue { get; set; }

     
        public String TimeSlot { get; set; }

        public string ReasonForVisit { get; set; }

   
        public String Appointment_status { get; set; }
    }
}
