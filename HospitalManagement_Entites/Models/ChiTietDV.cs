using System;
using System.Collections.Generic;

#nullable disable

namespace HospitalManagement.Models
{
    public partial class ChiTietDV
    {
        public string MaHD { get; set; }
        public Guid MaDV { get; set; }
        public decimal? DonGiaDV { get; set; }
        public virtual DichVu MaDVNavigation { get; set; }
        public virtual HoaDon MaHDNavigation { get; set; }
    }
}
