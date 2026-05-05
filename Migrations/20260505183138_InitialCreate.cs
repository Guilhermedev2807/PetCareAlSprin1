using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetCareAI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_PETCARE_PETS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Especie = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Idade = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Raca = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DataUltimoCheckup = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    PesoAtual = table.Column<double>(type: "BINARY_DOUBLE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PETCARE_PETS", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PETCARE_PETS");
        }
    }
}
