using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using RestaurantContext;

namespace RestaurantOrderingSystem.Controllers
{
    [EnableCors("AllowSameDomain")]
    public class BillController : ApiController<Bill>
    {
        /// <summary>
        /// 初始化DbContext
        /// </summary>
        public BillController(RestaurantDataContext context) : base(context)
        {

        }
    }
}