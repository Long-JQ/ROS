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
    public class FoodController : ApiController<Food>
    {
        /// <summary>
        /// 初始化DbContext
        /// </summary>
        public FoodController(RestaurantDataContext context) : base(context)
        {

        }
    }
}