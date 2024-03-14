using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class GalleryImageAzureStorageUri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GalleryImages_EventGallery_EventGalleryId",
                table: "GalleryImages");

            migrationBuilder.DropIndex(
                name: "IX_GalleryImages_EventGalleryId",
                table: "GalleryImages");

            migrationBuilder.AddColumn<string>(
                name: "AzureStorageUri",
                table: "GalleryImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "f5b6fc28-fc15-4079-910d-ee26f6d1779d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "c29a3dfa-41a5-42ca-b6f9-299541e7163f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "1b767746-4934-45ec-9567-3de0e48974b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "f8a57594-7d8a-4f4c-9076-4eb9c02f5ddc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7fb3adda-73be-4a44-8b56-ea59ba877c6a", "ec584bf6-80a7-4d1a-ae64-9a1814d26cb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8774d17-416c-499c-94ce-03a56650ab01", "AQAAAAEAACcQAAAAEDjcmwlJhQRGB9Zg3hHhIN/loLgybcDTg6Ii/o7mwJNW7XzSN+qRiSA2YsKbj74A9g==", "5f938bde-1038-42fd-8519-436359d02970" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e009d2f-194b-40cd-bad1-1e6d500686b1", "AQAAAAEAACcQAAAAEPXdDD7MK5Sk5Emzy7KUbfsoT+pYfrfVlsOtEmfsUlIFwZQ0/ymUgr+mnDjCzSI28g==", "d2606cd4-c93d-4e42-8a1f-4389da094634" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa387849-dede-4f7c-b330-7b708717a859", "AQAAAAEAACcQAAAAEGOTTjvYXFNzw+wT1oPw6e/8k6dobctvXPQV498aq6iqZBVHTpQNjsK1eXO95jf8pQ==", "c387a6eb-daf1-4abe-b086-78436484a4d9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AzureStorageUri",
                table: "GalleryImages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                column: "ConcurrencyStamp",
                value: "6da65e42-dabb-4c75-94e8-19f319489177");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aad443b-079e-49e8-9888-caa52f6a2c00",
                column: "ConcurrencyStamp",
                value: "70d2b597-e00e-432a-af79-f37f001ba7c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                column: "ConcurrencyStamp",
                value: "3e35715f-44c3-4b53-bf00-35525fab1299");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                column: "ConcurrencyStamp",
                value: "0363b826-18c0-49b4-9e5e-e690123f9bfa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5fc70af-5706-4015-b427-58bb0be7b56f", "05138d0a-0c4a-438c-be1c-01b2b6d61387" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ef036-7cc4-4434-9bb6-58475c9cec84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fb526c1-af81-421c-bd60-49486940606a", "AQAAAAEAACcQAAAAEByyiExZNKfPEwAUpwHhFtNlLTP5HWANEU66h7W/LlWoOYUX6/4ZMbMIcBZ2z+EcCw==", "50df31b3-be75-4a27-90ff-1007e1e7cafb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766c7898-0a5e-451a-aed7-89802904b2a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58c61287-4623-41d3-aaa4-34dc98adbe2a", "AQAAAAEAACcQAAAAENA9xlZGPBYfzSE1qkHHVtef1WBJaMAG1sqQ22V9+OgbBuNd3F9km+BthAvCefuILw==", "020b3955-01a9-4932-95ae-f4fb3762d7d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00b3ec20-f0bf-4849-a2ea-b6a758bf3387", "AQAAAAEAACcQAAAAELtrwhg4fS3PUusWLVaELEFJBtqiWRPWsHCDpo/J0hEZenUxC/ymJPAdj/FOYwsb2g==", "8deb4faa-c361-46b1-8302-cd42234b2f9b" });

            migrationBuilder.CreateIndex(
                name: "IX_GalleryImages_EventGalleryId",
                table: "GalleryImages",
                column: "EventGalleryId");

            migrationBuilder.AddForeignKey(
                name: "FK_GalleryImages_EventGallery_EventGalleryId",
                table: "GalleryImages",
                column: "EventGalleryId",
                principalTable: "EventGallery",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
