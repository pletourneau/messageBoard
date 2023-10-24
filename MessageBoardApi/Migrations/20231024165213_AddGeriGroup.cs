using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MessageBoardApi.Migrations
{
    public partial class AddGeriGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30e1ea10-28a5-49f9-a69f-93907cfb807b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b04d5139-0e0d-4c44-9895-5f5ed3502940");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec822d3a-a065-4876-aabc-07c80e56da11");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 90);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05e6d1d6-5085-41a7-a707-4aaea6de8118", 0, "f7dc770f-36a4-44fb-8489-8dcf50c13e48", null, false, false, null, null, null, null, null, false, "522d5bbc-6fc8-4e92-869c-1c4ffa241803", false, "PoshSpice" },
                    { "5ed7c91d-dea5-457e-aee3-6f3aad746794", 0, "fbe25677-7116-42f0-8ea2-57bb4c847e90", null, false, false, null, null, null, null, null, false, "520c1f5e-e5dd-4cb3-85a3-4477b2bb484b", false, "GingerSpice" },
                    { "d319e46e-7422-4856-b2f4-3df928d460cf", 0, "c59b1f87-8417-4128-a05b-f5379bed3621", null, false, false, null, null, null, null, null, false, "cd7c6854-bcc3-4740-a275-194783708c2e", false, "ScarySpice" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[] { 2, "GeriHalliwellSadSoloCareer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "30e1ea10-28a5-49f9-a69f-93907cfb807b", 0, "3c49c54d-7bec-43f9-87c6-3c8088074d9c", null, false, false, null, null, null, null, null, false, "035bb986-4227-4580-9283-38877507a6d5", false, "GingerSpice" },
                    { "b04d5139-0e0d-4c44-9895-5f5ed3502940", 0, "99a3116e-8f82-4ed3-9474-3035f865013a", null, false, false, null, null, null, null, null, false, "71e67803-f92b-4272-a03a-e3ec69787cc6", false, "ScarySpice" },
                    { "ec822d3a-a065-4876-aabc-07c80e56da11", 0, "2e455ecd-41c8-4fd7-9f8b-ca57b9dddf51", null, false, false, null, null, null, null, null, false, "64647436-dd67-496f-bae8-9a64bf039a27", false, "PoshSpice" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[] { 90, "GeriHalliwellSadSoloCareer" });
        }
    }
}
