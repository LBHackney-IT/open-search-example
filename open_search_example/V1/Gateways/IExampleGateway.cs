using System.Collections.Generic;
using open_search_example.V1.Domain;

namespace open_search_example.V1.Gateways
{
    public interface IExampleGateway
    {
        Entity GetEntityById(int id);

        List<Entity> GetAll();
    }
}
