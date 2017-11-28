using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShameTheThronesV2.RequestModels
{
    public class CreateRestroomRequest
    {
        [Range(-90, 90)]
        [Required]
        public decimal? Lat { get; set; }
        [Range(-180, 180)]
        [Required]
        public decimal? Lng { get; set; }
        [Required]
        public string PlaceId { get; set; }
        [Required]
        public byte? Gender { get; set; }
    }
}
