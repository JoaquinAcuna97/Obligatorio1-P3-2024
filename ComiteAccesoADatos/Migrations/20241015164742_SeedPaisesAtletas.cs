﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComiteAccesoADatos.Migrations
{
    /// <inheritdoc />
    public partial class SeedPaisesAtletas : Migration
    {
        /// <inheritdoc />

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            "paises",
            new[] { "ID", "NombrePais", "NombreContacto", "CantidadHabitantes", "TelefonoContacto" },
            new object[,]
            {
                { 1, "Uruguay", "Milton Winan", 3000000, "+5465497898321" },
                { 2, "Argentina", "Lucia Gomez", 45000000, "+5491123456789" },
                { 3, "Brazil", "Carlos Silva", 211000000, "+5511987654321" },
                { 4, "Chile", "Sofia Torres", 19000000, "+56612345678" },
                { 5, "Colombia", "Juan Martinez", 50000000, "+573012345678" },
                { 6, "Mexico", "Ana Ruiz", 126000000, "+5215551234567" },
                { 7, "Peru", "Pedro Lopez", 32000000, "+519876543210" },
                { 8, "Paraguay", "Marta Fernandez", 7000000, "+595981234567" },
                { 9, "Venezuela", "Luis Rodriguez", 28000000, "+582121234567" },
                { 10, "Ecuador", "Julia Castillo", 17000000, "+593987654321" }
            }
            );
            migrationBuilder.InsertData(
            "atletas",
            new[] { "ID", "Nombre", "Sexo", "PaisId" },
            new object[,]
            {
                { 1, "Milton Winan", "M", 1 },
                { 2, "Sofia Rodriguez", "F", 1 },
                { 3, "Lucia Gomez", "F", 2 },
                { 4, "Carlos Silva", "M", 2 },
                { 5, "Ana Ruiz", "F", 3 },
                { 6, "Pedro Martinez", "M", 3 },
                { 7, "Sofia Torres", "F", 4 },
                { 8, "Juan Herrera", "M", 4 },
                { 9, "Maria Fernandez", "F", 5 },
                { 10, "Luis Ramirez", "M", 5 },
                { 11, "Clara Sanchez", "F", 6 },
                { 12, "Miguel Alvarez", "M", 6 },
                { 13, "Julia Castillo", "F", 7 },
                { 14, "Roberto Perez", "M", 7 },
                { 15, "Natalia Gomez", "F", 8 },
                { 16, "Diego Lopez", "M", 8 },
                { 17, "Isabella Torres", "F", 9 },
                { 18, "Andres Jimenez", "M", 9 },
                { 19, "Valentina Rojas", "F", 10 },
                { 20, "Fernando Vasquez", "M", 10 }
            }
            );

        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}