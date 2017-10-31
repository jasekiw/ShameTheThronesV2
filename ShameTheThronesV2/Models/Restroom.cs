using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ShameTheThronesV2.DB;

namespace ShameTheThronesV2.Models
{
    [Table("Restrooms")]
    public class Restroom : Model
    {
        [Required]
        public decimal Lat { get; set; }
        [Required]
        public decimal Lng { get; set; }
        
        public string Address { get; set; }
        public string City { get; set; }
        public int? ZipCode { get; set; }
        public string State { get; set; }
        public int? UserId { get; set; }
        public string Description { get; set; }
        public byte? Gender { get; set; }
        
        public virtual User User { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}