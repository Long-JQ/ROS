using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Food : BaseEntity
    {
        public string Price { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        public Food()
        {
            Id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
        }
    }
}
