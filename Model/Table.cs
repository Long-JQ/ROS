using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Table : BaseEntity
    {
        public Table()
        {
            Id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
        }
    }
}
