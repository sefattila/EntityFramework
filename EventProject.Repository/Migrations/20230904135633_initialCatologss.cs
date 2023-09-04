using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventProject.Repository.Migrations
{
    public partial class initialCatologss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerTicket");

            migrationBuilder.DropTable(
                name: "EventTicket");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CustomerId",
                table: "Tickets",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Customers_CustomerId",
                table: "Tickets",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Events_EventId",
                table: "Tickets",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Customers_CustomerId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Events_EventId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_CustomerId",
                table: "Tickets");

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
                name: "IX_EventTicket_TicketsEventId_TicketsCustomerId",
                table: "EventTicket",
                columns: new[] { "TicketsEventId", "TicketsCustomerId" });
        }
    }
}
