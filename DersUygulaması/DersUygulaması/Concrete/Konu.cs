using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersUygulaması
{
    public class Konu
    {
        [Key]
        public int konuId { get; set; }
        public string konuAd { get; set; }
        public int konuBasarisi { get; set; }
    }
}
