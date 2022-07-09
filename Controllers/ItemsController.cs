using Catalog.Model;
using Catalog.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        private readonly IItemRepository _Repository;
        public ItemsController(IItemRepository Repository)
        {
            _Repository = Repository;
        }
        [HttpGet]
        public async Task<ActionResult<item>> Get()
        {
            return Ok(await _Repository.GetItems());
        }    
    }
}