using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ShameTheThronesV2.DB;

namespace ShameTheThronesV2.Models
{
    [Table("Users")]
    public class User : Model
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public ICollection<Restroom> Restrooms { get; set; }
    }
}