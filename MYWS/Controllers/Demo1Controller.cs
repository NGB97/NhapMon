using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MYWS.Controllers
{
    public class Demo1Controller : Controller
    {
        // GET: Demo1/XuatLoiChao
        public string XuatLoiChao()
        {
            string loichao = "Hello word!";
            return loichao;
        }

        //GET: Demo1/ChaoBuoiSang/Bao
        public string ChaoBuoiSang(string id)
        {
            string loichao = $"Chao buoi sang {id}";
            return loichao;
        }

        //GET: Demo1/ChaoBuoiToi?HoTen=Bao
        public string ChaoBuoiToi(string Hoten)
        {
            string loichao = $"Chao buoi toi {Hoten}";
            return loichao;
        }

        //GET: Demo1/ChaoBuoiChieu?Ho=Nguyen&Ten=Bao
        public string ChaoBuoiChieu(string Ho, string Ten)
        {
            string loichao = $"Chao buoi Chieu {Ho} {Ten}";
            return loichao;
        }
    }
}