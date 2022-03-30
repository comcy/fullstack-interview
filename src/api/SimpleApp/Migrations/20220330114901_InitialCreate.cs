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
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    FileName = table.Column<string>(type: "TEXT", nullable: false),
                    DrawingNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PartNumber = table.Column<string>(type: "TEXT", nullable: true),
                    OrderNumber = table.Column<string>(type: "TEXT", nullable: true),
                    WorkpieceName = table.Column<string>(type: "TEXT", nullable: true),
                    SoftwareVersion = table.Column<string>(type: "TEXT", nullable: true),
                    OperatorName = table.Column<string>(type: "TEXT", nullable: true),
                    CmmNumber = table.Column<string>(type: "TEXT", nullable: true),
                    MeasuredOn = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                columns: new[] { "ProtocolId", "CmmNumber", "DrawingNumber", "FileName", "MeasuredOn", "Name", "OperatorName", "OrderNumber", "PartNumber", "SoftwareVersion", "WorkpieceName" },
                values: new object[] { 1, "112233", "11", "28022022114012_IV05N002R0.pdf", new DateTime(2022, 3, 30, 13, 49, 1, 569, DateTimeKind.Local).AddTicks(497), "mein_block_testv1", "", "", "11", "", "" });

            migrationBuilder.InsertData(
                table: "Protocols",
                columns: new[] { "ProtocolId", "CmmNumber", "DrawingNumber", "FileName", "MeasuredOn", "Name", "OperatorName", "OrderNumber", "PartNumber", "SoftwareVersion", "WorkpieceName" },
                values: new object[] { 2, "112233", "8", "24022022112318_IV05N002R0.pdf", new DateTime(2022, 3, 30, 13, 49, 1, 569, DateTimeKind.Local).AddTicks(540), "mein_block_testv2", "", "", "8", "", "" });

            migrationBuilder.InsertData(
                table: "Protocols",
                columns: new[] { "ProtocolId", "CmmNumber", "DrawingNumber", "FileName", "MeasuredOn", "Name", "OperatorName", "OrderNumber", "PartNumber", "SoftwareVersion", "WorkpieceName" },
                values: new object[] { 3, "112233", "9", "24022022112244_IV05N002R0.pdf", new DateTime(2022, 3, 30, 13, 49, 1, 569, DateTimeKind.Local).AddTicks(542), "mein_block_testv3", "", "", "9", "", "" });

            migrationBuilder.InsertData(
                table: "Protocols",
                columns: new[] { "ProtocolId", "CmmNumber", "DrawingNumber", "FileName", "MeasuredOn", "Name", "OperatorName", "OrderNumber", "PartNumber", "SoftwareVersion", "WorkpieceName" },
                values: new object[] { 4, "112233", "11", "24022022112301_IV05N002R0.pdf", new DateTime(2022, 3, 30, 13, 49, 1, 569, DateTimeKind.Local).AddTicks(545), "mein_block_testv4", "", "", "11", "", "" });

            migrationBuilder.InsertData(
                table: "Protocols",
                columns: new[] { "ProtocolId", "CmmNumber", "DrawingNumber", "FileName", "MeasuredOn", "Name", "OperatorName", "OrderNumber", "PartNumber", "SoftwareVersion", "WorkpieceName" },
                values: new object[] { 5, "112233", "11", "20122021070353_IV05N002R0.pdf", new DateTime(2022, 3, 30, 13, 49, 1, 569, DateTimeKind.Local).AddTicks(547), "mein_block_testv5", "", "", "11", "", "" });

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
