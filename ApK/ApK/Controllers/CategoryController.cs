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
    public class CategoryController : ApiController
    {
        public Dictionary<string, int> Get()
        {
            var service = new ApkService(new ApKRepository(new ApkContext()));

            return service.GetCategorys();
        }
    }
}
