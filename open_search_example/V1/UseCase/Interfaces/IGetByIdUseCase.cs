using open_search_example.V1.Boundary.Response;

namespace open_search_example.V1.UseCase.Interfaces
{
    public interface IGetByIdUseCase
    {
        ResponseObject Execute(int id);
    }
}
