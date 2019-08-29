using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MYWS.Controllers
{
    public class Demo3Controller : Controller
    {
        // GET: Demo3/PhepTinh
        public ViewResult PhepTinh()
        {
            return View();
        }
        // POST: Demo3/PhepTinh
        //Biding to primitive type - truyền dữ liệu qua các tham số đơn lẻ
        [HttpPost]
        public ViewResult PhepTinh(int SoA,int SoB)
        {
            int kq = SoA + SoB;
            //Truyền dữ liệu lên view
            ViewBag.Tong = $"Kết quả : {SoA} + {SoB} = {kq}";
            // chỉ định view hiển thị
            return View();
        }
    }
}