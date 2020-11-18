using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DULICH.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tour_chiphi",
                columns: table => new
                {
                    chiphi_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doan_id = table.Column<int>(nullable: false),
                    chiphi_total = table.Column<double>(nullable: false),
                    chiphi_chitiet = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour_chiphi", x => x.chiphi_id);
                });

            migrationBuilder.CreateTable(
                name: "Tour_chitiet",
                columns: table => new
                {
                    ct_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tour_id = table.Column<int>(nullable: false),
                    dd_id = table.Column<int>(nullable: false),
                    ct_thutu = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour_chitiet", x => x.ct_id);
                });

            migrationBuilder.CreateTable(
                name: "Tour_diadiem",
                columns: table => new
                {
                    dd_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dd_thanhpho = table.Column<string>(nullable: true),
                    dd_ten = table.Column<string>(nullable: true),
                    dd_mota = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour_diadiem", x => x.dd_id);
                });

            migrationBuilder.CreateTable(
                name: "Tour_doan",
                columns: table => new
                {
                    doan_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tour_id = table.Column<int>(nullable: false),
                    gia_id = table.Column<int>(nullable: false),
                    doan_name = table.Column<string>(nullable: true),
                    doan_ngaydi = table.Column<DateTime>(nullable: false),
                    doan_ngayve = table.Column<DateTime>(nullable: false),
                    doan_chitietchuongtrinh = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour_doan", x => x.doan_id);
                });

            migrationBuilder.CreateTable(
                name: "Tour_gia",
                columns: table => new
                {
                    gia_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gia_sotien = table.Column<double>(nullable: false),
                    tour_id = table.Column<int>(nullable: false),
                    gia_tungay = table.Column<DateTime>(nullable: false),
                    gia_denngay = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour_gia", x => x.gia_id);
                });

            migrationBuilder.CreateTable(
                name: "Tour_khachhang",
                columns: table => new
                {
                    kh_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kh_ten = table.Column<string>(nullable: true),
                    kh_sdt = table.Column<string>(nullable: true),
                    kh_ngaysinh = table.Column<DateTime>(nullable: false),
                    kh_email = table.Column<string>(nullable: true),
                    kh_cmnd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour_khachhang", x => x.kh_id);
                });

            migrationBuilder.CreateTable(
                name: "Tour_loai",
                columns: table => new
                {
                    loai_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    loai_ten = table.Column<string>(nullable: true),
                    loai_mota = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour_loai", x => x.loai_id);
                });

            migrationBuilder.CreateTable(
                name: "Tour_loaichiphi",
                columns: table => new
                {
                    cp_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cp_ten = table.Column<string>(nullable: true),
                    cp_mota = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour_loaichiphi", x => x.cp_id);
                });

            migrationBuilder.CreateTable(
                name: "Tour_nguoidi",
                columns: table => new
                {
                    nguoidi_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doan_id = table.Column<int>(nullable: false),
                    nguoidi_dsnhanvien = table.Column<string>(nullable: true),
                    nguoidi_dskhach = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour_nguoidi", x => x.nguoidi_id);
                });

            migrationBuilder.CreateTable(
                name: "Tour_nhanvien",
                columns: table => new
                {
                    nv_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nv_ten = table.Column<string>(nullable: true),
                    nv_sdt = table.Column<string>(nullable: true),
                    nv_ngaysinh = table.Column<DateTime>(nullable: false),
                    nv_email = table.Column<string>(nullable: true),
                    nv_nhiemvu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour_nhanvien", x => x.nv_id);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    tour_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tour_ten = table.Column<string>(nullable: true),
                    tour_mota = table.Column<string>(nullable: true),
                    loai_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.tour_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tour_chiphi");

            migrationBuilder.DropTable(
                name: "Tour_chitiet");

            migrationBuilder.DropTable(
                name: "Tour_diadiem");

            migrationBuilder.DropTable(
                name: "Tour_doan");

            migrationBuilder.DropTable(
                name: "Tour_gia");

            migrationBuilder.DropTable(
                name: "Tour_khachhang");

            migrationBuilder.DropTable(
                name: "Tour_loai");

            migrationBuilder.DropTable(
                name: "Tour_loaichiphi");

            migrationBuilder.DropTable(
                name: "Tour_nguoidi");

            migrationBuilder.DropTable(
                name: "Tour_nhanvien");

            migrationBuilder.DropTable(
                name: "Tours");
        }
    }
}
