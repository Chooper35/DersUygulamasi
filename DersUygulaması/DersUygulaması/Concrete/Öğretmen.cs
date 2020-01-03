using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersUygulaması
{
    public class Öğretmen
    {
        [Key]
        public int ögretmenId { get; set; }
        public string ögretmenAd { get; set; }
        public string ögretmenSoyad { get; set; }
        public string ögretmenSifre { get; set; }
        public string ögretmenTelefon { get; set; }
    }
}
