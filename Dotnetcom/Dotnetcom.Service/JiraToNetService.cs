namespace Dotnetcom.Service
{
    using Dotnetcom.DataAccess;
    using Dotnetcom.DTO;

    public class JiraToNetService : IJiraToNetService
    {
        private IJiraToNetRepository _jiraToNetRepository;

        public JiraToNetService(IJiraToNetRepository jiraToNetRepository)
        {
            _jiraToNetRepository = jiraToNetRepository;
        }

        public async Task<JiraToNetModel> GetJiraToNetModelAsync(int id)
        {
            return await _jiraToNetRepository.GetJiraToNetModelAsync(id);
        }

        public async Task<JiraToNetModel> CreateJiraToNetModelAsync(JiraToNetDTO dto)
        {
            JiraToNetModel model = new JiraToNetModel
            {
                // Map the DTO to the Model
            };

            return await _jiraToNetRepository.CreateJiraToNetModelAsync(model);
        }

        public async Task<JiraToNetModel> UpdateJiraToNetModelAsync(JiraToNetDTO dto)
        {
            JiraToNetModel model = await _jiraToNetRepository.GetJiraToNetModelAsync(dto.Id);

            // Map the DTO to the Model

            return await _jiraToNetRepository.UpdateJiraToNetModelAsync(model);
        }

        public async Task DeleteJiraToNetModelAsync(int id)
        {
            await _jiraToNetRepository.DeleteJiraToNetModelAsync(id);
        }
    }
}