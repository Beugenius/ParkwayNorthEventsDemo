using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class TransactionHasBookingId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BookingId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Transactions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "53bf6edd-598e-4484-be4d-5d22bba9805e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "ea00c262-bd9b-40f3-b79c-cb6fff4b2d35");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "027632fe-5a07-4863-b566-844a6be52d27");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "dd886811-6f61-456c-8a3e-76f2f72d547f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d97818e1-62a1-45c1-8ab7-b2da631ad071", "68e8389c-37d0-477f-80b1-dd56c0e47de2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fec1b9ab-9219-4cf5-8bf2-fd30418c3f5a", "AQAAAAEAACcQAAAAEBZTsqV3B+YdVdjE6UsC8YIYiAqKcX64cu/uu/UOF1cqEkb5UcHQfQzeSg8epKSgUw==", "9e2e4078-05cd-44c5-bb96-d64f2c3e9645" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b7d2a93-b396-4ef0-9387-943a40cb0f8b", "AQAAAAEAACcQAAAAEELfy5KT4pOn/Oy6ij7MGfKn3MbL1bROpvYxYWR+Pi+Fpu9WhJwW0Zh2GOVA6pOeqw==", "8b0423cd-a26c-4e7b-b51a-0bb7c510dcb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a29fd39-029d-4258-bd70-2f00d27c0b4c", "AQAAAAEAACcQAAAAECrF7EhNZaTOxHbRYtOExqGenc1nx347/0BqXVu14yp1ZZvnslJ3dHfvEEu5kwdGhA==", "38a07a5b-30b4-4d25-9d1b-d2c7e8cd084a" });
        }
    }
}
