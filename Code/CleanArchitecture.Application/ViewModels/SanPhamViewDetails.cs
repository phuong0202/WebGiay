using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.ViewModel
{
    public class SanPhamViewDetails
    {
        public SanPhamDTO sanpham { get; set; }

        public ICollection<SanPhamDTO> sanphams { get; set; }
    }
}
