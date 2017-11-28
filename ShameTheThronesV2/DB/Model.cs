using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShameTheThronesV2.DB
{
    public abstract class Model
    {
        [Key]
        public int ID { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}