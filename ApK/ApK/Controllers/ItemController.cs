using ApK.Models;
using ApkDomain.DataModel;
using ApkDomain.DataModel.Entities;
using ApkDomain.DataModel.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApK.Controllers
{
    public class ItemController : ApiController
    {
        [HttpGet]
        public IEnumerable<ItemEntity> GetItems()
        {
            var repo = new ApKRepository(new ApkContext());

            return repo.GetEntities();
        }

        [HttpPost]
        public void post()
        {

        }
    }
}
