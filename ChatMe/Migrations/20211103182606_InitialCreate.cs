using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatMe.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    displayName = table.Column<string>(nullable: true),
                    token = table.Column<string>(nullable: true),
                    expire = table.Column<DateTime>(nullable: false),
                    about = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    lastLogin = table.Column<DateTime>(nullable: false),
                    created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
