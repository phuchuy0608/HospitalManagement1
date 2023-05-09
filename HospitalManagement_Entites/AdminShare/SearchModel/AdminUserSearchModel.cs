using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.ADMIN.Shared.SearchModel
{
    public class AdminUserSearchModel:PagingParameters
    {
        public string Name { get; set; }
        public bool TrangThai { get; set; }
    }
}
