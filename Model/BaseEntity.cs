using System;

namespace Model
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public string SortCode { get; set; }
    }
}
