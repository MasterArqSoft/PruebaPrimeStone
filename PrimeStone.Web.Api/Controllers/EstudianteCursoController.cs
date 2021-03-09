using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimeStone.Core.Dtos;
using PrimeStone.Core.Interfaces;
using PrimeStone.Core.Models;
using PrimeStone.Web.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeStone.Web.Api.Controllers
{
    // [Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteCursoController : ControllerBase
    {
        private readonly IEstudianteCursoService _estudianteCursoService;
        private readonly IMapper _mapper;
        public EstudianteCursoController(
            IEstudianteCursoService estudianteCursoService,
            IMapper mapper
            )
        {
            _estudianteCursoService = estudianteCursoService;
            _mapper = mapper;
        }
        [HttpGet()]
        public async Task<IActionResult> GetByIdCurso(int idCurso, int idEstudiante)
        {
            var materia = idCurso != 0 ? await _estudianteCursoService.GetByIdCurso(idCurso).ConfigureAwait(false)
                                       : await _estudianteCursoService.GetByIdEstudiante(idEstudiante).ConfigureAwait(false);
            var estudianteCursoDto = _mapper.Map<IEnumerable<EstudianteCursoDto>>(materia);
            var response = new ApiResponse<IEnumerable<EstudianteCursoDto>>(estudianteCursoDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EstudianteCursoDto estudianteCursoDto)
        {
            var materia = _mapper.Map<EstudianteCurso>(estudianteCursoDto);

            await _estudianteCursoService.InsertEstudianteCurso(materia).ConfigureAwait(false);

            estudianteCursoDto = _mapper.Map<EstudianteCursoDto>(materia);
            var response = new ApiResponse<EstudianteCursoDto>(estudianteCursoDto);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(EstudianteCursoDto estudianteCursoDto)
        {
            var materia = _mapper.Map<EstudianteCurso>(estudianteCursoDto);
           
            var result = await _estudianteCursoService.UpdateEstudianteCurso(materia).ConfigureAwait(false);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int idEstudiante, int idCurso)
        {
            var result = await _estudianteCursoService.DeletetByEstudianteCurso(idEstudiante, idCurso).ConfigureAwait(false);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
