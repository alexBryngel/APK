﻿using ApkDomain.DataModel.Entities;
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

        public void addItem(ItemEntity item)
        {
            _apkContext.items.Add(item);
            _apkContext.SaveChanges();
        }

        public void addItemRaw(rawItemEntity rawItem)
        {
            _apkContext.rawItems.Add(rawItem);
            //_apkContext.SaveChanges();
        }

        public void save()
        {
            _apkContext.SaveChanges();
        }

        public IEnumerable<ItemEntity> GetEntities()
        {
            return _apkContext.items;
        }
    }
}
