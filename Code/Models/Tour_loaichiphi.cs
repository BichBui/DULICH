using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DULICH.Models
{
    public class Tour_loaichiphi
    {
        [Key]
        public int cp_id { get; set; }
        public string cp_ten { get; set; }
        public string cp_mota { get; set; }
    }
}
