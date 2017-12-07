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
        private RestroomsController _restroomsController;
        private Mock<IRestroomsRepository> _mockRepo;

        public RestroomsController_PostShould()
        {
            _mockRepo = new Mock<IRestroomsRepository>();
            _restroomsController = new RestroomsController(_mockRepo.Object);
        }
        
        [Fact]
        public void CreateNewRestroom()
        {
           // prepare
            var request = new CreateRestroomRequest()
            {
                Lat = 38.2540272m,
                Lng = -85.748971m,
                Gender = 2,
                PlaceId = "somePlaceId"
            };

            // perform action
            _restroomsController.Post(request);

            // assertions
            _mockRepo.Verify(m => m.Add(It.Is<Restroom>((val) => 
                val.Lat == request.Lat.Value &&
                val.Lng == request.Lng.Value &&
                val.Gender == request.Gender.Value &&
                val.PlaceId == request.PlaceId
            )));
        }

    }
}