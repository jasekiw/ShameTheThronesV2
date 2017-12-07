using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShameTheThronesV2.Middleware;
using ShameTheThronesV2.Models;
using ShameTheThronesV2.Repositories;
using ShameTheThronesV2.RequestModels;
using ShameTheThronesV2.ResponseModels;

namespace ShameTheThronesV2.Controllers
{
    [ValidateModel]
    [Route("api/[controller]")]
    public class RatingsController : Controller
    {

        private readonly RatingRepository repo;

        public RatingsController(RatingRepository repo)
        {
            this.repo = repo;
        }

        // GET api/Ratings
        [HttpGet]
        public ICollection<Rating> Get(int restroomId) => repo.Get(restroomId);

        /// <summary>
        /// POST api/Ratings
        /// </summary>
        /// <param name="request">A new rating request model.</param>
        /// <returns> 200: The created rating | 400 </returns>
        [HttpPost]
        public RatingCreatedResponse Post([FromBody] CreateRatingRequest request) => repo.Add(request);
    }
}