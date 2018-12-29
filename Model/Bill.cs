using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Bill: BaseEntity
    {
        public string Name { get; set; }
        public Bill()
        {
            Id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
        }
    }
}
