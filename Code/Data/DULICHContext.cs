using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DULICH.Models;

namespace DULICH.Data
{
    public class DULICHContext : DbContext
    {
        public DULICHContext(DbContextOptions<DULICHContext> options)
            : base(options)
        {
        }

        public DbSet<Tours> Tours { get; set; }
        public DbSet<Tour_chiphi> Tour_chiphi { get; set; }
        public DbSet<Tour_chitiet> Tour_chitiet { get; set; }
        public DbSet<Tour_diadiem> Tour_diadiem { get; set; }
        public DbSet<Tour_doan> Tour_doan { get; set; }
        public DbSet<Tour_gia> Tour_gia { get; set; }
        public DbSet<Tour_khachhang> Tour_khachhang { get; set; }
        public DbSet<Tour_loai> Tour_loai { get; set; }
        public DbSet<Tour_loaichiphi> Tour_loaichiphi { get; set; }
        public DbSet<Tour_nguoidi> Tour_nguoidi { get; set; }
        public DbSet<Tour_nhanvien> Tour_nhanvien { get; set; }

    }
    
}
