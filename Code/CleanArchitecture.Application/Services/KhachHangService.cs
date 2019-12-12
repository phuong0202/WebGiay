using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domian.Models;
using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Services
{
    public class KhachHangService : IKhachHangService
    {
        private  IKhachHangRepository khachhangRepository;
        private  IMapper iMapper;
        public KhachHangService(IKhachHangRepository khachhangRepository, IMapper mapper)
        {
            this.khachhangRepository = khachhangRepository;
            this.iMapper = mapper;
        }

        public void Create(KhachHangDTO khachhang)
        {
            khachhangRepository.Create(iMapper.Map<KhachHangDTO, KhachHang>(khachhang));
        }

        public KhachHangDTO GetKhachHang(int? Id)
        {
            return iMapper.Map<KhachHang, KhachHangDTO>(khachhangRepository.GetKhachHang(Id));
        }

        public IEnumerable<KhachHangDTO> GetKhachHangs()
        {
            return iMapper.Map<IEnumerable<KhachHang>, IEnumerable<KhachHangDTO>>(khachhangRepository.GetKhachHangs());
        }

        public ICollection<KhachHangDTO> GetKhachHangs(int? Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int? Id)
        {
            khachhangRepository.Remove(Id);
        }
    }
}
