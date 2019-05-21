using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SafePets.Data.Migrations
{
    public partial class NewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Pessoa");

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Pessoa",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Pessoa");

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagem",
                table: "Pessoa",
                nullable: true);
        }
    }
}
