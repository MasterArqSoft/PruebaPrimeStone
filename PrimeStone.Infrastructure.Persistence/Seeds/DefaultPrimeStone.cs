﻿using Microsoft.EntityFrameworkCore;
using PrimeStone.Core.Enumerations;
using PrimeStone.Core.Models;
using System;

namespace PrimeStone.Infrastructure.Persistence.Seeds
{
    public static class DefaultPrimeStone
    {
        public static void SeedPrimeStone(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>().HasData(
                new Estudiante()
                {
                    Apellidos = "Ramos",
                    EstaBorrado = false,
                    FechaActualizacion = DateTime.Now,
                    FechaCreacion = DateTime.Now,
                    FechaNacimento = new DateTime(2000, 1, 1, 7, 0, 0),
                    Genero = Genero.Masculino,
                    Id = 1,
                    Nombres = "Sergio",
                },
                new Estudiante()
                {
                    Apellidos = "Diaz Arango",
                    EstaBorrado = false,
                    FechaActualizacion = DateTime.Now,
                    FechaCreacion = DateTime.Now,
                    FechaNacimento = new DateTime(2000, 1, 1, 7, 0, 0),
                    Genero = Genero.Masculino,
                    Id = 2,
                    Nombres = "Martín Alejandro",
                },
                new Estudiante()
                {
                    Apellidos = "Perez Linares",
                    EstaBorrado = false,
                    FechaActualizacion = DateTime.Now,
                    FechaCreacion = DateTime.Now,
                    FechaNacimento = new DateTime(2000, 1, 1, 7, 0, 0),
                    Genero = Genero.Femenino,
                    Id = 3,
                    Nombres = "Andrea Valeria",
                }
            );

            modelBuilder.Entity<Direccion>().HasData(
                new Direccion()
                {
                    EstaBorrado = false,
                    EstudianteId = 1,
                    FechaActualizacion = DateTime.Now,
                    FechaCreacion = DateTime.Now,
                    Id = 1,
                    StringDireccion = "C7CW+84 Madrid, España",
                    TipoDireccion = TipoDireccion.Domicilio
                },
                new Direccion()
                {
                    EstaBorrado = false,
                    EstudianteId = 1,
                    FechaActualizacion = DateTime.Now,
                    FechaCreacion = DateTime.Now,
                    Id = 2,
                    StringDireccion = "F88X+2R Madrid, España",
                    TipoDireccion = TipoDireccion.Laboral
                },
                new Direccion()
                {
                    EstaBorrado = false,
                    EstudianteId = 2,
                    FechaActualizacion = DateTime.Now,
                    FechaCreacion = DateTime.Now,
                    Id = 3,
                    StringDireccion = "F972+V7 Madrid, España",
                    TipoDireccion = TipoDireccion.Domicilio
                },
                new Direccion()
                {
                    EstaBorrado = false,
                    EstudianteId = 3,
                    FechaActualizacion = DateTime.Now,
                    FechaCreacion = DateTime.Now,
                    Id = 4,
                    StringDireccion = "F8WQ+VG Madrid, España",
                    TipoDireccion = TipoDireccion.Temporal
                });

            modelBuilder.Entity<Curso>().HasData(
                new Curso()
                {
                    CodigoCurso = "Mate-01",
                    EstaBorrado = false,
                    FechaActualizacion = DateTime.Now,
                    FechaCreacion = DateTime.Now,
                    Id = 1,
                    NombreCurso = "Matemáticas",
                },
                new Curso()
                {
                    CodigoCurso = "MeCa-02",
                    EstaBorrado = false,
                    FechaActualizacion = DateTime.Now,
                    FechaCreacion = DateTime.Now,
                    Id = 2,
                    NombreCurso = "Mecánica cuántica",
                },
                new Curso()
                {
                    CodigoCurso = "TeCu-03",
                    EstaBorrado = false,
                    FechaActualizacion = DateTime.Now,
                    FechaCreacion = DateTime.Now,
                    Id = 3,
                    NombreCurso = "Teoría cuántica de campos",
                });

            modelBuilder.Entity<EstudianteCurso>().HasData(
                new EstudianteCurso()
                {
                    Id = 1,
                    CursoId = 1,
                    EstudianteId = 1,
                },
                new EstudianteCurso()
                {
                    Id = 2,
                    CursoId = 1,
                    EstudianteId = 2,
                },
                new EstudianteCurso()
                {
                    Id = 3,
                    CursoId = 2,
                    EstudianteId = 1,
                },
                new EstudianteCurso()
                {
                    Id = 4,
                    CursoId = 2,
                    EstudianteId = 2,
                },
                new EstudianteCurso()
                {
                    Id = 5,
                    CursoId = 2,
                    EstudianteId = 3,
                },
                new EstudianteCurso()
                {
                    Id = 6,
                    CursoId = 3,
                    EstudianteId = 1,
                },
                new EstudianteCurso()
                {
                    Id = 7,
                    CursoId = 3,
                    EstudianteId = 2,
                });
        }
    }
}
