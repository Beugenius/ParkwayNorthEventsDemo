using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class BookingHasTypeEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Bookings");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "c8fc5bac-f6ac-4cae-8ee7-4f61a36e399e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "8c62bb3d-4e1b-45a3-9d11-9f69e9c91ff0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "d5df5e5b-880b-4521-9135-5dcaef2e1ea9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "6b92603b-89f9-458e-bfc7-67d0b9d735f5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a413be8d-613d-4518-96ec-6f091ae6c745", "e8e69ad6-a19d-490d-b544-8e2bceaa70b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc8f2824-6d59-4146-9208-c0af44a1d020", "AQAAAAEAACcQAAAAEGsYGHbZIu3FNlGn7ejIvs1wWcWyEsbAvPmavb1pasoxdtR0ApsjC56a+K90zkpkxQ==", "f252dd3e-62a7-4724-b66b-1e84683192e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19141cb6-1659-4453-b8e1-8f5d697531c6", "AQAAAAEAACcQAAAAEAhNIW7m7a2eM+yG0/oh/RBdy85GpwDdiVfuZOAsbNZybl9cTz9wUkU5Vnd0kOqP7g==", "0c562b58-ed75-475a-93d2-10dc5c023f91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f847c8a-9a90-4d73-9ff3-976972f9ee5c", "AQAAAAEAACcQAAAAEGIL2Zts/tWWJLNcew+8TkLf7VWcNvbxJ605FaAZymirMDNV5J2UjeTrcBFtBHEyVw==", "7c2035c9-8e39-4cd1-bd6d-f41486f4b254" });
        }
    }
}
