

namespace LearningResourcesApi.IntegrationTests
{
    public class StatusResourceTests
    {
        [Fact]
        public async Task TheStatusResource()
        {
             using var host = await AlbaHost.For<Program>();

            await host.Scenario(api => //integration test (many steps)
            {
                api.Get.Url("/status");
                api.StatusCodeShouldBeOk(); //200 status code
            });
        }
    }
}
