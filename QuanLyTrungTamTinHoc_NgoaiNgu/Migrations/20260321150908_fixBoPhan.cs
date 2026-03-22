using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Migrations
{
    /// <inheritdoc />
    public partial class fixBoPhan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChuyenMon",
                table: "GiangVien");

            migrationBuilder.AddColumn<string>(
                name: "BoPhan",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BoPhan",
                table: "GiangVien",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoPhan",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "BoPhan",
                table: "GiangVien");

            migrationBuilder.AddColumn<string>(
                name: "ChuyenMon",
                table: "GiangVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
