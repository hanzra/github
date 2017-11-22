using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FitnessCenter.Domain.Migrations
{
    public partial class UserIDFieldChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registration_AspNetUsers_AppUserId",
                table: "Registration");

            migrationBuilder.DropIndex(
                name: "IX_Registration_AppUserId",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Registration");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Registration",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Registration_UserId",
                table: "Registration",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_AspNetUsers_UserId",
                table: "Registration",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registration_AspNetUsers_UserId",
                table: "Registration");

            migrationBuilder.DropIndex(
                name: "IX_Registration_UserId",
                table: "Registration");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Registration",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Registration",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Registration_AppUserId",
                table: "Registration",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_AspNetUsers_AppUserId",
                table: "Registration",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
