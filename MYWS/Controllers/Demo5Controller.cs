using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MYWS.Models;

namespace MYWS.Controllers
{
    public class Demo5Controller : Controller
    {
        // GET: Demo5/PhepTinh
        public ViewResult PhepTinh()
        {
            return View();
        }
        // POST: Demo5/TinhTong
        //Biding to Complex type Model class - truyền dữ liệu về, qua một thực thể hoặc đối tượng
        [HttpPost]
        public ViewResult TinhTong(PhepTinhModel model)
        {
            // add thư viện jquery
            if (ModelState.IsValid)// kiểm thử sai phạm tại model
            {
                int kq = model.SoA + model.SoB;
                //Truyền dữ liệu lên view
                ViewBag.KetQua = $"Kết quả : {model.SoA} + {model.SoB} = {kq}";
                // chỉ định view hiển thị
            }
            return View("PhepTinh");
        }

        // POST: Demo5/TinhTich
        //Biding to Complex type Model class - truyền dữ liệu về, qua một thực thể hoặc đối tượng
        public ViewResult TinhTich(PhepTinhModel model)
        {
            int kq = model.SoA * model.SoB;
            //Truyền dữ liệu lên view
            ViewBag.KetQua = $"Kết quả : {model.SoA} x {model.SoB} = {kq}";
            // chỉ định view hiển thị
            return View("PhepTinh");
        }
    }
}