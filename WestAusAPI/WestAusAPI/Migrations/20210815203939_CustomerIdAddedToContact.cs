using Microsoft.EntityFrameworkCore.Migrations;

namespace WestAusAPI.Migrations
{
    public partial class CustomerIdAddedToContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CustomerId",
                table: "Contacts",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Customers_CustomerId",
                table: "Contacts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Customers_CustomerId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_CustomerId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Contacts");
        }
    }
}
