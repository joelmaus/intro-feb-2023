﻿

using LearningResourcesApi.Controllers;

namespace LearningResourcesApi.IntegrationTests
{
    public class StatusResourceTests
    {
        [Fact]
        public async Task TheStatusResource()
        {
             using var host = await AlbaHost.For<Program>();

           var response = await host.Scenario(api => //integration test (many steps)
            {
                api.Get.Url("/status");
                api.StatusCodeShouldBeOk(); //200 status code
            });

            var responseMessage = response.ReadAsJson<GetStatusResponse>();

            Assert.NotNull(responseMessage);
            Assert.Equal("All Good", responseMessage.Message);
            Assert.Equal("555 555-5555", responseMessage.Contact);
        }

        [Fact]
        public async Task TheContactIsAPhoneNumberDuringBusinessHours()
        {
            await using var host = await AlbaHost.For<Program>(); var response = await host.Scenario(api => // Integration test - usually has many steps.
            {
                api.Get.Url("/status");
            }); var responseMessage = response.ReadAsJson<GetStatusResponse>();
            Assert.NotNull(responseMessage);
            Assert.Equal("All Good", responseMessage.Message);
            Assert.Equal("555 555-5555", responseMessage.Contact);
        }
    }
}
