using ApkDomain.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkDomain.DataModel.Repos
{
    public class ApKRepository
    {
        private ApkContext _apkContext;

        public ApKRepository(ApkContext apkContext)
        {
            _apkContext = apkContext;
        }

        public void AddItem(itemEntity item)
        {
            _apkContext.items.Add(item);
            Save();
        }
        public void AddItemRange(IEnumerable<itemEntity> itemEntities)
        {
            _apkContext.items.AddRange(itemEntities);
            Save();
        }

        public void AddItemRaw(rawItemEntity rawItem)
        {
            _apkContext.rawItems.Add(rawItem);
            Save();
        }

        public void Save()
        {
            _apkContext.SaveChanges();
        }

        public IEnumerable<itemEntity> GetItems()
        {
            return _apkContext.items;
        }

        public IEnumerable<rawItemEntity> GetRawItems()
        {
            return _apkContext.rawItems;
        }
    }
}
