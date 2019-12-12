using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domian.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
        }

        public int Id { get; set; }
        public int? IdKhachHang { get; set; }
        public string Ngay { get; set; }
        public int? TongTien { get; set; }

        public virtual  KhachHang IdKhachHangNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }
    }
}
