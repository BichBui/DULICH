using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DULICH.Models
{
    public class DoanhthuTour
    {
        public int tour_id { get; set; }
        public String tour_ten { get; set; }
        public String list { get; set; }
        public double tong_doan { get; set; }
        public double tong_doanhthu { get; set; }
        public double tong_chiphi { get; set; }
        public double lai { get; set; }
    }
}
