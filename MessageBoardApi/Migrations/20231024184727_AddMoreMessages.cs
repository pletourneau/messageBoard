using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MessageBoardApi.Migrations
{
    public partial class AddMoreMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05e6d1d6-5085-41a7-a707-4aaea6de8118");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ed7c91d-dea5-457e-aee3-6f3aad746794");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d319e46e-7422-4856-b2f4-3df928d460cf");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Messages",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "acadf174-8e2f-48a1-99e0-ac97ebee12e1", 0, "b5a50d42-a5b6-43c3-b404-d1796b6bab68", null, false, false, null, null, null, null, null, false, "5e218a56-5f80-44ac-8c94-43d8cec15869", false, "ScarySpice" },
                    { "f0fd3a4a-d591-466e-bb4f-764bddfdf765", 0, "42f647e6-54d4-4478-a5f4-56aad6ddf1fd", null, false, false, null, null, null, null, null, false, "85cd0ff2-455a-40e1-9097-79c0912a990b", false, "PoshSpice" },
                    { "ffd73d99-e591-48a6-a2da-bd83d7e619a7", 0, "7d519315-5a41-4ff7-8fa7-043219ea64bb", null, false, false, null, null, null, null, null, false, "cc39422a-5e4c-4b1f-9d24-5409e7fe0c34", false, "GingerSpice" }
                });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                columns: new[] { "UserId", "UserName" },
                values: new object[] { null, "ScarySpice" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "GroupId", "MessageBody", "MessageName", "MessageTime", "UserId", "UserName" },
                values: new object[,]
                {
                    { 50, 2, "is now a skater", "FrancesFarmer", new DateTime(2023, 10, 5, 12, 1, 42, 0, DateTimeKind.Unspecified), null, "PoshSpice" },
                    { 51, 2, "videogame", "TonyHawk", new DateTime(2023, 10, 5, 12, 1, 42, 0, DateTimeKind.Unspecified), null, "GingerSpice" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acadf174-8e2f-48a1-99e0-ac97ebee12e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fd3a4a-d591-466e-bb4f-764bddfdf765");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffd73d99-e591-48a6-a2da-bd83d7e619a7");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 51);

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Messages");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05e6d1d6-5085-41a7-a707-4aaea6de8118", 0, "f7dc770f-36a4-44fb-8489-8dcf50c13e48", null, false, false, null, null, null, null, null, false, "522d5bbc-6fc8-4e92-869c-1c4ffa241803", false, "PoshSpice" },
                    { "5ed7c91d-dea5-457e-aee3-6f3aad746794", 0, "fbe25677-7116-42f0-8ea2-57bb4c847e90", null, false, false, null, null, null, null, null, false, "520c1f5e-e5dd-4cb3-85a3-4477b2bb484b", false, "GingerSpice" },
                    { "d319e46e-7422-4856-b2f4-3df928d460cf", 0, "c59b1f87-8417-4128-a05b-f5379bed3621", null, false, false, null, null, null, null, null, false, "cd7c6854-bcc3-4740-a275-194783708c2e", false, "ScarySpice" }
                });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "UserId",
                value: "ScarySpice");
        }
    }
}
