using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ShameTheThronesV2.DB;

namespace ShameTheThronesV2.Models
{
    [Table("Comments")]
    public class Comment : Model
    {
        public virtual ICollection<Comment> Replies { get; set; }
        [Required]
        public string Content { get; set; }
        public User User { get; set; }
    }
}