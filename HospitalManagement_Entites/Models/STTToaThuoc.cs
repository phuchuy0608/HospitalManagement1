﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HospitalManagement.Models
{
    public partial class STTTOATHUOC
    {
        public Guid MaPK { get; set; }
        public int STT { get; set; }
        public string UuTien { get; set; }

        public virtual ToaThuoc MaPKNavigation { get; set; }
    }
}
