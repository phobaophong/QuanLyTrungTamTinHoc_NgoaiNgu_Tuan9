using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Migrations
{
    /// <inheritdoc />
    public partial class FixLopHoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiSo",
                table: "LopHoc",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiSo",
                table: "LopHoc");
        }
    }
}
