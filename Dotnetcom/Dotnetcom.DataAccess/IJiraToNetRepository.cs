using Dotnetcom.DTO;
using Dotnetcom.Repository;

namespace Dotnetcom.Service
{
    public interface IJiraToNetRepository
    {
        Task<JiraToNetModel> CreateAsync(JiraToNetModel model);
        Task<JiraToNetModel> ReadAsync(int id);
        Task<JiraToNetModel> UpdateAsync(JiraToNetModel model);
        Task<bool> DeleteAsync(int id);
    }
}