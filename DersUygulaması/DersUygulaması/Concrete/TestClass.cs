using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersUygulaması
{
    public class TestClass
    {
        [Key]
        public int TestNo { get; set; }
        public int TestBasarisi { get; set; }
        
    }
}
