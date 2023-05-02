// Generated C# Business Logic Code

using Dotnetcom.DTO;
using System.Threading.Tasks;

namespace Dotnetcom.Service
{
    public interface IJiraToNetService
    {
        Task<JiraToNetModel> CreateAsync(JiraToNetModel model);
        Task<JiraToNetModel> ReadAsync(int id);
        Task<JiraToNetModel> UpdateAsync(JiraToNetModel model);
        Task<bool> DeleteAsync(int id);
    }
}