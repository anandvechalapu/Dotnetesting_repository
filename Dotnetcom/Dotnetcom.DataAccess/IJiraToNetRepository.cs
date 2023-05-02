using Dotnetcom.DTO;
namespace Dotnetcom.Service
{
    public interface IJiraToNetRepository
    {
        Task<JiraToNetModel> GetJiraToNetModelAsync(int id);
        Task<JiraToNetModel> CreateJiraToNetModelAsync(JiraToNetModel model);
        Task<JiraToNetModel> UpdateJiraToNetModelAsync(JiraToNetModel model);
        Task DeleteJiraToNetModelAsync(int id);
    }
}