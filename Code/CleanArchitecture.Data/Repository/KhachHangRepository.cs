using CleanArchitecture.Data.Context;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domian.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Data.Repository
{
    public class KhachHangRepository : IKhachHangRepository
    {
        private WebEnglishDBContext webEnglishDBContext;

        public KhachHangRepository(WebEnglishDBContext webEnglishDBContext)
        {
            this.webEnglishDBContext = webEnglishDBContext;
        }
        public void Create(KhachHang khachhang)
        {
            if (khachhang.Id == 0)
            {
                webEnglishDBContext.KhachHang.Add(khachhang);
                webEnglishDBContext.SaveChanges();
            }
            else
            {
                KhachHang findResults = webEnglishDBContext.KhachHang.Find(khachhang.Id);
                findResults.TenKhachHang = khachhang.TenKhachHang;
                findResults.TaiKhoan = khachhang.TaiKhoan;
                findResults.Sdt = khachhang.Sdt;
                findResults.Email = khachhang.Email;
                findResults.VaiTro = khachhang.VaiTro;
                webEnglishDBContext.SaveChanges();
            }
        }

        public KhachHang GetKhachHang(int? Id)
        {
            KhachHang findResults = webEnglishDBContext.KhachHang.Find(Id);
            return findResults;
        }

        public IEnumerable<KhachHang> GetKhachHangs()
        {
            return webEnglishDBContext.KhachHang;
        }

        public void Remove(int? Id)
        {
            KhachHang findResults = webEnglishDBContext.KhachHang.Find(Id);
            webEnglishDBContext.KhachHang.Remove(findResults);
            webEnglishDBContext.SaveChanges();
        }
    }
}
