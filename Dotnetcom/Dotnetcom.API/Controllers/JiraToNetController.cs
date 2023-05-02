using Microsoft.AspNetCore.Mvc;
using Dotnetcom.DTO;
using Dotnetcom.Service;

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

        [HttpGet]
        public async Task<ActionResult<JiraToNetModel>> GetJiraToNetModelAsync(int id)
        {
            JiraToNetModel model = await _jiraToNetService.GetJiraToNetModelAsync(id);

            if(model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpPost]
        public async Task<ActionResult<JiraToNetModel>> CreateJiraToNetModelAsync(JiraToNetDTO dto)
        {
            JiraToNetModel model = await _jiraToNetService.CreateJiraToNetModelAsync(dto);

            return CreatedAtAction(nameof(GetJiraToNetModelAsync), new { id = model.Id }, model);
        }

        [HttpPut]
        public async Task<ActionResult<JiraToNetModel>> UpdateJiraToNetModelAsync(JiraToNetDTO dto)
        {
            JiraToNetModel model = await _jiraToNetService.UpdateJiraToNetModelAsync(dto);

            return model;
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteJiraToNetModelAsync(int id)
        {
            await _jiraToNetService.DeleteJiraToNetModelAsync(id);

            return NoContent();
        }
    }
}