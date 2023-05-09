using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement_Entities.Models.ViewModel
{
    public class CTrieuChungModel
    {
        public Guid MaBenh { get; set; }
        public Guid MaTrieuChung { get; set; }
        public string TenTrieuChung { get; set; }       
    }
}
