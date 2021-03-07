﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrimeStone.Infrastructure.Persistence;

namespace PrimeStone.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(PrimeStoneDbContext))]
    partial class PrimeStoneDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PrimeStone.Core.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasComment("Course Identifier")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoCurso")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CodigoCurso")
                        .HasComment("Course code");

                    b.Property<bool>("EstaBorrado")
                        .HasMaxLength(1)
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("EstaBorrado")
                        .HasComment("is deleted state  0:Active  1:deleted");

                    b.Property<DateTime>("FechaActualizacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("FechaActualizacion")
                        .HasDefaultValueSql("getdate()")
                        .HasComment("Update date");

                    b.Property<DateTime?>("FechaBorrado")
                        .HasColumnType("datetime")
                        .HasColumnName("FechaBorrado")
                        .HasComment("Deletion Date");

                    b.Property<DateTime>("FechaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("FechaCreacion")
                        .HasDefaultValueSql("getdate()")
                        .HasComment("Creation date");

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("datetime")
                        .HasColumnName("FechaFin")
                        .HasComment("Fin date");

                    b.Property<DateTime>("FechaInicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("FechaInicio")
                        .HasDefaultValueSql("getdate()")
                        .HasComment("Creation date");

                    b.Property<string>("NombreCurso")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NombreCurso")
                        .HasComment("Course name");

                    b.HasKey("Id");

                    b.HasIndex("NombreCurso")
                        .IsUnique();

                    b.ToTable("Curso");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CodigoCurso = "MATE-01",
                            EstaBorrado = false,
                            FechaActualizacion = new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(3779),
                            FechaCreacion = new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(3783),
                            FechaInicio = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NombreCurso = "MATEMÁTICAS"
                        },
                        new
                        {
                            Id = 2,
                            CodigoCurso = "MECA-02",
                            EstaBorrado = false,
                            FechaActualizacion = new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(4223),
                            FechaCreacion = new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(4227),
                            FechaInicio = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NombreCurso = "MECÁNICA CUÁNTICA"
                        },
                        new
                        {
                            Id = 3,
                            CodigoCurso = "TECU-03",
                            EstaBorrado = false,
                            FechaActualizacion = new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(4228),
                            FechaCreacion = new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(4230),
                            FechaInicio = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NombreCurso = "TEORÍA CUÁNTICA DE CAMPOS"
                        });
                });

            modelBuilder.Entity("PrimeStone.Core.Models.Direccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasComment("Direction Identifier")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EstaBorrado")
                        .HasMaxLength(1)
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("EstaBorrado")
                        .HasComment("is deleted state  0:Active  1:deleted");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int")
                        .HasColumnName("EstudianteId")
                        .HasComment("Student Identifier Foreign Key");

                    b.Property<DateTime>("FechaActualizacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("FechaActualizacion")
                        .HasDefaultValueSql("getdate()")
                        .HasComment("Update date");

                    b.Property<DateTime?>("FechaBorrado")
                        .HasColumnType("datetime")
                        .HasColumnName("FechaBorrado")
                        .HasComment("Deletion Date");

                    b.Property<DateTime>("FechaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("FechaCreacion")
                        .HasDefaultValueSql("getdate()")
                        .HasComment("Creation date");

                    b.Property<string>("StringDireccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Direccion")
                        .HasComment("Direction");

                    b.Property<int>("TipoDireccion")
                        .HasMaxLength(1)
                        .HasColumnType("int")
                        .HasColumnName("TipoDireccion");

                    b.HasKey("Id");

                    b.HasIndex("EstudianteId");

                    b.ToTable("Direccion");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EstaBorrado = false,
                            EstudianteId = 1,
                            FechaActualizacion = new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2043),
                            FechaCreacion = new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2048),
                            StringDireccion = "C7CW+84 MADRID, ESPAÑA",
                            TipoDireccion = 0
                        },
                        new
                        {
                            Id = 2,
                            EstaBorrado = false,
                            EstudianteId = 1,
                            FechaActualizacion = new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2837),
                            FechaCreacion = new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2841),
                            StringDireccion = "F88X+2R MADRID, ESPAÑA",
                            TipoDireccion = 1
                        },
                        new
                        {
                            Id = 3,
                            EstaBorrado = false,
                            EstudianteId = 2,
                            FechaActualizacion = new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2843),
                            FechaCreacion = new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2844),
                            StringDireccion = "F972+V7 MADRID, ESPAÑA",
                            TipoDireccion = 0
                        },
                        new
                        {
                            Id = 4,
                            EstaBorrado = false,
                            EstudianteId = 3,
                            FechaActualizacion = new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2846),
                            FechaCreacion = new DateTime(2021, 3, 6, 5, 8, 48, 46, DateTimeKind.Local).AddTicks(2847),
                            StringDireccion = "F8WQ+VG MADRID, ESPAÑA",
                            TipoDireccion = 2
                        });
                });

            modelBuilder.Entity("PrimeStone.Core.Models.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasComment("Student Identifier")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Apellidos")
                        .HasComment("Last names");

                    b.Property<bool>("EstaBorrado")
                        .HasMaxLength(1)
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("EstaBorrado")
                        .HasComment("is deleted state  0:Active  1:deleted");

                    b.Property<DateTime>("FechaActualizacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("FechaActualizacion")
                        .HasDefaultValueSql("getdate()")
                        .HasComment("Update date");

                    b.Property<DateTime?>("FechaBorrado")
                        .HasColumnType("datetime")
                        .HasColumnName("FechaBorrado")
                        .HasComment("Deletion Date");

                    b.Property<DateTime>("FechaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("FechaCreacion")
                        .HasDefaultValueSql("getdate()")
                        .HasComment("Creation date");

                    b.Property<DateTime>("FechaNacimento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("FechaNacimento")
                        .HasDefaultValueSql("getdate()")
                        .HasComment("Date of Birth");

                    b.Property<int>("Genero")
                        .HasMaxLength(1)
                        .HasColumnType("int")
                        .HasColumnName("Genero");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombres")
                        .HasComment("Names");

                    b.HasKey("Id");

                    b.ToTable("Estudiante");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellidos = "RAMOS",
                            EstaBorrado = false,
                            FechaActualizacion = new DateTime(2021, 3, 6, 5, 8, 48, 43, DateTimeKind.Local).AddTicks(9997),
                            FechaCreacion = new DateTime(2021, 3, 6, 5, 8, 48, 44, DateTimeKind.Local).AddTicks(8642),
                            FechaNacimento = new DateTime(2000, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = 1,
                            Nombres = "SERGIO"
                        },
                        new
                        {
                            Id = 2,
                            Apellidos = "DIAZ ARANGO",
                            EstaBorrado = false,
                            FechaActualizacion = new DateTime(2021, 3, 6, 5, 8, 48, 45, DateTimeKind.Local).AddTicks(778),
                            FechaCreacion = new DateTime(2021, 3, 6, 5, 8, 48, 45, DateTimeKind.Local).AddTicks(783),
                            FechaNacimento = new DateTime(2000, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = 1,
                            Nombres = "MARTÍN ALEJANDRO"
                        },
                        new
                        {
                            Id = 3,
                            Apellidos = "PEREZ LINARES",
                            EstaBorrado = false,
                            FechaActualizacion = new DateTime(2021, 3, 6, 5, 8, 48, 45, DateTimeKind.Local).AddTicks(786),
                            FechaCreacion = new DateTime(2021, 3, 6, 5, 8, 48, 45, DateTimeKind.Local).AddTicks(787),
                            FechaNacimento = new DateTime(2000, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = 0,
                            Nombres = "ANDREA VALERIA"
                        });
                });

            modelBuilder.Entity("PrimeStone.Core.Models.EstudianteCurso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasComment("Student Identifier")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CursoId")
                        .HasColumnType("int")
                        .HasColumnName("CursoId")
                        .HasComment("Course Identifier Foreign Key");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int")
                        .HasColumnName("EstudianteId")
                        .HasComment("Student Identifier Foreign Key");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("EstudianteId");

                    b.ToTable("EstudianteCurso");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CursoId = 1,
                            EstudianteId = 1
                        },
                        new
                        {
                            Id = 2,
                            CursoId = 1,
                            EstudianteId = 2
                        },
                        new
                        {
                            Id = 3,
                            CursoId = 2,
                            EstudianteId = 1
                        },
                        new
                        {
                            Id = 4,
                            CursoId = 2,
                            EstudianteId = 2
                        },
                        new
                        {
                            Id = 5,
                            CursoId = 2,
                            EstudianteId = 3
                        },
                        new
                        {
                            Id = 6,
                            CursoId = 3,
                            EstudianteId = 1
                        },
                        new
                        {
                            Id = 7,
                            CursoId = 3,
                            EstudianteId = 2
                        });
                });

            modelBuilder.Entity("PrimeStone.Core.Models.Security", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdSeguridad")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EstaBorrado")
                        .HasMaxLength(1)
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("EstaBorrado")
                        .HasComment("is deleted state  0:Active  1:deleted");

                    b.Property<DateTime>("FechaActualizacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("FechaActualizacion")
                        .HasDefaultValueSql("getdate()")
                        .HasComment("Update date");

                    b.Property<DateTime?>("FechaBorrado")
                        .HasColumnType("datetime")
                        .HasColumnName("FechaBorrado")
                        .HasComment("Deletion Date");

                    b.Property<DateTime>("FechaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("FechaCreacion")
                        .HasDefaultValueSql("getdate()")
                        .HasComment("Creation date");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Contrasena");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Rol");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Usuario");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("NombreUsuario");

                    b.HasKey("Id");

                    b.ToTable("Seguridad");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EstaBorrado = false,
                            FechaActualizacion = new DateTime(2021, 3, 6, 5, 8, 48, 47, DateTimeKind.Local).AddTicks(215),
                            FechaCreacion = new DateTime(2021, 3, 6, 5, 8, 48, 47, DateTimeKind.Local).AddTicks(220),
                            Password = "123",
                            Role = "Administrator",
                            User = "Erwing Candelario",
                            UserName = "Erwing"
                        });
                });

            modelBuilder.Entity("PrimeStone.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdUsuario")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("FechaNacimiento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<bool>("EstaBorrado")
                        .HasMaxLength(1)
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("EstaBorrado")
                        .HasComment("is deleted state  0:Active  1:deleted");

                    b.Property<DateTime>("FechaActualizacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("FechaActualizacion")
                        .HasDefaultValueSql("getdate()")
                        .HasComment("Update date");

                    b.Property<DateTime?>("FechaBorrado")
                        .HasColumnType("datetime")
                        .HasColumnName("FechaBorrado")
                        .HasComment("Deletion Date");

                    b.Property<DateTime>("FechaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("FechaCreacion")
                        .HasDefaultValueSql("getdate()")
                        .HasComment("Creation date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nombres");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("Activo");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Apellidos");

                    b.Property<string>("Telephone")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("Telefono");

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1979, 10, 2, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ingeniero_79@Hotmail.com",
                            EstaBorrado = false,
                            FechaActualizacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Erwing",
                            IsActive = true,
                            LastName = "Candelario",
                            Telephone = "3013893448"
                        });
                });

            modelBuilder.Entity("PrimeStone.Core.Models.Direccion", b =>
                {
                    b.HasOne("PrimeStone.Core.Models.Estudiante", "Estudiante")
                        .WithMany("Direcciones")
                        .HasForeignKey("EstudianteId")
                        .HasConstraintName("Fk_Direction_Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estudiante");
                });

            modelBuilder.Entity("PrimeStone.Core.Models.EstudianteCurso", b =>
                {
                    b.HasOne("PrimeStone.Core.Models.Curso", "Curso")
                        .WithMany("EstudiantesCursos")
                        .HasForeignKey("CursoId")
                        .HasConstraintName("Fk_StudentCourse_Course")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrimeStone.Core.Models.Estudiante", "Estudiante")
                        .WithMany("EstudiantesCursos")
                        .HasForeignKey("EstudianteId")
                        .HasConstraintName("Fk_StudentCourse_Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Estudiante");
                });

            modelBuilder.Entity("PrimeStone.Core.Models.Curso", b =>
                {
                    b.Navigation("EstudiantesCursos");
                });

            modelBuilder.Entity("PrimeStone.Core.Models.Estudiante", b =>
                {
                    b.Navigation("Direcciones");

                    b.Navigation("EstudiantesCursos");
                });
#pragma warning restore 612, 618
        }
    }
}
