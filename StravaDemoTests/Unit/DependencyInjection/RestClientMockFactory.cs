using Moq;
using RestSharp;

namespace StravaDemoTests.Unit.DependencyInjection
{
    public static class RestClientMockFactory
    {
        public static IRestClient Get<TDto>(TDto returnedDto) where TDto : new()
        {
            Mock<IRestResponse<TDto>> restResponseMock = new Mock<IRestResponse<TDto>>();
            restResponseMock.Setup(p => p.Data).Returns(returnedDto);

            Mock<IRestClient> restClientMock = new Mock<IRestClient>();
            restClientMock.Setup(p => p.Execute<TDto>(It.IsAny<IRestRequest>())).Returns(restResponseMock.Object);
            
            return restClientMock.Object;
        }
    }
}
