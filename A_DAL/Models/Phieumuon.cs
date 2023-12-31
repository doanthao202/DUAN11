﻿using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Phieumuon
    {
        public Phieumuon()
        {
            Phieumuoncts = new HashSet<Phieumuonct>();
        }

        public int Id { get; set; }
        public int Iddocgia { get; set; }
        public int Idnhanvien { get; set; }
        public DateTime? Ngaymuon { get; set; }
        public DateTime? Ngaytradukien { get; set; }

        public virtual Docgium IddocgiaNavigation { get; set; } = null!;
        public virtual Nhanvien IdnhanvienNavigation { get; set; } = null!;
        public virtual ICollection<Phieumuonct> Phieumuoncts { get; set; }
    }
}
