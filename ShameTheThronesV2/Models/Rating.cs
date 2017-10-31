using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ShameTheThronesV2.DB;

namespace ShameTheThronesV2.Models
{
    [Table("Ratings")]
    public class Rating : Model
    {
        [Required]
        public double Value { get; set; }
        [Required]
        public string Content { get; set; }
        
        public virtual ICollection<Comment> Comments { get; set; }
    }
}