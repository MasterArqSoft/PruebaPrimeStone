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
    public class DireccionController : ControllerBase
    {
        private readonly IDireccionService _direccionService;
        private readonly IMapper _mapper;
        public DireccionController(
            IDireccionService direccionService,
            IMapper mapper
        )
        {
            _direccionService = direccionService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
            var direccion = await _direccionService.GetDireccion(id).ConfigureAwait(false);
            var direccionDto = _mapper.Map<DireccionDto>(direccion);
            var response = new ApiResponse<DireccionDto>(direccionDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(DireccionDto DireccionDto)
        {
            var direccion = _mapper.Map<Direccion>(DireccionDto);

            await _direccionService.InsertDireccion(direccion).ConfigureAwait(false);

            DireccionDto = _mapper.Map<DireccionDto>(direccion);
            var response = new ApiResponse<DireccionDto>(DireccionDto);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, DireccionDto DireccionDto)
        {
            var direccion = _mapper.Map<Direccion>(DireccionDto);
            direccion.Id = id;

            var result = await _direccionService.UpdateDireccion(direccion).ConfigureAwait(false);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _direccionService.DeleteDireccion(id).ConfigureAwait(false);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
