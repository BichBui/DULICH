using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DULICH.Models
{
    public class Tour_gia
    {
        [Key]
        public int gia_id { get; set; }
        public double gia_sotien { get; set; }
        public int tour_id { get; set; }
        [DataType(DataType.Date)]
        public DateTime gia_tungay { get; set; }
        [DataType(DataType.Date)]
        public DateTime gia_denngay { get; set; }
    }
}
