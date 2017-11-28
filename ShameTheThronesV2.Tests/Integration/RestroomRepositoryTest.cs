using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using Newtonsoft.Json;
using ShameTheThronesV2.Controllers;
using ShameTheThronesV2.DB;
using ShameTheThronesV2.Models;
using ShameTheThronesV2.Repositories;
using ShameTheThronesV2.Repositories.Interfaces;
using ShameTheThronesV2.RequestModels;
using Xunit;

namespace ShameTheThronesV2.Tests.Integration
{
    public class RestroomRepositoryTest : TestCase
    {
   
       

        [Fact]
        public void CreateNewRestroom()
        {
//            var controller = new RestroomsController(new RestroomRepository(_context));
//            var request = new CreateRestroomRequest()
//            {
//                Address = "252 E Market St",
//                City = "Louisville",
//                State = "KY",
//                ZipCode = 40202,
//                Lat = 38.2540272m,
//                Lng = -85.748971m,
//                Gender = 2,
//                Description = "A nice place"
//            };
//         
//            controller.Post(request);
//            Restroom restroom = _context.Restrooms.Where(e => e.Address == "252 E Market St").First();
//            Assert.NotNull(restroom);
//            _context.Restrooms.Remove(restroom);
//            _context.SaveChanges();
        }
    }
}
