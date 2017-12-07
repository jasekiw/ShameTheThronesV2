using System.Collections.Generic;
using System.Linq;
using ShameTheThronesV2.DB;
using ShameTheThronesV2.Models;
using ShameTheThronesV2.Repositories.Interfaces;

namespace ShameTheThronesV2.Repositories
{
    public class RestroomRepository : IRestroomsRepository
    {
        private readonly ShameTheThronesContext _db;
        
        public RestroomRepository(ShameTheThronesContext db)
        {
            _db = db;
        }
        
        public ICollection<Restroom> Get()
        {
            return _db.Restrooms.ToList();
        }

        public Restroom Get(int id)
        {
            return _db.Restrooms.Find(id);
        }

        public Restroom Add(Restroom restroom)
        {
            _db.Restrooms.Add(restroom);
            _db.SaveChanges();
            return _db.Restrooms.Find(restroom.ID);
        }
        
    }
}