using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ShameTheThronesV2.DB;
using ShameTheThronesV2.RequestModels;

namespace ShameTheThronesV2.Models
{
    [Table("Ratings")]
    public class Rating : Model
    {
        [Required]
        public double Value { get; set; }
        [Required]
        public string Content { get; set; }

        public int RestroomId { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public static implicit operator Rating(CreateRatingRequest d)
        {
            return new Rating()
            {
                Value = d.Value.Value,
                Content = d.Content,
                RestroomId = d.RestroomId.Value,
            };
        }
    }
}