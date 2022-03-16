using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tuan4_Lab3.Models;

namespace Tuan4_Lab3.Models
{
    public class GioHang
    {
        MyDataDataContext data = new MyDataDataContext();
        public int masach { get; set; }
        [Display(Name="Ten sach")]
        public string tensach { get; set; }

        [Display(Name = "Bia sach")]
        public string hinh { get; set; }

        [Display(Name = "Gia ban")]
        public double giaban { get; set; }

        [Display(Name = "So luong")] 
        public int Soluong { get; set; }

        [Display(Name = "Ten sach")]
        public double dthanhtien
        {
            get { return Soluong * giaban; }
        }
        public GioHang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n => n.masach == masach);
            tensach = sach.tensach;
            hinh = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            Soluong = 1;
        }
    }
}