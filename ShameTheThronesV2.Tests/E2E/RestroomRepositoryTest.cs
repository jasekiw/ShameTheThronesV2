using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

namespace ShameTheThronesV2.Tests.E2E
{
    public class RestroomRepositoryTest : TestCase
    {

        private string baseUrl = "/api/restrooms";
   
 
        [Fact]
        public async void PostShould_CreateNewRestroom()
        {

            var request = new CreateRestroomRequest()
            {
                Lat = 38.2540272m,
                Lng = -85.748971m,
                Gender = 2,
                PlaceId = "somePlaceId"
            };

            var response = await _client.PostAsync(baseUrl, Json(request));
            // ensure success
            response.EnsureSuccessStatusCode();
            var responseRestroom = await ParseJson<Restroom>(response);

            // assertions
            Assert.Equal(request.Lat.Value, responseRestroom.Lat);
            Assert.Equal(request.Lng.Value, responseRestroom.Lng);
            Assert.Equal(request.Gender.Value, responseRestroom.Gender);
            Assert.Equal(request.PlaceId, responseRestroom.PlaceId);

            // cleanup
            var restroom = _context.Restrooms.First(e => e.PlaceId == "somePlaceId");
            Assert.NotNull(restroom);
            _context.Restrooms.Remove(restroom);
            _context.SaveChanges();
        }




        [Fact]
        public async void PostShould_HandleBadRequests()
        {
            var request = new CreateRestroomRequest();
            var response = await _client.PostAsync(baseUrl, Json(request));
            // ensure 400
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            var errorResponse = await ParseJson<IDictionary<string, object>>(response);
            Assert.True(errorResponse.Count == 4);
        }
    }
}
