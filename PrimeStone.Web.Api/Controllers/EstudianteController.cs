using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PrimeStone.Core.Dtos;
using PrimeStone.Core.Interfaces;
using PrimeStone.Core.Models;
using PrimeStone.Web.Api.Responses;
using System.Threading.Tasks;

namespace PrimeStone.Web.Api.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteService _estudianteService;
        private readonly IMapper _mapper;
        public EstudianteController(
            IEstudianteService estudianteService,
            IMapper mapper
        )
        {
            _estudianteService = estudianteService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Getestudiante(int id)
        {
            var estudiante = await _estudianteService.GetEstudiante(id).ConfigureAwait(false);
            var estudianteDto = _mapper.Map<EstudianteDto>(estudiante);
            var response = new ApiResponse<EstudianteDto>(estudianteDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EstudianteDto estudianteDto)
        {
            var estudiante = _mapper.Map<Estudiante>(estudianteDto);

            await _estudianteService.InsertEstudiante(estudiante).ConfigureAwait(false);

            estudianteDto = _mapper.Map<EstudianteDto>(estudiante);
            var response = new ApiResponse<EstudianteDto>(estudianteDto);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, EstudianteDto estudianteDto)
        {
            var estudiante = _mapper.Map<Estudiante>(estudianteDto);
            estudiante.Id = id;

            var result = await _estudianteService.UpdateEstudiante(estudiante).ConfigureAwait(false);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _estudianteService.DeleteEstudiante(id).ConfigureAwait(false);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
