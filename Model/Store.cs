using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Store : BaseEntity
    {
        public string Name { get; set; }
        public Store()
        {
            Id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
        }
    }
}
