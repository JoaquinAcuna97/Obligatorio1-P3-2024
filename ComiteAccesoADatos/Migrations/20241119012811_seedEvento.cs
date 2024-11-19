using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComiteAccesoADatos.Migrations
{
    /// <inheritdoc />
    public partial class seedEvento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "eventos",
                columns: new[] { "ID", "DisciplinaId", "Nombre", "Inicio", "Fin" },
                values: new object[,]
                {
                    { 1, 1, "Evento Maratón", new DateTime(2024, 5, 1), new DateTime(2024, 5, 2) },   
                    { 2, 2, "Evento Ciclismo", new DateTime(2024, 6, 15), new DateTime(2024, 6, 16) },
                    { 3, 1, "Evento Maratón", new DateTime(2024, 5, 1), new DateTime(2024, 5, 2) },
                    { 4, 2, "Evento Ciclismo", new DateTime(2024, 6, 15), new DateTime(2024, 6, 16) },
                    { 5, 1, "Evento Maratón", new DateTime(2024, 5, 1), new DateTime(2024, 5, 2) },
                    { 6, 2, "Evento Ciclismo", new DateTime(2024, 6, 15), new DateTime(2024, 6, 16) },
                    { 7, 1, "Evento Maratón", new DateTime(2024, 5, 1), new DateTime(2024, 5, 2) },
                    { 8, 2, "Evento Ciclismo", new DateTime(2024, 6, 15), new DateTime(2024, 6, 16) },
                    { 9, 1, "Evento Maratón", new DateTime(2024, 5, 1), new DateTime(2024, 5, 2) },
                    { 10, 2, "Evento Ciclismo", new DateTime(2024, 6, 15), new DateTime(2024, 6, 16) },
                    { 11, 1, "Evento Maratón", new DateTime(2024, 5, 1), new DateTime(2024, 5, 2) },
                    { 12, 2, "Evento Ciclismo", new DateTime(2024, 6, 15), new DateTime(2024, 6, 16) },
                    { 13, 1, "Evento Maratón", new DateTime(2024, 5, 1), new DateTime(2024, 5, 2) },
                    { 14, 2, "Evento Ciclismo", new DateTime(2024, 6, 15), new DateTime(2024, 6, 16) },
                    { 15, 1, "Evento Maratón", new DateTime(2024, 5, 1), new DateTime(2024, 5, 2) },
                    { 16, 2, "Evento Ciclismo", new DateTime(2024, 6, 15), new DateTime(2024, 6, 16) },
                    { 17, 1, "Evento Maratón", new DateTime(2024, 5, 1), new DateTime(2024, 5, 2) },
                    { 18, 2, "Evento Ciclismo", new DateTime(2024, 6, 15), new DateTime(2024, 6, 16) }

                });

            // Insertar datos en la tabla de EventoAtleta (relación muchos a muchos)
            migrationBuilder.InsertData(
                table: "eventosAtletas",
                columns: new[] { "ID", "EventoId", "AtletaId", "Puntaje" },
                values: new object[,]
                {
                { 1, 1, 1, 95.5m },
                { 2, 1, 2, 92.3m },
                { 3, 2, 1, 89.1m },
                { 4, 2, 3, 91.7m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtletaDisciplina");

            migrationBuilder.DropTable(
                name: "eventosAtletas");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "atletas");

            migrationBuilder.DropTable(
                name: "eventos");

            migrationBuilder.DropTable(
                name: "paises");

            migrationBuilder.DropTable(
                name: "disciplinas");
        }
    }
}
