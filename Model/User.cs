using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public byte[] PassWord { get; set; }
        public byte[] Salt { get; set; }
        public string Tel { get; set; }
        public User()
        {
            Id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
        }
    }
}
