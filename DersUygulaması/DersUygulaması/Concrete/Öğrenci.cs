using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersUygulaması
{
    public class Öğrenci
    {
        [Key]
        public int ögrenciId { get; set; }
        public string ögrenciAd { get; set; }
        public string ögrenciSoyad { get; set; }
        public string ögrenciSifre { get; set; }
    }
}
