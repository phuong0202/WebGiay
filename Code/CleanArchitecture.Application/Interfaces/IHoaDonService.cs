using CleanArchitecture.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IHoaDonService
    {
        IEnumerable<HoaDonDTO> GetHoaDons();

        HoaDonDTO GetHoaDon(int? Id);

        void Create(HoaDonDTO hoadon);

        void Remove(int? Id);

        ICollection<HoaDonDTO> GetHoaDons(int? Id);
    }
}
