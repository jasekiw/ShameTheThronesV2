using System;
using Moq;
using ShameTheThronesV2.Controllers;
using ShameTheThronesV2.Models;
using ShameTheThronesV2.Repositories.Interfaces;
using Xunit;

namespace ShameTheThronesV2.Tests.Unit
{
    public class RestroomsController_PostShould
    {
        private readonly RestroomsController _restroomsController;
        private readonly Mock<IRestroomsRespository> _mockRepo;
        public RestroomsController_PostShould()
        {
            _mockRepo = new Mock<IRestroomsRespository>();
            _restroomsController = new RestroomsController(_mockRepo.Object);
        }
        
        [Fact]
        public void CreateNewRestroom()
        {

            var restroom = new Restroom()
            {
                Lat = 50.33m,
                Lng = 50.33m
            };
            _restroomsController.Post(restroom);
            _mockRepo.Verify(m => m.createRestroom(restroom, true));
        }
    }
}