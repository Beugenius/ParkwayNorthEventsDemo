using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class RequiredFieldsInGalleryImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayImage",
                table: "EventGallery",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayImage",
                table: "EventGallery");

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
        }
    }
}
