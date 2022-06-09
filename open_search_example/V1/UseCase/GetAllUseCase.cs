using open_search_example.V1.Boundary.Response;
using open_search_example.V1.Factories;
using open_search_example.V1.Gateways;
using open_search_example.V1.UseCase.Interfaces;
using Hackney.Core.Logging;

namespace open_search_example.V1.UseCase
{
    //TODO: Rename class name and interface name to reflect the entity they are representing eg. GetAllClaimantsUseCase
    public class GetAllUseCase : IGetAllUseCase
    {
        private readonly IExampleGateway _gateway;
        public GetAllUseCase(IExampleGateway gateway)
        {
            _gateway = gateway;
        }
        [LogCall]
        public ResponseObjectList Execute()
        {
            return new ResponseObjectList { ResponseObjects = _gateway.GetAll().ToResponse() };
        }
    }
}