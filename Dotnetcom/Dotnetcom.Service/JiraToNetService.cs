namespace Dotnetcom.Service
{
    public class JiraToNetService : IJiraToNetRepository
    {
        private IJiraToNetRepository _repository { get; set; }

        public JiraToNetService(IJiraToNetRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<JiraToNetModel>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<JiraToNetModel> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task CreateAsync(JiraToNetModel model)
        {
            await _repository.CreateAsync(model);
        }

        public async Task UpdateAsync(JiraToNetModel model)
        {
            await _repository.UpdateAsync(model);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}