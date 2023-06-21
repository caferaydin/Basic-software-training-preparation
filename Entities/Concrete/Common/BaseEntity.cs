﻿namespace SmartPro.Entities.Concrete.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
