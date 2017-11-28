using System.Collections.Generic;
using ShameTheThronesV2.Models;

namespace ShameTheThronesV2.Repositories.Interfaces
{
    public interface IRestroomsRepository
    {
        ICollection<Restroom> getRestrooms();

        Restroom getRestroomById(int id);

        Restroom createRestroom(Restroom restroom, bool attach = false);
    }
}