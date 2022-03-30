using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Protocols",
                columns: table => new
                {
                    ProtocolId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    DrawingNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PartNumber = table.Column<string>(type: "TEXT", nullable: true),
                    OrderNumber = table.Column<string>(type: "TEXT", nullable: true),
                    WorkpieceName = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: true),
                    CncName = table.Column<string>(type: "TEXT", nullable: true),
                    SoftwareVersion = table.Column<string>(type: "TEXT", nullable: true),
                    OperatorName = table.Column<string>(type: "TEXT", nullable: true),
                    CmmNumber = table.Column<string>(type: "TEXT", nullable: true),
                    MeasuredOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DrawingIndex = table.Column<string>(type: "TEXT", nullable: true),
                    UserDefined1 = table.Column<string>(type: "TEXT", nullable: true),
                    UserDefined2 = table.Column<string>(type: "TEXT", nullable: true),
                    UserDefined3 = table.Column<string>(type: "TEXT", nullable: true),
                    UserDefined4 = table.Column<string>(type: "TEXT", nullable: true),
                    UserDefined5 = table.Column<string>(type: "TEXT", nullable: true),
                    UserDefined6 = table.Column<string>(type: "TEXT", nullable: true),
                    UserDefined7 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protocols", x => x.ProtocolId);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProtocolId = table.Column<int>(type: "INTEGER", nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Protocols_ProtocolId",
                        column: x => x.ProtocolId,
                        principalTable: "Protocols",
                        principalColumn: "ProtocolId");
                });

            migrationBuilder.InsertData(
                table: "Protocols",
                columns: new[] { "ProtocolId", "CmmNumber", "CncName", "CustomerName", "DrawingIndex", "DrawingNumber", "MeasuredOn", "Name", "OperatorName", "OrderNumber", "PartNumber", "SoftwareVersion", "UserDefined1", "UserDefined2", "UserDefined3", "UserDefined4", "UserDefined5", "UserDefined6", "UserDefined7", "WorkpieceName" },
                values: new object[] { 1, null, null, null, null, "Test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Protocol", null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProtocolId",
                table: "Comments",
                column: "ProtocolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Protocols");
        }
    }
}
