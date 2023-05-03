using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dotnetcom.API.DTO;
using Dotnetcom.API.Service;

namespace Dotnetcom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesforceAdminSurveyController : ControllerBase
    {
        private readonly SalesforceAdminSurveyService _salesforceAdminSurveyService;

        public SalesforceAdminSurveyController(SalesforceAdminSurveyService salesforceAdminSurveyService)
        {
            _salesforceAdminSurveyService = salesforceAdminSurveyService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesforceAdminSurveyDTO>>> GetAllAsync()
        {
            var surveys = await _salesforceAdminSurveyService.GetAllAsync();
            return Ok(surveys);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SalesforceAdminSurveyDTO>> GetAsync(int id)
        {
            var survey = await _salesforceAdminSurveyService.GetAsync(id);
            if (survey == null)
            {
                return NotFound();
            }
            return Ok(survey);
        }

        [HttpPost]
        public async Task<ActionResult<SalesforceAdminSurveyDTO>> AddAsync(SalesforceAdminSurveyDTO surveyDTO)
        {
            await _salesforceAdminSurveyService.AddAsync(surveyDTO);
            return CreatedAtAction(nameof(GetAsync), new { id = surveyDTO.Id }, surveyDTO);
        }

        [HttpPut]
        public async Task<ActionResult<SalesforceAdminSurveyDTO>> UpdateAsync(SalesforceAdminSurveyDTO surveyDTO)
        {
            await _salesforceAdminSurveyService.UpdateAsync(surveyDTO);
            return Ok(surveyDTO);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _salesforceAdminSurveyService.DeleteAsync(id);
            return NoContent();
        }
    }
}