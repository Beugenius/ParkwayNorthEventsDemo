using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class clientnameinbooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "Bookings");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "8b8939c7-80be-4ee1-b4ff-1b31260de67e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "3380cc2f-0511-44c9-a93c-f8c3ac362287");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "fa2de563-73bd-4c03-a0cc-9ab7951bbfec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "5f459403-2fae-496a-bb22-e5bb56de8275");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1c97f7a8-a583-49e6-8dfe-412ae50b15b6", "a5ae6b72-beac-4740-9d0d-9ba18f4865f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0abcbc1-d1b4-43c4-bfc6-b06b87286769", "AQAAAAEAACcQAAAAEItJSwvdBSsPMJ4uFDsk7CFK6ZEFZB7x160GT1q9jGg40ycmjSP34Lq4bCi8RzNMlg==", "4459efc3-d570-4eb4-8931-60f500012c37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d0d64cc-d87a-4cdf-a105-cbf5a1194627", "AQAAAAEAACcQAAAAEAKvOjhSV+l1VxvSJ+bEAA562phivt8HP3DFMre5kDHLonRWaCK74bZMpMuuJrcSXw==", "ce90cb67-ad6e-47a1-8811-961814d52b3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d68fe07f-8882-455d-9ad5-2a881178dd28", "AQAAAAEAACcQAAAAEEOVmREhHE11XC/lh1qSjr7o6r3G/4qDH/E+IQMrNMmcdYxq49JoBUIkugwFilItTQ==", "57b30d9d-fcee-40ba-aff9-b098ecf8d3f1" });
        }
    }
}
