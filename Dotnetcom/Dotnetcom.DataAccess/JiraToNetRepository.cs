namespace Dotnetcom
{
    public class JiraToNetRepository : IJiraToNetRepository 
    {
        private DotnetcomDTO _context;

        public JiraToNetRepository()
        {
            _context = new DotnetcomDTO();
        }

        public async Task<List<JiraToNetModel>> GetAllAsync()
        {
            return await _context.JiraToNet.ToListAsync();
        }

        public async Task<JiraToNetModel> GetByIdAsync(int id)
        {
            return await _context.JiraToNet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task CreateAsync(JiraToNetModel model)
        {
            _context.JiraToNet.Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(JiraToNetModel model)
        {
            _context.JiraToNet.Update(model);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var model = await _context.JiraToNet.FirstOrDefaultAsync(x => x.Id == id);
            _context.JiraToNet.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}