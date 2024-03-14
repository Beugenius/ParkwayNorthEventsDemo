using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class unregisteredclientrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5b562406-58d9-45c5-99a5-a9c6a4fad5db", "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "557ad5b5-3e21-44e2-8813-dfa08948da75");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "44845674-2c58-4fc0-af19-4c98af1ae667");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "ec140e72-d7d8-49fa-8471-8d2574bd71b0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3aad443b-079e-49e8-9888-caa52f6a2c00", "c0ec244a-e5f3-4064-b70e-010728b5bbbe", "Unregistered Client", "UNREGISTERED CLIENT" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6fa0d8ff-1ad5-474b-b1b7-84cf406865f1", "864a4778-9b1d-4c97-b8e8-ed9b5e2bbfb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11e6d3b5-cdb6-4be1-85dd-088523316817", "AQAAAAEAACcQAAAAEJg00VZsEGi+ZvPjHIBi5QtfYpODcB7Ij4L10+4MZ3qlkmCC0Tsc8MqTQfWPwHI5/w==", "8ddea99c-b81c-42f3-bebd-82b97f6d60e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69bb85bd-4601-4a05-a16f-98c591804285", "AQAAAAEAACcQAAAAELdveMfJDs/X/cvdQZwEQhDdQBZfUTxgkcK+b+UP5zkV7Bf3j1od2ezU8DWY/HzUWA==", "06e00626-3586-4b26-9894-a9f8785f8ae6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a632b15c-340d-4f91-9c3d-39a15e7717ea", "AQAAAAEAACcQAAAAECc2y3fyMiss780yWxBX2MzQD4m138IlC9gtOsWy52ZmBmV2t0S8N1Eb9DmtY/534Q==", "10bccf6c-b5d6-4898-ba09-a8e124893cd3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3aad443b-079e-49e8-9888-caa52f6a2c00", "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3aad443b-079e-49e8-9888-caa52f6a2c00", "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00");

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
                values: new object[] { "5b562406-58d9-45c5-99a5-a9c6a4fad5db", "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f5e60ec0-9e04-429e-95e2-3492d22bccdf", "0de074cb-cb00-48ef-8e71-427d28f6ee2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecd31808-0e43-4109-a242-ad936bbee791", "AQAAAAEAACcQAAAAEEfQWjeClrmMzJdvh5beEXNDIYZvRuI+XsHEhiNM1jd3IlDJnjDGA4fyZefAMr7kaA==", "1f1eda53-9243-463e-89ab-636b478cb476" });

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
        }
    }
}
