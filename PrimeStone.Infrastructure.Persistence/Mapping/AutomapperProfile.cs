using AutoMapper;
using PrimeStone.Core.Dtos;
using PrimeStone.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeStone.Infrastructure.Persistence.Mapping
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Curso, CursoDto>();
            CreateMap<CursoDto, Curso>();

            CreateMap<Direccion, DireccionDto>();
            CreateMap<DireccionDto, Direccion>();

            CreateMap<Estudiante, EstudianteDto>();
            CreateMap<EstudianteDto, Estudiante>();

            CreateMap<EstudianteCurso, EstudianteCursoDto>();
            CreateMap<EstudianteCursoDto, EstudianteCurso>();

            CreateMap<Security, SecurityDto>().ReverseMap();
        }
    }
}
