

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    public class NguoiDungSearchModel
    {   
        public int? Page  { get; set; }
        public String KeyWordSearch{ get; set; }
        public bool TrangThai { get; set; }
       
    }
}


