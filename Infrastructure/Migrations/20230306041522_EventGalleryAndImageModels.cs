using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class EventGalleryAndImageModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "89094cac-0d39-4178-90ca-fcaa3118a1fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "3754ea13-bca0-4694-abed-c8222d204716");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "7ca22d65-e7d7-4246-877f-e1a0342dca89");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "a8b41db4-5a69-403e-ae6c-5b3ab9b489ce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dc1753ad-ed50-46c1-a08e-8d05b0930a40", "cd02bc4a-86de-46fb-88f6-ff3416e9c566" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34775072-c3c0-4948-b990-e5c7de74c09f", "AQAAAAEAACcQAAAAEOO2MpLemUoPxed8FV/6nffAuoQdijoQVs2iG84ljh7G3jNSY5qmAhe+xFfY6LSsVQ==", "2c2196c0-8467-4c44-9e44-b6b551b6e987" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07d3976f-97b2-4a34-a45a-7312e8cc080a", "AQAAAAEAACcQAAAAEKqoSFUpFYJsoXL3N8sjgM7GtAdoCnvWBM3jB3Vy6yr/cf1d7GpXN3UnxYFgXWILHg==", "2327f926-a66b-4efe-8f19-9682e94ebbc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11e04f4b-dd82-4592-9da7-60fc49b8d74b", "AQAAAAEAACcQAAAAEF68ir0uij4zUD2nyJX+eO8jIDpv34Zz08BUUBla0cgYzci/E0LR5R9RupJ0Wy8J1A==", "b073e1ed-8e42-4b54-9317-2161c75ff0cc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "557ad5b5-3e21-44e2-8813-dfa08948da75");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "c0ec244a-e5f3-4064-b70e-010728b5bbbe");

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
        }
    }
}
