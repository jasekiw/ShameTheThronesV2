using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShameTheThronesV2.RequestModels
{
    public class CreateRatingRequest
    {
        [Required]
        public double? Value { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int? RestroomId { get; set; }
    }
}
