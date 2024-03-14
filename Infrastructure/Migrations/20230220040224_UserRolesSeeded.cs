using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class UserRolesSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "8f8110be-bfac-4c41-ab9c-8fe4b8ae7343");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "837a5245-e453-4dec-a16d-cddad9669ca6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "ae7a7689-f673-49a8-9cf9-920e763fde59");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5b562406-58d9-45c5-99a5-a9c6a4fad5db", "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c" },
                    { "5b562406-58d9-45c5-99a5-a9c6a4fad5db", "766c7898-0a5e-451a-aed7-89802904b2a2" },
                    { "fe712b7e-2f2a-443a-8382-6f4c46e9446e", "eb45d5df-4c1d-4126-9977-797ff21a8e18" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f5e60ec0-9e04-429e-95e2-3492d22bccdf", "0de074cb-cb00-48ef-8e71-427d28f6ee2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ed2c959-6b58-48d2-bec0-101d85eb9d39", "AQAAAAEAACcQAAAAEBPlaHtOYsEbzBwl1/ypWWtKk5iBdytLwKPmp6+5HVJjmMN39iedJB3aF1K/eEjm4A==", "6dd0954f-60af-4d84-80e9-93bbeb83a1de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5902d595-722c-4ac4-bc4a-4f7793ff6ed0", "AQAAAAEAACcQAAAAECb8JnJlcl88Uf7gDka4XtG0ldFJeimi7bh7OUybGfSJOEGnW9B3F8Wpl2QlMx5Idg==", "1514a606-27c9-4f26-bd52-590aaa7dff00" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "299ef036-7cc4-4434-9bb6-58475c9cec84", 0, "ecd31808-0e43-4109-a242-ad936bbee791", "ApplicationUser", "Management@ParkwayNorthEvents.com", false, "Parkway", "Management", false, null, "MANAGEMENT@PARKWAYNORTHEVENTS.COM", "MANAGEMENT@PARKWAYNORTHEVENTS.COM", "AQAAAAEAACcQAAAAEEfQWjeClrmMzJdvh5beEXNDIYZvRuI+XsHEhiNM1jd3IlDJnjDGA4fyZefAMr7kaA==", null, false, "1f1eda53-9243-463e-89ab-636b478cb476", false, "Management@ParkwayNorthEvents.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81", "299ef036-7cc4-4434-9bb6-58475c9cec84" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5b562406-58d9-45c5-99a5-a9c6a4fad5db", "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81", "299ef036-7cc4-4434-9bb6-58475c9cec84" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5b562406-58d9-45c5-99a5-a9c6a4fad5db", "766c7898-0a5e-451a-aed7-89802904b2a2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fe712b7e-2f2a-443a-8382-6f4c46e9446e", "eb45d5df-4c1d-4126-9977-797ff21a8e18" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "b087a536-7363-47fb-b884-7dfd3b628e01");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "684b879c-a272-4fa3-826c-4eacff7f7b2c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "d3fad8e4-4138-441c-86c0-2561402023a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb184ed7-5d50-417d-be4d-3c7ac2500f77", "f3fe23f2-026f-4aee-9f13-aa26d647b63c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6311d5da-abd9-445a-9120-5b2067c17d89", "AQAAAAEAACcQAAAAEINBxEm+Azni3r1bXsdCAt9+Ga62jOaqiyPYill7gbTCPTSAU2IRez1Is/kagmSIYA==", "6320d4f7-ea45-4ca5-a559-b94308bb3968" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4046e7e8-2a8a-42c7-9706-fdcbfa57d5df", "AQAAAAEAACcQAAAAEAYpldjockvo3ka0Y1rxkpp7QOR1PpJW2PUWgC/RT930otfMJbHBSCbaaVnDZHGaZA==", "829d57ff-38a1-4b79-82f1-641d0b4ef718" });
        }
    }
}
