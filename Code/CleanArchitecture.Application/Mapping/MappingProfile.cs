using AutoMapper;
using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domian.Models;

namespace CleanArchitecture.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            

            CreateMap<SanPham, SanPhamDTO>();
            CreateMap<SanPhamDTO, SanPham>();

            CreateMap<KhachHang, KhachHangDTO>();
            CreateMap<KhachHangDTO, KhachHang>();

            CreateMap<HoaDon, HoaDonDTO>();
            CreateMap<HoaDonDTO, HoaDon>();

            
        }
    }
}
