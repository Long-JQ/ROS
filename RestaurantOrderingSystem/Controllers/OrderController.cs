using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using RestaurantContext;

namespace RestaurantOrderingSystem.Controllers
{
    [EnableCors("AllowSameDomain")]
    public class OrderController : ApiController<Order>
    {
        /// <summary>
        /// 初始化DbContext
        /// </summary>
        public OrderController(RestaurantDataContext context) : base(context)
        {

        }
    }
}