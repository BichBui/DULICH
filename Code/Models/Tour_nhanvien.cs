using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DULICH.Models
{
    public class Tour_nhanvien
    {
        [Key]
        public int nv_id { get; set; }
        public string nv_ten { get; set; }
        public string nv_sdt { get; set; }

        [DataType(DataType.Date)]
        public DateTime nv_ngaysinh { get; set; }
        public string nv_email { get; set; }
        public string nv_nhiemvu { get; set; }
    }
}
