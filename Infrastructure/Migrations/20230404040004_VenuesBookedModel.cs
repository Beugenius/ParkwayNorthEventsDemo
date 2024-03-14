using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class VenuesBookedModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "e16fdeff-8950-4c5c-96c2-2cb7b3c3a8a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "e6f80994-5a52-44bd-8e7f-5c51b6aae193");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "23ba0b51-edfa-47e9-aa5d-487a1bca6c60");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "17c6c1d2-cd9a-48e3-aa9c-8cb0641277aa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8db4f501-2b3b-4f83-9f8b-ab1fcf68f075", "7c1743be-9b71-4280-afd8-de274a941901" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54bc68ea-dd19-4be2-b591-e1a504de7638", "AQAAAAEAACcQAAAAEHRTK7oEYgZLEY3O7ufAWmEXZXoNBFG7s7+nRDSGbVGZiCKX5VA59VLgB12KGju4IQ==", "dbd37853-f787-4f61-ae45-de7a3c4bf1ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5376144-1d63-46c1-bbb4-e27bc0fd846f", "AQAAAAEAACcQAAAAEGaLkO9fIcAvOznm91Gp9zcjn6TmyjDexCw44+0aCMak7zZkbm3zV8TGL4Tp1OzYNQ==", "0e982abf-269e-4430-be2f-2fe76c7b2261" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7504b0a6-b37f-4b77-9ed4-0ae657adeba9", "AQAAAAEAACcQAAAAECnEmyNRTYKsRga35bo4EVMoPwVo0Dm64wPdJRzYanDrQshHw7PMRLVLiT1iyA0/hg==", "178a40e9-6cd2-48ca-a119-cf0339350e5a" });
        }
    }
}
