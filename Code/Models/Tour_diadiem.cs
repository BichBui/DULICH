using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DULICH.Models
{
    public class Tour_diadiem
    {
        [Key]
        public int dd_id { get; set; }
        public string dd_thanhpho { get; set; }
        public string dd_ten { get; set; }
        public string dd_mota { get; set; }
    }
}
