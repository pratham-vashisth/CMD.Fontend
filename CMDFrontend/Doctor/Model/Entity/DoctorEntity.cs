using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFrontend.Doctor.Model.Entity
{
    public class DoctorEntity:INotifyPropertyChanged
    {
        public long Id { get; }
        public String Name { get; set; }
        public String EmailId { get; set; }
        public String PhoneNo { get; set; }
        public String PracticeLocation { get; set; }
        public String Speciality { get; set; }
        public String NpiNo { get; set; }
        public String Password { get; set; }
        public String Gender { get; set; }
        public string Image { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
