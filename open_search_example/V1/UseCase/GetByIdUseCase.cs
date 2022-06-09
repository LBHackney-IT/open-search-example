using open_search_example.V1.Boundary.Response;
using open_search_example.V1.Factories;
using open_search_example.V1.Gateways;
using open_search_example.V1.UseCase.Interfaces;
using Hackney.Core.Logging;

namespace open_search_example.V1.UseCase
{
    //TODO: Rename class name and interface name to reflect the entity they are representing eg. GetClaimantByIdUseCase
    public class GetByIdUseCase : IGetByIdUseCase
    {
        private IExampleGateway _gateway;
        public GetByIdUseCase(IExampleGateway gateway)
        {
            _gateway = gateway;
        }
        [LogCall]
        //TODO: rename id to the name of the identifier that will be used for this API, the type may also need to change
        public ResponseObject Execute(int id)
        {
            return _gateway.GetEntityById(id).ToResponse();
        }
    }
}