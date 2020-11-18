using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DULICH.Models
{
    public class Tour_khachhang
    {
        [Key]
        public int kh_id { get; set; }
        public string kh_ten { get; set; }
        public string kh_sdt { get; set; }

        [DataType(DataType.Date)]
        public DateTime kh_ngaysinh { get; set; }
        public string kh_email { get; set; }
        public string kh_cmnd { get; set; }

    }
}
