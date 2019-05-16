using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SafePets.Data.Migrations
{
    public partial class RemoveImagePet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Pet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Imagem",
                table: "Pet",
                nullable: true);
        }
    }
}
