using Dotnetcom.DTO;

namespace Dotnetcom.Service
{
    public interface IJiraToNetRepository
    {
        Task<List<JiraToNetModel>> GetAllAsync();
        Task<JiraToNetModel> GetByIdAsync(int id);
        Task CreateAsync(JiraToNetModel model);
        Task UpdateAsync(JiraToNetModel model);
        Task DeleteAsync(int id);
    }
}