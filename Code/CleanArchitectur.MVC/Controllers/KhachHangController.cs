using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectur.MVC.Controllers
{
    public class KhachHangController : Controller
    {
        private IKhachHangService khachhangService;
        public KhachHangController(IKhachHangService khachhangService)
        {
            this.khachhangService = khachhangService;

        }
        public IActionResult Index()
        {
            return View(khachhangService.GetKhachHangs());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(KhachHangDTO khachhangDTO)
        {
            if (ModelState.IsValid)
            {
                khachhangDTO.Id = 0;
                khachhangService.Create(khachhangDTO);
                return RedirectToAction("Index");
            }
            return View(khachhangDTO);
        }
        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                var kh = khachhangService.GetKhachHang(Id);
                return View(kh);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            khachhangService.Remove(Id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                var kh = khachhangService.GetKhachHang(Id);
                return View(kh);
            }
        }
        [HttpPost, ActionName("Edit")]
        public IActionResult EditConfirm(KhachHangDTO khachhang)
        {
            if (ModelState.IsValid)
            {
                khachhangService.Create(khachhang);
                return RedirectToAction("Index");
            }
            return View(khachhang);
        }
        public IActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                var khachhangViewDetails = new KhachHangViewDetails()
                {
                    khachhang = khachhangService.GetKhachHang(Id),

                };
                return View(khachhangService.GetKhachHang(Id));
            }
        }
    }
}