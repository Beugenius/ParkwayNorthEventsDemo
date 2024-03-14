using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class TransactionUsesDecimalInsteadOfFloat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TransactionAmount",
                table: "Transactions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "297011a1-20ea-469d-b1b1-e49551ec1ae2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "55a884f6-1324-4582-8b31-aeeb6187fec1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "80f52eda-cedc-46ba-841e-122fa8dd6488");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "90bd1927-6b3b-4492-848f-b05b73d37408");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d2f90c5-43c6-491a-8140-70a8a67d132e", "be4c073e-cdd7-4011-ae0b-f6647785eecd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c45ee84-4634-43cd-b7fc-bce276a28279", "AQAAAAEAACcQAAAAEMhDaVP4CxDQ8cZ/QNxcG2nsIdmlDS0OmOhnsImB8rsWlVmTmSdI3EnHzelB95K86g==", "bebe07ab-8f02-4544-a73a-eed07e9bcd68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff93ad2a-6fe2-42a8-8168-181a28a8ddbc", "AQAAAAEAACcQAAAAEI9ZtlhLiSe9Er6CQFKiJJYf6xSxKcPia0+oNwscqQBUsxrl4uSrqP1PrKo/kgELMg==", "8a64f434-defa-4cdb-94f2-106ebc2eba7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2301b3f-8f3c-4e26-850d-ba303ee67a3b", "AQAAAAEAACcQAAAAENKNF+XdUIR4ToY+5DwaLBnowia+N5hsJqT6BjqtTksgVT217CC+UHJF60Dt0d9zyg==", "f5481997-a350-4692-9c65-5a1946324907" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "TransactionAmount",
                table: "Transactions",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "a2ecbd2c-e0f4-4d42-83a3-b8385ed89196");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "fe42884f-2246-4a13-8ee0-f87bb60f9e14");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "55a5f497-a921-41fc-9606-17ec213c99ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "c4a68c96-d898-44c2-b5b6-955161fdb581");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "20315382-23d3-45c7-b855-ae2f46e7ef89", "1435ba88-e310-4778-8a5e-160a48c0f36c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "640304bf-5752-4ca6-9833-134d79a12b2a", "AQAAAAEAACcQAAAAEEAN695YbMT2oORN2NX8uPEwgCQd6XEl6HlukTG2V8yN+WczksuMWaU3ZySTam+p1g==", "62f4b557-b661-4705-afe7-20550d0e1a81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87cfa0ff-f50f-44ce-9a23-3435ad51467d", "AQAAAAEAACcQAAAAEL0a8GiAad+XgxCJx+VkqpQCy3bXE4exWyV96LlnJ2iyNAbqxFz9v9+n6zL33UZRtw==", "a18cbb7f-11e6-47b1-aef0-b5e86fa3576f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5485859-b266-4aae-a47c-4cacd18ba223", "AQAAAAEAACcQAAAAECNAXrhlVgEzZFfAVO860PWXx3RHVYQ1Nw8GzgHp2Fo+RbwQfcg7l2ozIYxJJJBjSA==", "4bc7e128-aa4b-423e-b292-7931ca54446b" });
        }
    }
}
