using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShameTheThronesV2.RequestModels
{
    public class RestroomSearchRequest
    {

        [Range(-90, 90)]
        [Required]
        public decimal? northEastLat { get; set; }
        [Range(-180, 180)]
        [Required]
        public decimal? northEastLng { get; set; }
        [Range(-90, 90)]
        [Required]
        public decimal? southWestLat { get; set; }
        [Range(-180, 180)]
        [Required]
        public decimal? southWestLng { get; set; }
    }
}
