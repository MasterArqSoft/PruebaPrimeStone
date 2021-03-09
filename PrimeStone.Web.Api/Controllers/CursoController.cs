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
    public class CursoController : ControllerBase
    {
        private readonly ICursoService _cursoService;
        private readonly IMapper _mapper;
        public CursoController(
            ICursoService cursoService,
            IMapper mapper
        )
        {
            _cursoService = cursoService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCurso(int id)
        {
            var post = await _cursoService.GetCurso(id).ConfigureAwait(false);
            var postDto = _mapper.Map<CursoDto>(post);
            var response = new ApiResponse<CursoDto>(postDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CursoDto postDto)
        {
            var curso = _mapper.Map<Curso>(postDto);

            await _cursoService.InsertCurso(curso).ConfigureAwait(false);

            postDto = _mapper.Map<CursoDto>(curso);
            var response = new ApiResponse<CursoDto>(postDto);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, CursoDto cursoDto)
        {
            var curso = _mapper.Map<Curso>(cursoDto);
            curso.Id = id;

            var result = await _cursoService.UpdateCurso(curso).ConfigureAwait(false);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _cursoService.DeleteCurso(id).ConfigureAwait(false);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
