using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DULICH.Models
{
    public class Tour_doan
    {
        [Key]
        public int doan_id { get; set; }
        public int tour_id { get; set; }
        public int gia_id { get; set; }
        public string doan_name { get; set; }
        [DataType(DataType.Date)]
        public DateTime doan_ngaydi { get; set; }
        [DataType(DataType.Date)]
        public DateTime doan_ngayve { get; set; }
        public string doan_chitietchuongtrinh { get; set; }

    }
}
