using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CMDFrontend.Patient.Model.Entity
{
    public class PatientEnity:INotifyPropertyChanged
    {
    
        public long Id { get; set; }
    
        public String Name { get; set; }

        public String BloodGroup { get; set; }
        public String Location { get; set; }

        public String Gender { get; set; }

        public String Password { get; set; }
     
        public String EmailId { get; set; }
       
        [StringLength(12)]
        public String PhoneNumber { get; set; }
       
        public String Image { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
