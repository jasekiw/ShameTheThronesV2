using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShameTheThronesV2.DB;
using ShameTheThronesV2.Middleware;
using ShameTheThronesV2.Models;
using ShameTheThronesV2.Repositories;
using ShameTheThronesV2.Repositories.Interfaces;
using ShameTheThronesV2.RequestModels;

namespace ShameTheThronesV2.Controllers
{
    [ValidateModel]
    [Route("api/[controller]")]
    public class RestroomsController : Controller
    {
       
        private readonly IRestroomsRepository repo;
        
        public RestroomsController(IRestroomsRepository repo)
        {
            this.repo = repo;
        }

        // GET api/restrooms
        [HttpGet]
        public ICollection<Restroom> Get(RestroomSearchRequest request) => repo.Get();

        // GET api/restrooms/5
        [HttpGet("{id}")]
        public Restroom Get(int id) => repo.Get(id);

        // POST api/restrooms
        [HttpPost]
        public Restroom Post([FromBody] CreateRestroomRequest request) => repo.Add(request);

        // PUT api/restrooms/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/restrooms/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}