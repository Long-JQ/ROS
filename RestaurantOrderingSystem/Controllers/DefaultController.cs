using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using RestaurantContext;
using RestaurantOrderingSystem.Common;

namespace RestaurantOrderingSystem.Controllers
{
    //[Produces("application/json")]
    //[Route("api/Default")]
    //[EnableCors("AllowSameDomain")]
    public class DefaultController : ApiController<Bill>
    {
        /// <summary>
        /// 初始化DbContext
        /// </summary>
        public DefaultController(RestaurantDataContext context) : base(context)
        {

        }
    }
}
