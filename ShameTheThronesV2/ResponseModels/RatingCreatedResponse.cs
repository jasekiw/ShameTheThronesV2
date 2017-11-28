using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShameTheThronesV2.Models;

namespace ShameTheThronesV2.ResponseModels
{
    public class RatingCreatedResponse
    {
        public double NewAverageRating { get; set; }
        public Rating Rating { get; set; }
    }
}
