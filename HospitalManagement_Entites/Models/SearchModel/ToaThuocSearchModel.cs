﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    public class ToaThuocSearchModel
    {
        public int? Page { get; set; }
        public String KeywordSearch { get; set; }
        public byte TrangThai { get; set; }
        public byte TrangThaiPK { get; set; }
    }
}
