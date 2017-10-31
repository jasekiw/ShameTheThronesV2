using System.Collections.Generic;
using System.Linq;
using ShameTheThronesV2.DB;
using ShameTheThronesV2.Models;
using ShameTheThronesV2.Repositories.Interfaces;

namespace ShameTheThronesV2.Repositories
{
    public class RestroomRespository : IRestroomsRespository
    {
        private readonly ShameTheThronesContext _db;
        
        public RestroomRespository(ShameTheThronesContext db)
        {
            _db = db;
        }
        
        public ICollection<Restroom> getRestrooms()
        {
            return _db.Restrooms.ToList();
        }

        public Restroom getRestroomById(int id)
        {
            return _db.Restrooms.Find(id);
        }

        public void createRestroom(Restroom restroom, bool attach = false)
        {
            if (attach)
                _db.Restrooms.Attach(restroom);
            _db.Restrooms.Add(restroom);
            _db.SaveChanges();
        }
        
    }
}