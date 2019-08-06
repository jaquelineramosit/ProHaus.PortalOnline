using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProHaus.PortalOnline.Repositorio.Migrations
{
    public partial class PrimeiraVersaoBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 150, nullable: false),
                    Cidade = table.Column<string>(maxLength: 150, nullable: false),
                    Estado = table.Column<string>(maxLength: 150, nullable: false),
                    Telefone = table.Column<string>(maxLength: 15, nullable: false),
                    Skype = table.Column<string>(maxLength: 100, nullable: false),
                    CNPJ = table.Column<string>(maxLength: 14, nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    DataUltModif = table.Column<DateTime>(nullable: false),
                    FornecedorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fornecedores_Fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PerfilAcessos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Perfil = table.Column<string>(maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(maxLength: 150, nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    DataUltModif = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilAcessos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoProdutos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 150, nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    DataUltModif = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProdutos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unidades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 150, nullable: false),
                    Logradouro = table.Column<string>(maxLength: 250, nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(maxLength: 150, nullable: true),
                    Bairro = table.Column<string>(maxLength: 100, nullable: false),
                    CEP = table.Column<string>(maxLength: 10, nullable: false),
                    Cidade = table.Column<string>(maxLength: 100, nullable: false),
                    Estado = table.Column<string>(maxLength: 2, nullable: false),
                    Telefone = table.Column<string>(maxLength: 15, nullable: false),
                    Celular = table.Column<string>(maxLength: 15, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataUltModif = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AcessoPaginas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PerfilAcessoId = table.Column<int>(nullable: false),
                    NomePagina = table.Column<string>(maxLength: 100, nullable: false),
                    SubPagina = table.Column<string>(maxLength: 100, nullable: true),
                    Funcao = table.Column<string>(maxLength: 100, nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    DataUltModif = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcessoPaginas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcessoPaginas_PerfilAcessos_PerfilAcessoId",
                        column: x => x.PerfilAcessoId,
                        principalTable: "PerfilAcessos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoProdutoId = table.Column<int>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 100, nullable: false),
                    ParNumber = table.Column<string>(maxLength: 2, nullable: false),
                    Nome = table.Column<string>(maxLength: 250, nullable: false),
                    Custo = table.Column<decimal>(nullable: false),
                    FornecedorId = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    DataUltModif = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produtos_TipoProdutos_TipoProdutoId",
                        column: x => x.TipoProdutoId,
                        principalTable: "TipoProdutos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(maxLength: 150, nullable: false),
                    Senha = table.Column<string>(maxLength: 400, nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    UnidadeId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(maxLength: 100, nullable: true),
                    Sobrenome = table.Column<string>(maxLength: 150, nullable: true),
                    PerfilAcessoId = table.Column<int>(nullable: false),
                    DataUltModif = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_PerfilAcessos_PerfilAcessoId",
                        column: x => x.PerfilAcessoId,
                        principalTable: "PerfilAcessos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Unidades_UnidadeId",
                        column: x => x.UnidadeId,
                        principalTable: "Unidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcessoPaginas_PerfilAcessoId",
                table: "AcessoPaginas",
                column: "PerfilAcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_FornecedorId",
                table: "Fornecedores",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_FornecedorId",
                table: "Produtos",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_TipoProdutoId",
                table: "Produtos",
                column: "TipoProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PerfilAcessoId",
                table: "Usuarios",
                column: "PerfilAcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UnidadeId",
                table: "Usuarios",
                column: "UnidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcessoPaginas");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropTable(
                name: "TipoProdutos");

            migrationBuilder.DropTable(
                name: "PerfilAcessos");

            migrationBuilder.DropTable(
                name: "Unidades");
        }
    }
}
