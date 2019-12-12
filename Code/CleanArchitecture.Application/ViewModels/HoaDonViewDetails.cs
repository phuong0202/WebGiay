using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.ViewModel
{
    public class HoaDonViewDetails
    {
        public HoaDonDTO hoadon { get; set; }

        public ICollection<HoaDonDTO> hoadons { get; set; }
        
    }
}
