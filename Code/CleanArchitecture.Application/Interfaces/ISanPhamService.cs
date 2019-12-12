using CleanArchitecture.Application.ViewModel;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ISanPhamService
    {
        IEnumerable<SanPhamDTO> GetSanPhams();

        SanPhamDTO GetSanPham(int? Id);

        void Create(SanPhamDTO sanpham);

        void Remove(int? Id);

        ICollection<SanPhamDTO> GetSanPhams(int? Id);

        
    }
}
