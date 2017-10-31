using System.Collections.Generic;
using ShameTheThronesV2.Models;

namespace ShameTheThronesV2.Repositories.Interfaces
{
    public interface IRestroomsRespository
    {
        ICollection<Restroom> getRestrooms();

        Restroom getRestroomById(int id);

        void createRestroom(Restroom restroom, bool attach = false);
    }
}