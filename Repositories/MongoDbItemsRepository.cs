using CATALOG.Entities;

namespace CATALOG.Repositories;

public class MongoDbItemsRepository : IItemsRepository 
{
    public Item GetItem(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Item> GetItems()
    {
        throw new NotImplementedException();
    }

    public void CreateItem(Item item)
    {
        throw new NotImplementedException();
    }

    public void UpdateItem(Item item)
    {
        throw new NotImplementedException();
    }

    public void DeleteItem(Guid id)
    {
        throw new NotImplementedException();
    }
}