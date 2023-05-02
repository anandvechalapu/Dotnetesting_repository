using Dotnetcom.API;
using Dotnetcom.DTO;
using Dotnetcom.Service;
using Microsoft.AspNetCore.Mvc;

namespace Dotnetcom.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class JiraToNetController : ControllerBase
    {
        private readonly JiraToNetService _jiraToNetService;

        public JiraToNetController(JiraToNetService jiraToNetService)
        {
            _jiraToNetService = jiraToNetService;
        }

        // GET: api/JiraToNet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JiraToNetModel>>> GetAllJiraToNetAsync()
        {
            var result = await _jiraToNetService.GetAllAsync();
            return Ok(result);
        }

        // GET: api/JiraToNet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JiraToNetModel>> GetJiraToNetAsync(int id)
        {
            var result = await _jiraToNetService.GetByIdAsync(id);
            return Ok(result);
        }

        // POST: api/JiraToNet
        [HttpPost]
        public async Task<ActionResult<JiraToNetModel>> CreateJiraToNetAsync(JiraToNetModel model)
        {
            await _jiraToNetService.CreateAsync(model);
            return Ok();
        }

        // PUT: api/JiraToNet/5
        [HttpPut("{id}")]
        public async Task<ActionResult<JiraToNetModel>> UpdateJiraToNetAsync(int id, JiraToNetModel model)
        {
            await _jiraToNetService.UpdateAsync(model);
            return Ok();
        }

        // DELETE: api/JiraToNet/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<JiraToNetModel>> DeleteJiraToNetAsync(int id)
        {
            await _jiraToNetService.DeleteAsync(id);
            return Ok();
        }
    }
}