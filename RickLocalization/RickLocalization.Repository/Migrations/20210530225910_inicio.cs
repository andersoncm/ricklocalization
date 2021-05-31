using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RickLocalization.Repository.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Dimensao",
                schema: "dbo",
                columns: table => new
                {
                    DimensaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInclusao = table.Column<DateTime>(type: "datetime", nullable: true),
                    NaturezaOperacao = table.Column<string>(type: "char(1)", maxLength: 1, nullable: false),
                    DataOperacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensao", x => x.DimensaoId);
                });

            migrationBuilder.CreateTable(
                name: "Rick",
                schema: "dbo",
                columns: table => new
                {
                    RickId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Foto = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    DimensaoId = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInclusao = table.Column<DateTime>(type: "datetime", nullable: true),
                    NaturezaOperacao = table.Column<string>(type: "char(1)", maxLength: 1, nullable: false),
                    DataOperacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rick", x => x.RickId);
                    table.ForeignKey(
                        name: "FK_Rick_Dimensao_DimensaoId",
                        column: x => x.DimensaoId,
                        principalSchema: "dbo",
                        principalTable: "Dimensao",
                        principalColumn: "DimensaoId");
                });

            migrationBuilder.CreateTable(
                name: "Viagem",
                schema: "dbo",
                columns: table => new
                {
                    ViagemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DimensaoId = table.Column<int>(type: "int", nullable: false),
                    RickId = table.Column<int>(type: "int", nullable: false),
                    Motivo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    DataViagem = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInclusao = table.Column<DateTime>(type: "datetime", nullable: true),
                    NaturezaOperacao = table.Column<string>(type: "char(1)", maxLength: 1, nullable: false),
                    DataOperacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagem", x => x.ViagemId);
                    table.ForeignKey(
                        name: "FK_Viagem_Dimensao_DimensaoId",
                        column: x => x.DimensaoId,
                        principalSchema: "dbo",
                        principalTable: "Dimensao",
                        principalColumn: "DimensaoId");
                    table.ForeignKey(
                        name: "FK_Viagem_Rick_RickId",
                        column: x => x.RickId,
                        principalSchema: "dbo",
                        principalTable: "Rick",
                        principalColumn: "RickId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rick_DimensaoId",
                schema: "dbo",
                table: "Rick",
                column: "DimensaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_DimensaoId",
                schema: "dbo",
                table: "Viagem",
                column: "DimensaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_RickId",
                schema: "dbo",
                table: "Viagem",
                column: "RickId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Viagem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Rick",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Dimensao",
                schema: "dbo");
        }
    }
}
