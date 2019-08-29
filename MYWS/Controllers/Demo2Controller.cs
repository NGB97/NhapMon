using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MYWS.Controllers
{
    public class Demo2Controller : Controller
    {
        // GET: Demo2/ThongTinHocVien
        public ViewResult ThongTinHocVien()
        {
            // chỉ định View() mặc định
            return View();//pt1
        }
        // GET: Demo2/ThongTinKhachHang
        public ViewResult ThongTinKhachHang()
        {
            // chỉ định View 'ThongTinKhachHang' hiển thị
            //return View("ThongTinKhachHang");//pt4
            return View(viewName: "ThongTinKhachHang");
        }
    }
}