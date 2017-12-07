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
        private readonly ShameTheThronesContext db;

        public RatingRepository(ShameTheThronesContext db)
        {
            this.db = db;
        }


        public ICollection<Rating> Get(int restroomId)
        {
            return db.Ratings.Where(r => r.RestroomId == restroomId).ToList();
        }

        public RatingCreatedResponse Add(Rating rating)
        {
            db.Ratings.Attach(rating);
            db.Ratings.Add(rating);
            db.SaveChanges();

            var average = db.Ratings.Where(r => r.RestroomId == rating.RestroomId).Select(r => r.Value).Average();

            var restroom = db.Restrooms.Find(rating.RestroomId);

            restroom.Rating = average;
            db.SaveChanges();

            return new RatingCreatedResponse()
            {
                Rating = db.Ratings.Find(rating.ID),
                NewAverageRating = average
            };
        }

       
    }
}
