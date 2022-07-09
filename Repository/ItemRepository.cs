using Catalog.Data;
using Catalog.Model;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationDbContext _context;
        public ItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<item> Add(item item)
        {
            throw new NotImplementedException();
        }

        public Task<item> GetItem(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<item>> GetItems()
        {
            return await _context.Items.ToListAsync();
        }
    }
}