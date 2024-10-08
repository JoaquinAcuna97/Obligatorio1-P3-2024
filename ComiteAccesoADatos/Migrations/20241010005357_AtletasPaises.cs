﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComiteAccesoADatos.Migrations
{
    /// <inheritdoc />
    public partial class AtletasPaises : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "paises",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadHabitantes = table.Column<int>(type: "int", nullable: false),
                    NombreContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoContacto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paises", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "atletas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_atletas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_atletas_paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "paises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtletaDisciplina",
                columns: table => new
                {
                    AtletasID = table.Column<int>(type: "int", nullable: false),
                    DisciplinasID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtletaDisciplina", x => new { x.AtletasID, x.DisciplinasID });
                    table.ForeignKey(
                        name: "FK_AtletaDisciplina_atletas_AtletasID",
                        column: x => x.AtletasID,
                        principalTable: "atletas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtletaDisciplina_disciplinas_DisciplinasID",
                        column: x => x.DisciplinasID,
                        principalTable: "disciplinas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtletaDisciplina_DisciplinasID",
                table: "AtletaDisciplina",
                column: "DisciplinasID");

            migrationBuilder.CreateIndex(
                name: "IX_atletas_PaisId",
                table: "atletas",
                column: "PaisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtletaDisciplina");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "atletas");

            migrationBuilder.DropTable(
                name: "disciplinas");

            migrationBuilder.DropTable(
                name: "paises");
        }
    }
}
