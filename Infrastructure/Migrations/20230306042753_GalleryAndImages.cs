using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class GalleryAndImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventGallery",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameOfEvent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventGallery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GalleryImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventGalleryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GalleryImages_EventGallery_EventGalleryId",
                        column: x => x.EventGalleryId,
                        principalTable: "EventGallery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "e3ad5d6d-8fbe-4741-961d-1555865902ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "79dae545-0eb7-469d-8178-9fc33a45bab2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "c0e51a70-5cfa-46dd-b833-21fd336362ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "72266a7d-286f-4921-9fc0-c1af49977c1d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fcdd416f-63b6-4674-a643-d41babde6131", "7aea3454-86a7-4e27-aa5a-5d0d1ea39e7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e25ca0b-4ef9-4ded-b7aa-81c5ad5070d3", "AQAAAAEAACcQAAAAEOvQlioBOHcgISnvXwRT2U7NBIvKDQgNEydTm0NCFejDVJ4GlvCVEqPJVXtoPkQ9cQ==", "44713092-cd63-4e07-a121-90262617ca45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f1ccfc8-8999-4d42-9782-f32a0a74d37c", "AQAAAAEAACcQAAAAEKcwjfX6S4e0a24IuAbS/1GgtWUPvdPgqz6CgO05kTACUYeFTB4OdhGOn9uLf0PW9A==", "1faa71ff-3706-4477-b23a-788457997815" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7b92a3b-932b-4138-9035-589709b51a9e", "AQAAAAEAACcQAAAAEOUCAF2iZLP8BDxYQIW1m4oI9kqME8caiPyNyzXVn+oD+loQB1K8OLX/OAeI/q9oMA==", "e03c0be9-144b-4f44-9813-57c14005051b" });

            migrationBuilder.CreateIndex(
                name: "IX_GalleryImages_EventGalleryId",
                table: "GalleryImages",
                column: "EventGalleryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GalleryImages");

            migrationBuilder.DropTable(
                name: "EventGallery");

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
    }
}
