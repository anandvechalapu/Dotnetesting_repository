// Generated C# Respi API Controller
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dotnetcom.DTO;
using Dotnetcom.Service;

namespace Dotnetcom.API
{
    [Route("api/[controller]")]
    public class JiraToNetController : Controller
    {
        private readonly JiraToNetService _service;

        public JiraToNetController(JiraToNetService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<JiraToNetModel>> CreateAsync([FromBody]JiraToNetModel model)
        {
            var item = await _service.CreateAsync(model);

            return Ok(item);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<JiraToNetModel>> ReadAsync(int id)
        {
            var item = await _service.ReadAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPut]
        public async Task<ActionResult<JiraToNetModel>> UpdateAsync([FromBody]JiraToNetModel model)
        {
            var item = await _service.UpdateAsync(model);

            return Ok(item);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<JiraToNetModel>> DeleteAsync(int id)
        {
            var result = await _service.DeleteAsync(id);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}