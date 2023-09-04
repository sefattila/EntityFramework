using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventProject.Repository.Migrations
{
    public partial class initialCatolog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAge = table.Column<int>(type: "int", nullable: false),
                    CustomerPhone = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TicketDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => new { x.EventId, x.CustomerId });
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    EventStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventDinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventLocation = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EventAgeControl = table.Column<int>(type: "int", nullable: false),
                    EventAttends = table.Column<int>(type: "int", nullable: false),
                    EventPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTicket",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TicketsEventId = table.Column<int>(type: "int", nullable: false),
                    TicketsCustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTicket", x => new { x.CustomerId, x.TicketsEventId, x.TicketsCustomerId });
                    table.ForeignKey(
                        name: "FK_CustomerTicket_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerTicket_Tickets_TicketsEventId_TicketsCustomerId",
                        columns: x => new { x.TicketsEventId, x.TicketsCustomerId },
                        principalTable: "Tickets",
                        principalColumns: new[] { "EventId", "CustomerId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventDetails",
                columns: table => new
                {
                    EventDetailId = table.Column<int>(type: "int", nullable: false),
                    EventPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventMail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDetails", x => x.EventDetailId);
                    table.ForeignKey(
                        name: "FK_EventDetails_Events_EventDetailId",
                        column: x => x.EventDetailId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventTicket",
                columns: table => new
                {
                    EventsId = table.Column<int>(type: "int", nullable: false),
                    TicketsEventId = table.Column<int>(type: "int", nullable: false),
                    TicketsCustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTicket", x => new { x.EventsId, x.TicketsEventId, x.TicketsCustomerId });
                    table.ForeignKey(
                        name: "FK_EventTicket_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventTicket_Tickets_TicketsEventId_TicketsCustomerId",
                        columns: x => new { x.TicketsEventId, x.TicketsCustomerId },
                        principalTable: "Tickets",
                        principalColumns: new[] { "EventId", "CustomerId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTicket_TicketsEventId_TicketsCustomerId",
                table: "CustomerTicket",
                columns: new[] { "TicketsEventId", "TicketsCustomerId" });

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryId",
                table: "Events",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTicket_TicketsEventId_TicketsCustomerId",
                table: "EventTicket",
                columns: new[] { "TicketsEventId", "TicketsCustomerId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerTicket");

            migrationBuilder.DropTable(
                name: "EventDetails");

            migrationBuilder.DropTable(
                name: "EventTicket");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
