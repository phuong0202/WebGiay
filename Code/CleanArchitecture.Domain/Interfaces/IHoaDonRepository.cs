using CleanArchitecture.Domian.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IHoaDonRepository
    {
        IEnumerable<HoaDon> GetHoaDons();

        HoaDon GetHoaDon(int? Id);

        void Create(HoaDon hoadon);

        void Remove(int? Id);
    }
}
