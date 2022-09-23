using CATALOG.Entities;
using CATALOG.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CATALOG.Controllers 
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository repository;


        public ItemsController(IItemsRepository repository) 
        {
            this.repository = repository; 
        } 
        
        // GET /items 
        [HttpGet]
        public IEnumerable<Item> GetItems() 
        {
            var items = repository.GetItems(); 
            return items;
        }

        // GET / items/{id}
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {

            var item = repository.GetItem(id);

            if(item is null )
            {
                return NotFound();
            }
            return item; 
        }

    } 
}