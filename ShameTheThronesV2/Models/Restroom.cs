using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ShameTheThronesV2.DB;
using ShameTheThronesV2.RequestModels;

namespace ShameTheThronesV2.Models
{
    [Table("Restrooms")]
    public class Restroom : Model
    {
        [Column(TypeName = "decimal(18,14)")]
        [Required]
        public decimal Lat { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,14)")]
        public decimal Lng { get; set; }
        public int? UserId { get; set; }
        [Required]
        public byte Gender { get; set; }
       
        [Required]
        public String PlaceId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }

        public double Rating { get; set; }



        public static implicit operator Restroom(CreateRestroomRequest d)
        {
            return new Restroom()
            {
                PlaceId = d.PlaceId,
                Gender = d.Gender.Value,
                Lat = d.Lat.Value,
                Lng =  d.Lng.Value,
            };
        }
    }
}