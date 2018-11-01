using ApkDomain.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkDomain.DataModel.Repos
{
    public interface IApKRepository
    {
        void AddItemRange(IEnumerable<ItemEntity> itemEntities);
        void AddItem(ItemEntity item);
        void AddItemRaw(rawItemEntity rawItem);
        void Save();
        IEnumerable<ItemEntity> GetItems();
        IEnumerable<rawItemEntity> GetRawItems();
    }
}
