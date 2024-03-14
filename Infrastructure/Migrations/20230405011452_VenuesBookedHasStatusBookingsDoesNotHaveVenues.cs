using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class VenuesBookedHasStatusBookingsDoesNotHaveVenues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VenueId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "VenueStatus",
                table: "Bookings");

            migrationBuilder.CreateTable(
                name: "VenuesBooked",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenuesBooked", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VenuesBooked");

            migrationBuilder.AddColumn<string>(
                name: "VenueId",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VenueStatus",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "06e444db-41f0-44d7-871e-d4925c60562d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "43689c52-3507-49b1-b46e-940d92500c85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "bea3d789-8c5b-4232-a763-812fea593711");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "3b296e48-0f7a-4bc5-898b-2cf70fb11794");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c6dc8b32-1bbf-4166-9b6b-6f03df7d9da1", "9ad3c775-8a5a-43a5-b75f-28092536ac6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b0bad65-d5f0-4966-84e4-cc015a550595", "AQAAAAEAACcQAAAAEK5HFSe3aOFid6gdh4ridAD0HVY+DvceqqdUTm7aqlXPbhGqXeqfhmvverg/E9w97w==", "276a9acf-c7fb-464a-b6b6-8a98fab7b315" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94d91a14-83dd-49b6-acf9-457ed54c9d4d", "AQAAAAEAACcQAAAAEJfg7esYNr7Fm01pZUwiUzP/lvCeAfxV2Nl/JdDN8yD2+5QYa0o8IHc2keVMlqoVxQ==", "4c5a2f77-6be4-4006-8739-6bc16fa19947" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80133367-d1ab-46cf-b137-69d31b5fcbc7", "AQAAAAEAACcQAAAAELUrvx1POZJ1l05xSiCHTigp878x4Npmshjokqe9U4OB4pAsIskvesDIGPMpp5Dfhw==", "d5ef1293-b9a5-40ff-b1c4-6dacd16e7e45" });
        }
    }
}
