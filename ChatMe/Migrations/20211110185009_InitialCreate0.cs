using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatMe.Migrations
{
    public partial class InitialCreate0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "User",
                newName: "ID");

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    chatID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isGroupMessage = table.Column<bool>(nullable: false),
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
                name: "UserID",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<int>(nullable: false),
                    chatID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserID", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserID_Chats_chatID",
                        column: x => x.chatID,
                        principalTable: "Chats",
                        principalColumn: "chatID",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateIndex(
                name: "IX_UserID_chatID",
                table: "UserID",
                column: "chatID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Readed");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "UserID");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "User",
                newName: "id");
        }
    }
}
