namespace Dotnetcom.Service
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Dotnetcom.DataAccess;
    using Dotnetcom.DTO;

    public class SalesforceAdminSurveyService : ISalesforceAdminSurveyService
    {
        private readonly ISalesforceAdminSurveyRepository _salesforceAdminSurveyRepository;

        public SalesforceAdminSurveyService(ISalesforceAdminSurveyRepository salesforceAdminSurveyRepository)
        {
            _salesforceAdminSurveyRepository = salesforceAdminSurveyRepository;
        }

        public async Task<IEnumerable<SalesforceAdminSurveyDTO>> GetAllAsync()
        {
            var surveys = await _salesforceAdminSurveyRepository.GetAllAsync();
            return MapToDTO(surveys);
        }

        public async Task<SalesforceAdminSurveyDTO> GetAsync(int id)
        {
            var survey = await _salesforceAdminSurveyRepository.GetAsync(id);
            return MapToDTO(survey);
        }

        public async Task AddAsync(SalesforceAdminSurveyDTO surveyDTO)
        {
            var survey = MapFromDTO(surveyDTO);
            await _salesforceAdminSurveyRepository.AddAsync(survey);
        }

        public async Task UpdateAsync(SalesforceAdminSurveyDTO surveyDTO)
        {
            var survey = MapFromDTO(surveyDTO);
            await _salesforceAdminSurveyRepository.UpdateAsync(survey);
        }

        public async Task DeleteAsync(int id)
        {
            await _salesforceAdminSurveyRepository.DeleteAsync(id);
        }

        private IEnumerable<SalesforceAdminSurveyDTO> MapToDTO(IEnumerable<SalesforceAdminSurveyModel> surveys)
        {
            // implementation
        }

        private SalesforceAdminSurveyDTO MapToDTO(SalesforceAdminSurveyModel survey)
        {
            // implementation
        }

        private SalesforceAdminSurveyModel MapFromDTO(SalesforceAdminSurveyDTO surveyDTO)
        {
            // implementation
        }
    }
}