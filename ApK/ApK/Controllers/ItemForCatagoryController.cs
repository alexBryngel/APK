using ApK.Models;
using ApK.Service;
using ApkDomain.DataModel;
using ApkDomain.DataModel.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApK.Controllers
{
    public class ItemForCatagoryController : ApiController
    {

        [HttpGet]
        public IEnumerable<ItemModel> GetItemsForCatagory(string catagory)
        {
            var service = new ApkService(new ApKRepository(new ApkContext()));

            return service.GetItemsPerCatagory(catagory);
        }
    }
}
