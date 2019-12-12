using CleanArchitecture.Domian.Models;
using System.Collections.Generic;

namespace CleanArchitecture.Application.ViewModel
{
    public class HoaDonDTO
    {
        public int Id { get; set; }
        public int? IdKhachHang { get; set; }
        public string Ngay { get; set; }
        public int? TongTien { get; set; }

        public virtual KhachHang IdKhachHangNavigation { get; set; }

        
    }
}
