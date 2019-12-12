using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domian.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Services
{
    public class HoaDonService : IHoaDonService
    {
        private readonly IHoaDonRepository hoadonRepository;
        private readonly IMapper iMapper;

        public HoaDonService(IHoaDonRepository hoadonRepository, IMapper mapper)
        {
            this.hoadonRepository = hoadonRepository;
            this.iMapper = mapper;
        }
        public void Create(HoaDonDTO hoadon)
        {
            hoadonRepository.Create(iMapper.Map<HoaDonDTO, HoaDon>(hoadon));
        }

        public HoaDonDTO GetHoaDon(int? Id)
        {
            return iMapper.Map<HoaDon, HoaDonDTO>(hoadonRepository.GetHoaDon(Id));
        }

        public IEnumerable<HoaDonDTO> GetHoaDons()
        {
            return iMapper.Map<IEnumerable<HoaDon>, IEnumerable<HoaDonDTO>>(hoadonRepository.GetHoaDons());
        }

        public ICollection<HoaDonDTO> GetHoaDons(int? Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int? Id)
        {
            hoadonRepository.Remove(Id);
        }
    }
}
