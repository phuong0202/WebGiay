using CleanArchitecture.Domian.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Application.ViewModel
{
    public class SanPhamDTO
    {
        [Key]
        [Display(Name = "STT")]
        public int Id { get; set; }
        [Display(Name = "Tên Loại")]
        public string TenLoai { get; set; }
        [Display(Name = "Tên Sản Phẩm")]
        public string TenSanPham { get; set; }
        [Display(Name = "Size")]
        public int? Size { get; set; }
        [Display(Name = "Giá")]
        public int? Gia { get; set; }
        [Display(Name = "Hình")]
        public string Hinh { get; set; }
        [Display(Name = "Số Lượng")]
        public int? SoLuong { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }
    }
}
