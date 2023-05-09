﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HospitalManagement.Models
{
    public partial class PhieuKham
    {
        public PhieuKham()
        {
            ChiTietSinhHieu = new HashSet<ChiTietSinhHieu>();
            HoaDon = new HashSet<HoaDon>();
            ChiTietBenh = new HashSet<ChiTietBenh>();

        }
        public Guid MaPK { get; set; }
        public string MaBS { get; set; }
        public Guid MaBN { get; set; }
        public string Mach { get; set; }
        public string NhietDo { get; set; }
        public string HuyetAp { get; set; }
        public string TrieuChungSoBo { get; set; }
      
        public string ChanDoan { get; set; }
        public DateTime NgayKham { get; set; }
        public DateTime? NgayTaiKham { get; set; }
        public byte TrangThai { get; set; }
       

        public virtual BenhNhan MaBNNavigation { get; set; }
        public virtual NhanVienYte MaBSNavigation { get; set; }
        public virtual STTPhieuKham STTPhieuKham { get; set; }
        public virtual ToaThuoc ToaThuoc { get; set; }
        public virtual ICollection<ChiTietSinhHieu> ChiTietSinhHieu { get; set; }
        public virtual ICollection<HoaDon> HoaDon { get; set; }
        public virtual ICollection<ChiTietBenh> ChiTietBenh { get; set; }

    
    }
}
