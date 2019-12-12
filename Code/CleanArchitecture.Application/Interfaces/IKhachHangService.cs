using CleanArchitecture.Application.ViewModel;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IKhachHangService
    {
        IEnumerable<KhachHangDTO> GetKhachHangs();

        KhachHangDTO GetKhachHang(int? Id);

        void Create(KhachHangDTO khachhang);

        void Remove(int? Id);


        ICollection<KhachHangDTO> GetKhachHangs(int? Id);
    }
}
