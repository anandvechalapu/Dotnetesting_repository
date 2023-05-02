using Dotnetcom.DTO;

namespace Dotnetcom.Service
{
    public interface IJiraToNetService
    {
        Task<JiraToNetModel> GetJiraToNetModelAsync(int id);
        Task<JiraToNetModel> CreateJiraToNetModelAsync(JiraToNetDTO dto);
        Task<JiraToNetModel> UpdateJiraToNetModelAsync(JiraToNetDTO dto);
        Task DeleteJiraToNetModelAsync(int id);
    }
}