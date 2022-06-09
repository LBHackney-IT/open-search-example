using open_search_example.V1.Controllers;
using open_search_example.V1.UseCase.Interfaces;
using Hackney.Core.Testing.Shared;
using Moq;
using NUnit.Framework;

namespace open_search_example.Tests.V1.Controllers
{
    [TestFixture]
    public class open_search_exampleControllerTests : LogCallAspectFixture
    {
        private open_search_exampleController _classUnderTest;
        private Mock<IGetByIdUseCase> _mockGetByIdUseCase;
        private Mock<IGetAllUseCase> _mockGetByAllUseCase;

        [SetUp]
        public void SetUp()
        {
            _mockGetByIdUseCase = new Mock<IGetByIdUseCase>();
            _mockGetByAllUseCase = new Mock<IGetAllUseCase>();
            _classUnderTest = new open_search_exampleController(_mockGetByAllUseCase.Object, _mockGetByIdUseCase.Object);
        }


        //Add Tests Here
    }
}
