using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    public class ChiTietBenh
    {
        public Guid MaPK { get; set; }
        public Guid MaBenh { get; set; }
        public string KetQuaKham { get; set; }
        public virtual PhieuKham MaPKNavigation { get; set; }
        public virtual Benh MaBenhNavigation { get; set; }
    }
}
