using System;
using Moq;
using ShameTheThronesV2.Controllers;
using ShameTheThronesV2.Models;
using ShameTheThronesV2.Repositories.Interfaces;
using ShameTheThronesV2.RequestModels;
using Xunit;

namespace ShameTheThronesV2.Tests.Unit
{
    public class RestroomsController_PostShould
    {
        private readonly RestroomsController _restroomsController;
        private readonly Mock<IRestroomsRepository> _mockRepo;
        public RestroomsController_PostShould()
        {
            _mockRepo = new Mock<IRestroomsRepository>();
            _restroomsController = new RestroomsController(_mockRepo.Object);
        }
        
        [Fact]
        public void CreateNewRestroom()
        {

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
//            _restroomsController.Post(request);
//            _mockRepo.Verify(m => m.createRestroom(request, true));
        }
    }
}