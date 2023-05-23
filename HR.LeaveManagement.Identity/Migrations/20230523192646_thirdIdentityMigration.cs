using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Identity.Migrations
{
    /// <inheritdoc />
    public partial class thirdIdentityMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "100689ec-b435-492a-a457-80769071becc", "AQAAAAIAAYagAAAAEOaM/hjrzA7wHZrQP/5WuEG0qn/IUCQYukVG+E6mtWoXeuN1kcReeYJ7gav8oBF33g==", "a6c5a459-cb9b-434e-9793-e1586b958e86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b06f7cf-5dbe-4118-888f-eae53994c8e8", "AQAAAAIAAYagAAAAEGnUXukGFD3PpK0LNq4ByN1tt4VNmwsyyVVhRL8YGoj6FUq+KXVPCkbtNg7lWeK1Dw==", "64007c7b-4901-4730-97df-34aac4cd1d87" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcf598b1-add9-4bed-9ca6-da4929f94ce4", "AQAAAAIAAYagAAAAEHpDJnhr2+yHBxEwq5qK6C1OaJrQ+mwOFSQgeVJ3ypMBvaKtPec5EDiMJl11xCTiCg==", "bccba26b-ba8f-470f-ad84-3846e3744953" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3ec2796-75df-4535-8d55-6dea99a09285", "AQAAAAIAAYagAAAAELm2joj+EzX41J7SSPHk5XKPZ7gABtw7wvg8jYUsRR4XOJ2BpH2V+Of3JEfB3431gA==", "cd4e4758-32c3-4d1f-97f3-4361789663cf" });
        }
    }
}
