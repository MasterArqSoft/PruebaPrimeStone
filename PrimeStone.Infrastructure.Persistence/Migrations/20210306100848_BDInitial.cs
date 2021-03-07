﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimeStone.Infrastructure.Persistence.Migrations
{
    public partial class BDInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Course Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoCurso = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Course code"),
                    NombreCurso = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Course name"),
                    FechaInicio = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()", comment: "Creation date"),
                    FechaFin = table.Column<DateTime>(type: "datetime", nullable: true, comment: "Fin date"),
                    EstaBorrado = table.Column<bool>(type: "bit", maxLength: 1, nullable: false, defaultValue: true, comment: "is deleted state  0:Active  1:deleted"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()", comment: "Creation date"),
                    FechaBorrado = table.Column<DateTime>(type: "datetime", nullable: true, comment: "Deletion Date"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()", comment: "Update date")
                },
                constraints: table => table.PrimaryKey("PK_Curso", x => x.Id));

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Student Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Names"),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Last names"),
                    FechaNacimento = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()", comment: "Date of Birth"),
                    Genero = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    EstaBorrado = table.Column<bool>(type: "bit", maxLength: 1, nullable: false, defaultValue: true, comment: "is deleted state  0:Active  1:deleted"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()", comment: "Creation date"),
                    FechaBorrado = table.Column<DateTime>(type: "datetime", nullable: true, comment: "Deletion Date"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()", comment: "Update date")
                },
                constraints: table => table.PrimaryKey("PK_Estudiante", x => x.Id));

            migrationBuilder.CreateTable(
                name: "Seguridad",
                columns: table => new
                {
                    IdSeguridad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NombreUsuario = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Contrasena = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EstaBorrado = table.Column<bool>(type: "bit", maxLength: 1, nullable: false, defaultValue: true, comment: "is deleted state  0:Active  1:deleted"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()", comment: "Creation date"),
                    FechaBorrado = table.Column<DateTime>(type: "datetime", nullable: true, comment: "Deletion Date"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()", comment: "Update date")
                },
                constraints: table => table.PrimaryKey("PK_Seguridad", x => x.IdSeguridad));

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "date", nullable: false),
                    Telefono = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    EstaBorrado = table.Column<bool>(type: "bit", maxLength: 1, nullable: false, defaultValue: true, comment: "is deleted state  0:Active  1:deleted"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()", comment: "Creation date"),
                    FechaBorrado = table.Column<DateTime>(type: "datetime", nullable: true, comment: "Deletion Date"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()", comment: "Update date")
                },
                constraints: table => table.PrimaryKey("PK_Usuario", x => x.IdUsuario));

            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Direction Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Direction"),
                    TipoDireccion = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    EstudianteId = table.Column<int>(type: "int", nullable: false, comment: "Student Identifier Foreign Key"),
                    EstaBorrado = table.Column<bool>(type: "bit", maxLength: 1, nullable: false, defaultValue: true, comment: "is deleted state  0:Active  1:deleted"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()", comment: "Creation date"),
                    FechaBorrado = table.Column<DateTime>(type: "datetime", nullable: true, comment: "Deletion Date"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()", comment: "Update date")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direccion", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Direction_Student",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstudianteCurso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Student Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstudianteId = table.Column<int>(type: "int", nullable: false, comment: "Student Identifier Foreign Key"),
                    CursoId = table.Column<int>(type: "int", nullable: false, comment: "Course Identifier Foreign Key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudianteCurso", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_StudentCourse_Course",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "Fk_StudentCourse_Student",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "Id", "CodigoCurso", "EstaBorrado", "FechaActualizacion", "FechaBorrado", "FechaCreacion", "FechaFin", "NombreCurso" },
                values: new object[,]
                {
                    { 1, "MATE-01", false, new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(3779), null, new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(3783), null, "MATEMÁTICAS" },
                    { 2, "MECA-02", false, new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(4223), null, new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(4227), null, "MECÁNICA CUÁNTICA" },
                    { 3, "TECU-03", false, new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(4228), null, new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(4230), null, "TEORÍA CUÁNTICA DE CAMPOS" }
                });

            migrationBuilder.InsertData(
                table: "Estudiante",
                columns: new[] { "Id", "Apellidos", "EstaBorrado", "FechaActualizacion", "FechaBorrado", "FechaCreacion", "FechaNacimento", "Genero", "Nombres" },
                values: new object[,]
                {
                    { 1, "RAMOS", false, new DateTime(2021, 3, 6, 5, 8, 48, 43, DateTimeKind.Local).AddTicks(9997), null, new DateTime(2021, 3, 6, 5, 8, 48, 44, DateTimeKind.Local).AddTicks(8642), new DateTime(2000, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), 1, "SERGIO" },
                    { 2, "DIAZ ARANGO", false, new DateTime(2021, 3, 6, 5, 8, 48, 45, DateTimeKind.Local).AddTicks(778), null, new DateTime(2021, 3, 6, 5, 8, 48, 45, DateTimeKind.Local).AddTicks(783), new DateTime(2000, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), 1, "MARTÍN ALEJANDRO" },
                    { 3, "PEREZ LINARES", false, new DateTime(2021, 3, 6, 5, 8, 48, 45, DateTimeKind.Local).AddTicks(786), null, new DateTime(2021, 3, 6, 5, 8, 48, 45, DateTimeKind.Local).AddTicks(787), new DateTime(2000, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), 0, "ANDREA VALERIA" }
                });

            migrationBuilder.InsertData(
                table: "Seguridad",
                columns: new[] { "IdSeguridad", "EstaBorrado", "FechaActualizacion", "FechaBorrado", "FechaCreacion", "Contrasena", "Rol", "Usuario", "NombreUsuario" },
                values: new object[] { 1, false, new DateTime(2021, 3, 6, 5, 8, 48, 47, DateTimeKind.Local).AddTicks(215), null, new DateTime(2021, 3, 6, 5, 8, 48, 47, DateTimeKind.Local).AddTicks(220), "123", "Administrator", "Erwing Candelario", "Erwing" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "IdUsuario", "FechaNacimiento", "Email", "EstaBorrado", "FechaBorrado", "Nombres", "Activo", "Apellidos", "Telefono" },
                values: new object[] { 1, new DateTime(1979, 10, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), "ingeniero_79@Hotmail.com", false, null, "Erwing", true, "Candelario", "3013893448" });

            migrationBuilder.InsertData(
                table: "Direccion",
                columns: new[] { "Id", "EstaBorrado", "EstudianteId", "FechaActualizacion", "FechaBorrado", "FechaCreacion", "Direccion", "TipoDireccion" },
                values: new object[,]
                {
                    { 1, false, 1, new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2043), null, new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2048), "C7CW+84 MADRID, ESPAÑA", 0 },
                    { 2, false, 1, new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2837), null, new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2841), "F88X+2R MADRID, ESPAÑA", 1 },
                    { 3, false, 2, new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2843), null, new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2844), "F972+V7 MADRID, ESPAÑA", 0 },
                    { 4, false, 3, new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2846), null, new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2847), "F8WQ+VG MADRID, ESPAÑA", 2 }
                });

            migrationBuilder.InsertData(
                table: "EstudianteCurso",
                columns: new[] { "Id", "CursoId", "EstudianteId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 3, 2, 1 },
                    { 6, 3, 1 },
                    { 2, 1, 2 },
                    { 4, 2, 2 },
                    { 7, 3, 2 },
                    { 5, 2, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curso_NombreCurso",
                table: "Curso",
                column: "NombreCurso",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Direccion_EstudianteId",
                table: "Direccion",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_EstudianteCurso_CursoId",
                table: "EstudianteCurso",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_EstudianteCurso_EstudianteId",
                table: "EstudianteCurso",
                column: "EstudianteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Direccion");

            migrationBuilder.DropTable(
                name: "EstudianteCurso");

            migrationBuilder.DropTable(
                name: "Seguridad");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Estudiante");
        }
    }
}
