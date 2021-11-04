using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoClasesParticulares.Migrations
{
    public partial class ProyectoClasesParticularesContextClasesParticularesDatabaseContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    idAlumno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    mail = table.Column<string>(nullable: true),
                    escuela = table.Column<string>(nullable: true),
                    fechaNacimiento = table.Column<DateTime>(nullable: false),
                    grado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.idAlumno);
                });

            migrationBuilder.CreateTable(
                name: "Docente",
                columns: table => new
                {
                    idDocente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    mail = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docente", x => x.idDocente);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    idMateria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    DocenteidDocente = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.idMateria);
                    table.ForeignKey(
                        name: "FK_Materias_Docente_DocenteidDocente",
                        column: x => x.DocenteidDocente,
                        principalTable: "Docente",
                        principalColumn: "idDocente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    idClase = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaYHora = table.Column<DateTime>(nullable: false),
                    tema = table.Column<string>(nullable: true),
                    idMateria = table.Column<int>(nullable: false),
                    materiaidMateria = table.Column<int>(nullable: true),
                    idAlumno = table.Column<int>(nullable: false),
                    alumnoidAlumno = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases", x => x.idClase);
                    table.ForeignKey(
                        name: "FK_Clases_Alumnos_alumnoidAlumno",
                        column: x => x.alumnoidAlumno,
                        principalTable: "Alumnos",
                        principalColumn: "idAlumno",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clases_Materias_materiaidMateria",
                        column: x => x.materiaidMateria,
                        principalTable: "Materias",
                        principalColumn: "idMateria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clases_alumnoidAlumno",
                table: "Clases",
                column: "alumnoidAlumno");

            migrationBuilder.CreateIndex(
                name: "IX_Clases_materiaidMateria",
                table: "Clases",
                column: "materiaidMateria");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_DocenteidDocente",
                table: "Materias",
                column: "DocenteidDocente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clases");

            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Docente");
        }
    }
}
