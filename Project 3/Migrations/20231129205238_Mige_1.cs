using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_2.Migrations
{
    /// <inheritdoc />
    public partial class Mige_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "basckets",
                columns: table => new
                {
                    B_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    B_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    B_category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    B_price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_basckets", x => x.B_id);
                });

            migrationBuilder.CreateTable(
                name: "productss",
                columns: table => new
                {
                    P_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    P_category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    P_weight = table.Column<double>(type: "float", nullable: true),
                    P_height = table.Column<double>(type: "float", nullable: true),
                    P_DateInsert = table.Column<DateTime>(type: "datetime2", nullable: true),
                    P_price = table.Column<int>(type: "int", nullable: false),
                    P_available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productss", x => x.P_id);
                });

            migrationBuilder.CreateTable(
                name: "userss",
                columns: table => new
                {
                    P_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    U_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    U_family = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    U_age = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userss", x => x.P_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "basckets");

            migrationBuilder.DropTable(
                name: "productss");

            migrationBuilder.DropTable(
                name: "userss");
        }
    }
}
