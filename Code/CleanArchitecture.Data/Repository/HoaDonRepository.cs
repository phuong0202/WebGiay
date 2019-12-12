using CleanArchitecture.Data.Context;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domian.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Data.Repository
{
    public class HoaDonRepository : IHoaDonRepository
    {
        private WebEnglishDBContext webEnglishDBContext;

        public HoaDonRepository(WebEnglishDBContext webEnglishDBContext)
        {
            this.webEnglishDBContext = webEnglishDBContext;
        }
        public void Create(HoaDon hoadon)
        {
            if (hoadon.Id == 0)
            {
                webEnglishDBContext.HoaDon.Add(hoadon);
                webEnglishDBContext.SaveChanges();
            }
            else
            {
                HoaDon findResults = webEnglishDBContext.HoaDon.Find(hoadon.Id);
                findResults.IdKhachHang = hoadon.IdKhachHang;
                findResults.Ngay = hoadon.Ngay;
                findResults.TongTien = hoadon.TongTien;
                webEnglishDBContext.SaveChanges();
            }
        }

        public HoaDon GetHoaDon(int? Id)
        {
            HoaDon findResults = webEnglishDBContext.HoaDon.Find(Id);
            return findResults;
        }

        public IEnumerable<HoaDon> GetHoaDons()
        {
            return webEnglishDBContext.HoaDon;
        }

        public void Remove(int? Id)
        {
            HoaDon findResults = webEnglishDBContext.HoaDon.Find(Id);
            webEnglishDBContext.HoaDon.Remove(findResults);
            webEnglishDBContext.SaveChanges();
        }

        
    }
}
