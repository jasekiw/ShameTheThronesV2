using System.Collections.Generic;
using ShameTheThronesV2.Models;

namespace ShameTheThronesV2.Repositories.Interfaces
{
    public interface IRestroomsRepository
    {
        ICollection<Restroom> Get();

        Restroom Get(int id);

        Restroom Add(Restroom restroom);
    }
}