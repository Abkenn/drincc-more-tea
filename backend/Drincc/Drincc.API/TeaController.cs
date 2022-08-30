using Drincc.API.Contracts;
using Drincc.DAL.DTOs;
using Drincc.DAL.Models;
using Drincc.EF.Services;
using Microsoft.AspNetCore.Mvc;

namespace Drincc.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeaController : ControllerBase
    {
        private readonly TeaService service;

        public TeaController(ITeaService service)
        {
            this.service = (TeaService)service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tea>>> Get()
            => Ok(new BaseDto<IEnumerable<Tea>>(await service.GetAllTeasAsync()));

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Tea>>> Get(int id)
        {
            var tea = await service.GetTeaByIdAsync(id);

            if (tea == null)
            {
                return BadRequest("Tea not found.");
            }

            return Ok(new BaseDto<Tea>(tea));
        }

        [HttpPost]
        public async Task<ActionResult<Tea>> AddTea(Tea tea)
            => Ok(new BaseDto<Tea>(await service.AddTeaAsync(tea)));

        [HttpPut("{id}")]
        public async Task<ActionResult<Tea>> UpdateTea(int id, Tea teaRequest)
        {
            var tea = await service.UpdateTeaAsync(id, teaRequest);

            if (tea == null)
            {
                return BadRequest("Tea not found.");
            }

            return Ok(new BaseDto<Tea>(tea));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var tea = await service.RemoveTeaAsync(id);

            if (tea == null)
            {
                return BadRequest("Tea not found.");
            }

            return NoContent();
        }
    }
}
