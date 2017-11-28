using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShameTheThronesV2.DB;
using ShameTheThronesV2.Models;
using ShameTheThronesV2.ResponseModels;

namespace ShameTheThronesV2.Repositories
{
    public class RatingRepository
    {
        private readonly ShameTheThronesContext _db;

        public RatingRepository(ShameTheThronesContext db)
        {
            _db = db;
        }

     
        public RatingCreatedResponse addRating(Rating rating)
        {
             _db.Ratings.Attach(rating);
            _db.Ratings.Add(rating);
            _db.SaveChanges();
            double average =_db.Ratings.Where(r => r.RestroomId == rating.RestroomId).Select(r => r.Value).Average();
            var restroom = _db.Restrooms.Find(rating.RestroomId);
            restroom.Rating = average;
            _db.SaveChanges();

            return new RatingCreatedResponse()
            {
                Rating = _db.Ratings.Find(rating.ID),
                NewAverageRating = average
            };
        }

        public List<Rating> getRatings(int restroomId)
        {
            return _db.Ratings.Where(r => r.RestroomId == restroomId).ToList();
        }
    }
}
