namespace Dotnetcom.Repository
{
    public class JiraToNetRepository : IJiraToNetRepository
    {
        private readonly DotnetcomContext _context;

        public JiraToNetRepository(DotnetcomContext context)
        {
            _context = context;
        }

        // Create
        public async Task<JiraToNetModel> CreateAsync(JiraToNetModel model)
        {
            var entity = new JiraToNetModel
            {
                ProjectName = model.ProjectName,
                TicketNumber = model.TicketNumber,
                Description = model.Description,
                Priority = model.Priority,
                Status = model.Status
            };

            await _context.JiraToNet.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        // Read
        public async Task<JiraToNetModel> ReadAsync(int id)
        {
            return await _context.JiraToNet.FindAsync(id);
        }

        // Update
        public async Task<JiraToNetModel> UpdateAsync(JiraToNetModel model)
        {
            var entity = await _context.JiraToNet.FindAsync(model.Id);

            entity.ProjectName = model.ProjectName;
            entity.TicketNumber = model.TicketNumber;
            entity.Description = model.Description;
            entity.Priority = model.Priority;
            entity.Status = model.Status;

            _context.JiraToNet.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        // Delete
        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.JiraToNet.FindAsync(id);

            _context.JiraToNet.Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}