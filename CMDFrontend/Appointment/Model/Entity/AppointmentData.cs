using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CMDFrontend.Appointment.Model.Entity
{
    public class AppointmentData
    {
        
            public string PatientName { get; set; }

         
            public string DoctorName { get; set; }

           
            public BitmapImage DocImage { get; set; }

            public BitmapImage PatImage { get; set; }

            public String Issue { get; set; }

    
            public String TimeSlot { get; set; }

            public string ReasonForVisit { get; set; }


            public String Appointment_status { get; set; }
            
            public string PatEmail { get; set; }
            
            public string AppDate { get; set; }
            public string AppTime { get; set; }

            public string Speciality { get; set; }
        
    }
}
