using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersUygulaması
{
    public class Soru
    {
        [Key]
        public int soruId { get; set; }
        public string soruText { get; set; }
        public string soruA { get; set; }
        public string soruB { get; set; }
        public string soruC { get; set; }
        public string soruD { get; set; }
        public string soruCevap { get; set; }
        public int soruKonu { get; set; }
        public int soruÖgrenmeDurumu { get; set; }
        public int Test { get; set; }
    }
}
