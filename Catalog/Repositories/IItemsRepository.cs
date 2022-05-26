using System;
using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public interface UpdateItem
    {
        void UpdateItem(Item item);
    }

    public interface IItemsRepository : UpdateItem
    {
            IEnumerable<Item> GetItems();
            Item GetItem(Guid id);
            void CreateItem(Item item);
            void DeleteItem(Guid id);
    }
}