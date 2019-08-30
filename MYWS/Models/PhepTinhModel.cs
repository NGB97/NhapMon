using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MYWS.Models
{
    public class PhepTinhModel
    {
        [Display(Name = "Số A")]
        [Required(ErrorMessage ="{0} Không được để trống!")]
        public int SoA { get; set; }

        [Display(Name = "Số B")]
        [Required(ErrorMessage = "{0} Không được để trống!")]
        public int SoB { get; set; } // prop + tab + tab

    }
}