using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Migrations
{
    /// <inheritdoc />
    public partial class fixDATABASE_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "GioiTinh",
                table: "NhanVien",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "MaSo",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "GioiTinh",
                table: "HocVien",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "GioiTinh",
                table: "GiangVien",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "MaSo",
                table: "GiangVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaSo",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "MaSo",
                table: "GiangVien");

            migrationBuilder.AlterColumn<string>(
                name: "GioiTinh",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "GioiTinh",
                table: "HocVien",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "GioiTinh",
                table: "GiangVien",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
