using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShameTheThronesV2.Repositories;
using ShameTheThronesV2.RequestModels;

namespace ShameTheThronesV2.Controllers
{
    [Route("api/[controller]")]
    public class RatingsController : Controller
    {

        private readonly RatingRepository _repo;

        public RatingsController(RatingRepository repo)
        {
            _repo = repo;
        }

        // GET api/values
        [HttpGet]
        public ActionResult Get(int restroomId)
        {
            if (!ModelState.IsValid)
                return new BadRequestObjectResult(ModelState);
            return Json(_repo.getRatings(restroomId));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] CreateRatingRequest request)
        {
            if (!ModelState.IsValid)
                return new BadRequestObjectResult(ModelState);
            return new ObjectResult(_repo.addRating(request));
        }
    }
}