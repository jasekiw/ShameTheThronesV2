using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShameTheThronesV2.DB;
using ShameTheThronesV2.Models;
using ShameTheThronesV2.Repositories;
using ShameTheThronesV2.Repositories.Interfaces;
using ShameTheThronesV2.RequestModels;

namespace ShameTheThronesV2.Controllers
{
    [Route("api/[controller]")]
    public class RestroomsController : Controller
    {
       
        private readonly IRestroomsRepository _repo;
        
        public RestroomsController(IRestroomsRepository repo)
        {
            _repo = repo;
        }
        // GET api/values
        [HttpGet]
        public ActionResult Get(RestroomSearchRequest request)
        {
            if (!ModelState.IsValid)
                return new BadRequestObjectResult(ModelState);
            return Json(_repo.getRestrooms());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Restroom Get(int id)
        {
            return _repo.getRestroomById(id);
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] CreateRestroomRequest request)
        {
            if (!ModelState.IsValid)
                return new BadRequestObjectResult(ModelState);
           return new ObjectResult(_repo.createRestroom(request, true));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}