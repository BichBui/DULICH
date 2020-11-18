using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DULICH.Models
{
    public class ListTours
    {
        public int tour_id { get; set; }
        public int gia_id { get; set; }
        public string tour_ten { get; set; }
        public string tour_mota { get; set; }
        public string loai_ten { get; set; }
    }
}
