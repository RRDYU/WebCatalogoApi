using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebCatalogoApi.Migrations
{
    public partial class Criartabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categoria_CategoriaId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "tb_usuarios");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "tb_produtos");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "tb_categorias");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "tb_usuarios",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_CategoriaId",
                table: "tb_produtos",
                newName: "IX_tb_produtos_CategoriaId");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "tb_categorias",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "Criacao",
                table: "tb_empresas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Update",
                table: "tb_empresas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "tb_usuarios",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Criacao",
                table: "tb_usuarios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Update",
                table: "tb_usuarios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Criacao",
                table: "tb_categorias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Update",
                table: "tb_categorias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_usuarios",
                table: "tb_usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_produtos",
                table: "tb_produtos",
                column: "ProdutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_categorias",
                table: "tb_categorias",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "tb_enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    UF = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Criacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_enderecos", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_tb_produtos_tb_categorias_CategoriaId",
                table: "tb_produtos",
                column: "CategoriaId",
                principalTable: "tb_categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_produtos_tb_categorias_CategoriaId",
                table: "tb_produtos");

            migrationBuilder.DropTable(
                name: "tb_enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_usuarios",
                table: "tb_usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_produtos",
                table: "tb_produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_categorias",
                table: "tb_categorias");

            migrationBuilder.DropColumn(
                name: "Criacao",
                table: "tb_empresas");

            migrationBuilder.DropColumn(
                name: "Update",
                table: "tb_empresas");

            migrationBuilder.DropColumn(
                name: "Criacao",
                table: "tb_usuarios");

            migrationBuilder.DropColumn(
                name: "Update",
                table: "tb_usuarios");

            migrationBuilder.DropColumn(
                name: "Criacao",
                table: "tb_categorias");

            migrationBuilder.DropColumn(
                name: "Update",
                table: "tb_categorias");

            migrationBuilder.RenameTable(
                name: "tb_usuarios",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "tb_produtos",
                newName: "Produtos");

            migrationBuilder.RenameTable(
                name: "tb_categorias",
                newName: "Categoria");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_tb_produtos_CategoriaId",
                table: "Produtos",
                newName: "IX_Produtos_CategoriaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categoria",
                newName: "CategoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "ProdutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categoria_CategoriaId",
                table: "Produtos",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
