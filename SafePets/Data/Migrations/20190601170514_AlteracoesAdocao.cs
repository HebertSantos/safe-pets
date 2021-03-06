﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SafePets.Data.Migrations
{
    public partial class AlteracoesAdocao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adocao_Pessoa_PessoaId",
                table: "Adocao");

            migrationBuilder.DropForeignKey(
                name: "FK_Adocao_Pet_PetId",
                table: "Adocao");

            migrationBuilder.AlterColumn<int>(
                name: "PetId",
                table: "Adocao",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PessoaId",
                table: "Adocao",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Adocao_Pessoa_PessoaId",
                table: "Adocao",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Adocao_Pet_PetId",
                table: "Adocao",
                column: "PetId",
                principalTable: "Pet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adocao_Pessoa_PessoaId",
                table: "Adocao");

            migrationBuilder.DropForeignKey(
                name: "FK_Adocao_Pet_PetId",
                table: "Adocao");

            migrationBuilder.AlterColumn<int>(
                name: "PetId",
                table: "Adocao",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PessoaId",
                table: "Adocao",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Adocao_Pessoa_PessoaId",
                table: "Adocao",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adocao_Pet_PetId",
                table: "Adocao",
                column: "PetId",
                principalTable: "Pet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
