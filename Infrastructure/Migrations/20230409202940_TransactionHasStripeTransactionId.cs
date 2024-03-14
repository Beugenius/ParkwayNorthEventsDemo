using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class TransactionHasStripeTransactionId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StripeTransactionId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StripeTransactionId",
                table: "Transactions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "297011a1-20ea-469d-b1b1-e49551ec1ae2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "55a884f6-1324-4582-8b31-aeeb6187fec1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "80f52eda-cedc-46ba-841e-122fa8dd6488");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "90bd1927-6b3b-4492-848f-b05b73d37408");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d2f90c5-43c6-491a-8140-70a8a67d132e", "be4c073e-cdd7-4011-ae0b-f6647785eecd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c45ee84-4634-43cd-b7fc-bce276a28279", "AQAAAAEAACcQAAAAEMhDaVP4CxDQ8cZ/QNxcG2nsIdmlDS0OmOhnsImB8rsWlVmTmSdI3EnHzelB95K86g==", "bebe07ab-8f02-4544-a73a-eed07e9bcd68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff93ad2a-6fe2-42a8-8168-181a28a8ddbc", "AQAAAAEAACcQAAAAEI9ZtlhLiSe9Er6CQFKiJJYf6xSxKcPia0+oNwscqQBUsxrl4uSrqP1PrKo/kgELMg==", "8a64f434-defa-4cdb-94f2-106ebc2eba7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2301b3f-8f3c-4e26-850d-ba303ee67a3b", "AQAAAAEAACcQAAAAENKNF+XdUIR4ToY+5DwaLBnowia+N5hsJqT6BjqtTksgVT217CC+UHJF60Dt0d9zyg==", "f5481997-a350-4692-9c65-5a1946324907" });
        }
    }
}
