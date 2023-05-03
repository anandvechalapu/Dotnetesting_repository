using Dotnetcom.DTO;
namespace Dotnetcom.Service
{
    public interface ISalesforceAdminSurveyService
    {
        Task<IEnumerable<SalesforceAdminSurveyDTO>> GetAllAsync();
        Task<SalesforceAdminSurveyDTO> GetAsync(int id);
        Task AddAsync(SalesforceAdminSurveyDTO surveyDTO);
        Task UpdateAsync(SalesforceAdminSurveyDTO surveyDTO);
        Task DeleteAsync(int id);
    }
}