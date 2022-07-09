using Catalog.Model;

namespace Catalog.Repository
{
    public interface IItemRepository
    {
        Task<IEnumerable<item>> GetItems();
        Task<item> GetItem(Guid Id);
        Task<item> Add(item item);

    }
}