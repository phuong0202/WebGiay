using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.ViewModel
{
    public class KhachHangDTO
    {
        public int Id { get; set; }
        public string TenKhachHang { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public int? VaiTro { get; set; }

        public virtual HoaDonDTO IdhoadonNavigation { get; set; }
    }
}
