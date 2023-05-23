﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddmoreAuditFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 23, 19, 29, 37, 913, DateTimeKind.Local).AddTicks(366), new DateTime(2023, 5, 23, 19, 29, 37, 913, DateTimeKind.Local).AddTicks(443) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 20, 57, 18, 743, DateTimeKind.Local).AddTicks(7148), new DateTime(2023, 5, 22, 20, 57, 18, 743, DateTimeKind.Local).AddTicks(7206) });
        }
    }
}
