﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetAPI.Migrations
{
    /// <inheritdoc />
    public partial class user_mobile_filed_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "Users",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Users");
        }
    }
}
