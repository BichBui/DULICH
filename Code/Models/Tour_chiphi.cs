using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DULICH.Models
{
    public class Tour_chiphi
    {
        [Key]
        public int chiphi_id { get; set; }
        public int doan_id { get; set; }
        public double chiphi_total { get; set; }
        public string chiphi_chitiet { get; set; }
    }
}
