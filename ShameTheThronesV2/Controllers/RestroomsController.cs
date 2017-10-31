using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShameTheThronesV2.DB;
using ShameTheThronesV2.Models;
using ShameTheThronesV2.Repositories;
using ShameTheThronesV2.Repositories.Interfaces;

namespace ShameTheThronesV2.Controllers
{
    [Route("api/[controller]")]
    public class RestroomsController : Controller
    {
       
        private readonly IRestroomsRespository _repo;
        
        public RestroomsController(IRestroomsRespository repo)
        {
            _repo = repo;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Restroom> Get()
        {
            return _repo.getRestrooms();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Restroom Get(int id)
        {
            return _repo.getRestroomById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Restroom value)
        {
            _repo.createRestroom(value, true);
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