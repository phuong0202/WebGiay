using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.ViewModel
{
    public class KhachHangViewDetails
    {
        
            public KhachHangDTO khachhang { get; set; }

            public ICollection<KhachHangDTO> khachhangs { get; set; }
        
    }
}
