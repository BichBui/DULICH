using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DULICH.Models
{
    public class Tour_chitiet
    {
        [Key]
        public int ct_id { get; set; }
        public int tour_id { get; set; }
        public int dd_id { get; set; }
        public int ct_thutu { get; set; }
    }
}
