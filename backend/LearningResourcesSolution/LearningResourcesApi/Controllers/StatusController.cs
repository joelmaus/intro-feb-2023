using LearningResourcesApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearningResourcesApi.Controllers
{
    public class StatusController : ControllerBase
    {
        private ISystemTime _systemTime;

        public StatusController(ISystemTime systemTime)
        {
            _systemTime = systemTime;
        }

        //GET http:localhost:1337/status
        [HttpGet("/status")]
        public ActionResult GetTheStatus()
        {
            var contact = _systemTime.GetCurrent().Hour < 16 ? "bob@aol.com" : "555 555-5555";
            var response = new GetStatusResponse
            {
                Message = "All Good",
                Contact = "555 555-5555"
            };
            return Ok(response); //sends "response" to client
        }
    }
}

public class GetStatusResponse
{
    public string Message { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;
}