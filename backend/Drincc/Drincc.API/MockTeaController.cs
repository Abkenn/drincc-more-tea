using Drincc.API.Contracts;
using Drincc.DAL.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Drincc.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class MockTeaController : ControllerBase
    {
        private List<TeaDto> teas = new List<TeaDto>();

        public MockTeaController(ITeaService service)
        {
            teas = new List<TeaDto>
            {
                new TeaDto
                    {
                        Id = 0,
                        Name = "Tea 1"
                    },
                new TeaDto
                    {
                        Id = 1,
                        Name = "Tea 2"
                    },
                new TeaDto
                    {
                        Id = 2,
                        Name = "Tea 3"
                    }
            };
        }

        [HttpGet]
        public ActionResult<TeaDto[]> Get()
            => Ok(teas);

        [HttpGet("{id}")]
        public ActionResult<List<TeaDto>> Get(int id)
        {
            var tea = teas.FirstOrDefault(tea => tea.Id == id);

            if (tea == null)
            {
                return BadRequest("Tea not found.");
            }

            return Ok(tea);
        }

        [HttpPost]
        public ActionResult<TeaDto> AddTea(TeaDto tea)
        {
            teas.Add(tea);
            return Ok(tea);
        }

        [HttpPut("{id}")]
        public ActionResult<TeaDto> UpdateTea(int id, TeaDto teaRequest)
        {
            var tea = teas.FirstOrDefault(tea => tea.Id == id);

            if (tea == null)
            {
                return BadRequest("Tea not found.");
            }

            tea.Name = teaRequest.Name;

            return tea;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var tea = teas.FirstOrDefault(tea => tea.Id == id);

            if (tea == null)
            {
                return BadRequest("Tea not found.");
            }

            teas.Remove(tea);

            return NoContent();
        }
    }
}
