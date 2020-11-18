using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DULICH.Models
{
    public class Tour_loai
    {
        [Key]
        public int loai_id { get; set; }
        public string loai_ten { get; set; }
        public string loai_mota { get; set; }
    }
}
