using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MYWS.Controllers
{
    public class Demo4Controller : Controller
    {
        // GET: Demo4/PhepTinh
        public ViewResult PhepTinh()
        {
            return View();
        }
        // POST: Demo4/PhepTinh
        //Biding to primitive type - truyền dữ liệu qua các tham số đơn lẻ
        [HttpPost]
        public ViewResult TinhTong(int SoA,int SoB)
        {
            int kq = SoA + SoB;
            //Truyền dữ liệu lên view
            ViewBag.KetQua = $"Kết quả : {SoA} + {SoB} = {kq}";
            // chỉ định view hiển thị
            return View("PhepTinh");
        }
        public ViewResult TinhTich(int SoA, int SoB)
        {
            int kq = SoA * SoB;
            //Truyền dữ liệu lên view
            ViewBag.KetQua = $"Kết quả : {SoA} x {SoB} = {kq}";
            // chỉ định view hiển thị
            return View("PhepTinh");
        }
    }
}