using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectur.MVC.Controllers
{
    public class HoaDonController : Controller
    {
        private IHoaDonService hoadonService;
        public HoaDonController(IHoaDonService hoadonService)
        {
            this.hoadonService = hoadonService;

        }
        public IActionResult Index()
        {
            return View(hoadonService.GetHoaDons());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(HoaDonDTO hoadonDTO)
        {
            if (ModelState.IsValid)
            {
                hoadonDTO.Id = 0;
                hoadonService.Create(hoadonDTO);
                return RedirectToAction("Index");
            }
            return View(hoadonDTO);
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
                var hd = hoadonService.GetHoaDon(Id);
                return View(hd);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            hoadonService.Remove(Id);
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
                var hd = hoadonService.GetHoaDon(Id);
                return View(hd);
            }
        }
        [HttpPost, ActionName("Edit")]
        public IActionResult EditConfirm(HoaDonDTO hoadon)
        {
            if (ModelState.IsValid)
            {
                hoadonService.Create(hoadon);
                return RedirectToAction("Index");
            }
            return View(hoadon);
        }
        public IActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                var hoadonViewDetails = new HoaDonViewDetails()
                {
                    hoadon = hoadonService.GetHoaDon(Id),

                };
                return View(hoadonService.GetHoaDon(Id));
            }
        }
    }
}