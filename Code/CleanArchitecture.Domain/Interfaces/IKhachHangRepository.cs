using CleanArchitecture.Domian.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IKhachHangRepository
    {
        IEnumerable<KhachHang> GetKhachHangs();

        KhachHang GetKhachHang(int? Id);

        void Create(KhachHang khachhang);

        void Remove(int? Id);
    }
}
