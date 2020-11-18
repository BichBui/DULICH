using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DULICH.Models
{
    public class Tours
    {
        [Key]
        public int tour_id { get; set; }
        public string tour_ten { get; set; }
        public string tour_mota { get; set; }
        public int? loai_id { get; set; }
        /*public virtual Tour_loai Tour_loai { get; set; }
        public virtual ICollection<Tour_chitiet> Tour_chitiet { get; set; }
        public virtual ICollection<Tour_doan> Tour_doan { get; set; }
        public virtual ICollection<Tour_gia> Tour_gia { get; set; }*/

    }
}
