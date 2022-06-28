using Drincc.DAL.Data;
using Drincc.DAL.DTOs;
using Drincc.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Drincc.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeaController : ControllerBase
    {
        private static List<Tea> TeaList = new List<Tea>
        {
            new Tea{Id = 1, Name = "Test Tea 1"},
            new Tea{Id = 2, Name = "Test Tea 2"}
        };

        public TeaController(DataContext dataContext)
        {

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tea>>> Get()
            => Ok(new BaseDto(TeaList));

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Tea>>> Get(int id)
        {
            var tea = TeaList.Find(tea => tea.Id == id);

            if (tea == null)
            {
                return BadRequest("Tea not found.");
            }

            return Ok(new BaseDto(tea));
        }

        [HttpPost]
        public async Task<ActionResult<Tea>> AddTea(TeaDto request)
        {
            var newTea = new Tea { Id = TeaList.Count + 1, Name = request.Name };
            TeaList.Add(newTea);
            return Ok(new BaseDto(newTea));
        }

        [HttpPut]
        public async Task<ActionResult<Tea>> UpdateTea(Tea request)
        {
            var tea = TeaList.Find(tea => tea.Id == request.Id);

            if (tea == null)
            {
                return BadRequest("Tea not found.");
            }

            tea.Name = request.Name;

            return Ok(new BaseDto(tea));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Tea>>> Delete(int id)
        {
            var tea = TeaList.Find(tea => tea.Id == id);

            if (tea == null)
            {
                return BadRequest("Tea not found.");
            }

            TeaList.Remove(tea);

            return NoContent();
        }
    }
}
