using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Share.Models.ViewModel
{
    public class STTViewModel
    {
        public int STT { get; set; }
        public Guid MaPK { get; set; }
        public string HoTen { get; set; }
        public string UuTien { get; set; }       
    }
}
