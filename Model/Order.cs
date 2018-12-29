using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Order : BaseEntity
    {
        public string TableNumber { get; set; }
        public string OrderCode { get; set; }
        public Order()
        {
            Id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
        }
    }
}
