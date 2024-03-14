using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class TransactionRemoveConfirmationCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmationCode",
                table: "Transactions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "6da65e42-dabb-4c75-94e8-19f319489177");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "70d2b597-e00e-432a-af79-f37f001ba7c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "3e35715f-44c3-4b53-bf00-35525fab1299");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "0363b826-18c0-49b4-9e5e-e690123f9bfa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5fc70af-5706-4015-b427-58bb0be7b56f", "05138d0a-0c4a-438c-be1c-01b2b6d61387" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fb526c1-af81-421c-bd60-49486940606a", "AQAAAAEAACcQAAAAEByyiExZNKfPEwAUpwHhFtNlLTP5HWANEU66h7W/LlWoOYUX6/4ZMbMIcBZ2z+EcCw==", "50df31b3-be75-4a27-90ff-1007e1e7cafb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58c61287-4623-41d3-aaa4-34dc98adbe2a", "AQAAAAEAACcQAAAAENA9xlZGPBYfzSE1qkHHVtef1WBJaMAG1sqQ22V9+OgbBuNd3F9km+BthAvCefuILw==", "020b3955-01a9-4932-95ae-f4fb3762d7d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00b3ec20-f0bf-4849-a2ea-b6a758bf3387", "AQAAAAEAACcQAAAAELtrwhg4fS3PUusWLVaELEFJBtqiWRPWsHCDpo/J0hEZenUxC/ymJPAdj/FOYwsb2g==", "8deb4faa-c361-46b1-8302-cd42234b2f9b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmationCode",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "5eec8bc4-4298-40ac-ad8b-9413952cca93");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "d0b02ac6-764d-40a0-bd00-93fe55ef5398");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "86dfb16f-5211-4d6f-ab7c-6f05b79549ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "57b26545-8e01-42ce-86c4-7c13e3a52ced");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8a862535-c502-4f2e-b79f-10043e207ac0", "fb81be99-0da9-4731-a5b7-d6d7fcc0c022" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0d4aa82-38ee-4f77-82d9-cbbeb130977d", "AQAAAAEAACcQAAAAEEv1/jz5D+yxdTzjRu16MMY6pd4gevuFs9K5pmuEfcnqNdO96gn6PuaeAQC5JrGuSw==", "c8ac3681-4f77-4821-8fe3-7c31eb9a603a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8e5513d-5494-40ec-b532-36f4d383b2ce", "AQAAAAEAACcQAAAAEHpNOegR8yY6pz6bulTM9i33phVW6x23cSzQFeNqemFH9vKVnDHuQ7K08rTBQJ+M/w==", "d56293c5-b88b-4b7e-87e8-91812baa0193" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3beca9dc-f8e7-473a-9372-620f00d8eb6f", "AQAAAAEAACcQAAAAEO0dspfQc4r1VkxsXreppckXqsDZYyWkXUvkJE05/JUgwQaGhYP5+qXzJL0LHA0C0A==", "9d656b69-d45f-4411-8d21-daa4b2f5d6d9" });
        }
    }
}
