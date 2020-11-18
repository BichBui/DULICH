using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DULICH.Models
{
    public class Tour_nguoidi
    {
        [Key]
        public int nguoidi_id { get; set; }
        public int doan_id { get; set; }
        public string nguoidi_dsnhanvien { get; set; }
        public string nguoidi_dskhach { get; set; }
    }
}
