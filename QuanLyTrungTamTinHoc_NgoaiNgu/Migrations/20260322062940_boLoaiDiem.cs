using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Migrations
{
    /// <inheritdoc />
    public partial class boLoaiDiem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KetQua_LoaiDiem_LoaiDiemID",
                table: "KetQua");

            migrationBuilder.DropTable(
                name: "LoaiDiem");

            migrationBuilder.DropIndex(
                name: "IX_KetQua_LoaiDiemID",
                table: "KetQua");

            migrationBuilder.DropColumn(
                name: "LanThi",
                table: "KetQua");

            migrationBuilder.DropColumn(
                name: "LoaiDiemID",
                table: "KetQua");

            migrationBuilder.RenameColumn(
                name: "DiemSo",
                table: "KetQua",
                newName: "DiemThiThu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiemThiThu",
                table: "KetQua",
                newName: "DiemSo");

            migrationBuilder.AddColumn<int>(
                name: "LanThi",
                table: "KetQua",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LoaiDiemID",
                table: "KetQua",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LoaiDiem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeSo = table.Column<float>(type: "real", nullable: false),
                    TenLoaiDiem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDiem", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KetQua_LoaiDiemID",
                table: "KetQua",
                column: "LoaiDiemID");

            migrationBuilder.AddForeignKey(
                name: "FK_KetQua_LoaiDiem_LoaiDiemID",
                table: "KetQua",
                column: "LoaiDiemID",
                principalTable: "LoaiDiem",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
