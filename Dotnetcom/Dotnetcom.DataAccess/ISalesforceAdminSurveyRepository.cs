using Dotnetcom.DTO;
namespace Dotnetcom.Service
{
    public interface ISalesforceAdminSurveyRepository
    {
        Task<IEnumerable<SalesforceAdminSurveyModel>> GetAllAsync();
        Task<SalesforceAdminSurveyModel> GetAsync(int id);
        Task AddAsync(SalesforceAdminSurveyModel survey);
        Task UpdateAsync(SalesforceAdminSurveyModel survey);
        Task DeleteAsync(int id);
    }
}