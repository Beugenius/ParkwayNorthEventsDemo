using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class BookingHasEventTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookingType",
                table: "Bookings",
                newName: "EventTitle");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EventTitle",
                table: "Bookings",
                newName: "BookingType");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "5cbc0107-2fc0-4cd0-9cfd-8248c4509b57");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "97ac65b8-7cb3-47e8-ada1-dfbea548a191");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "caf54401-4475-4ed5-af10-a10043f34d8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "bb86b92c-64c8-4463-8dd5-9246159f69f2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aad26adf-7fde-4ce5-8e3e-a4603115c25e", "c048bbfb-b667-4886-8f6e-2c1a43304b54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18f6c29c-3a68-478b-85ce-ee7ddc3653b8", "AQAAAAEAACcQAAAAEN2yZkqqyHEuhXxauGrTy3YfD24V4vfBP3Z4uJCL3Qm2XxAEJ1eXswKBGhwf7nt/BA==", "5056d140-047e-45b2-b505-5793a7c93e66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdacf829-1286-4ec8-918e-94929f7dcca9", "AQAAAAEAACcQAAAAEDmroB7YkAzZTlTn0JmlhdC0w3xbZk4xDVWy4Lpo/MJcVQuyeLq9tKHSgNJBKEqCrw==", "8e07bf90-578d-467a-ac44-343999d009f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "573ce1cb-05a6-4068-8010-75c3f030e0a0", "AQAAAAEAACcQAAAAEOyRMTcT19vNF2emJNqGF3zaNiqiJwJWkzG3ZpaeZ4yEX5I/RURhgmslOf8u5xtgow==", "33d8174e-0a2c-45b7-9824-d5365e2cddee" });
        }
    }
}
