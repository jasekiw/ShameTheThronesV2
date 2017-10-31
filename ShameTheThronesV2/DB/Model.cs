using System;
using System.ComponentModel.DataAnnotations;

namespace ShameTheThronesV2.DB
{
    public abstract class Model
    {
        [Key]
        public int ID { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}