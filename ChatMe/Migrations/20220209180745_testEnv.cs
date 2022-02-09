using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatMe.Migrations
{
    public partial class testEnv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    chatID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isGroupMessage = table.Column<bool>(nullable: false),
                    usersIDs = table.Column<string>(nullable: true),
                    chatName = table.Column<string>(nullable: true),
                    chatColor = table.Column<string>(nullable: true),
                    lastMessageTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.chatID);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    messageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chatID = table.Column<int>(nullable: false),
                    creatorID = table.Column<int>(nullable: false),
                    messageContent = table.Column<string>(nullable: true),
                    createdTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.messageID);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<int>(nullable: false),
                    darkMode = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Readed",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<int>(nullable: false),
                    readTime = table.Column<DateTime>(nullable: false),
                    messageID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Readed", x => x.id);
                    table.ForeignKey(
                        name: "FK_Readed_Messages_messageID",
                        column: x => x.messageID,
                        principalTable: "Messages",
                        principalColumn: "messageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Readed_messageID",
                table: "Readed",
                column: "messageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Readed");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
