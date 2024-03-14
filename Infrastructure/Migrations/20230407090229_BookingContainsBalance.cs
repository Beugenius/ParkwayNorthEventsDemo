using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class BookingContainsBalance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "Bookings",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "53bf6edd-598e-4484-be4d-5d22bba9805e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "ea00c262-bd9b-40f3-b79c-cb6fff4b2d35");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "027632fe-5a07-4863-b566-844a6be52d27");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "dd886811-6f61-456c-8a3e-76f2f72d547f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d97818e1-62a1-45c1-8ab7-b2da631ad071", "68e8389c-37d0-477f-80b1-dd56c0e47de2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fec1b9ab-9219-4cf5-8bf2-fd30418c3f5a", "AQAAAAEAACcQAAAAEBZTsqV3B+YdVdjE6UsC8YIYiAqKcX64cu/uu/UOF1cqEkb5UcHQfQzeSg8epKSgUw==", "9e2e4078-05cd-44c5-bb96-d64f2c3e9645" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b7d2a93-b396-4ef0-9387-943a40cb0f8b", "AQAAAAEAACcQAAAAEELfy5KT4pOn/Oy6ij7MGfKn3MbL1bROpvYxYWR+Pi+Fpu9WhJwW0Zh2GOVA6pOeqw==", "8b0423cd-a26c-4e7b-b51a-0bb7c510dcb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a29fd39-029d-4258-bd70-2f00d27c0b4c", "AQAAAAEAACcQAAAAECrF7EhNZaTOxHbRYtOExqGenc1nx347/0BqXVu14yp1ZZvnslJ3dHfvEEu5kwdGhA==", "38a07a5b-30b4-4d25-9d1b-d2c7e8cd084a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Bookings");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "7fed1260-2496-45c4-bb50-abad4662a239");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "7a5d1923-443a-4323-8575-fb9c6bb619a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "d3dbb63d-3d43-4592-8938-4624ca078a85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "9ae186f4-a353-4580-8524-ee63e4b0b804");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6f7049e-b1ad-4eac-b79f-961416cbaa45", "fde34b93-aa23-4c3f-bd7a-0d9049e9344c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a33204c2-d542-42db-80ef-fc3415d400a0", "AQAAAAEAACcQAAAAELIiMqUaOYCZc0N/iGYhuOZawc8WaTX66121MhUY2iMPac00nAuET/UcCJQkKRiJsQ==", "6d83e5de-8ece-4aa0-a933-6675a76076bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bad980bc-04db-4873-aca7-30211c3ccede", "AQAAAAEAACcQAAAAEJ8vKl17apxJcRedENqNz6eT6ROdAj8aWW8n7R5DpFO8IgiTO7SV6V267vH4gSoYBw==", "bebd0c77-77ea-486d-ad0f-a88e5d1a09ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c372649-5ac1-40a3-b442-4d8ca22ebaf6", "AQAAAAEAACcQAAAAEPfJUuzZ/6ELpBQPaqPxcOiISJD6NH8hn3GzFgmtRr9YLUMtTuzTkLdrphnEBiCBdA==", "57e20bfd-35e5-49cd-844e-31e1805b25a7" });
        }
    }
}
