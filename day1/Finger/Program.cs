
using Finger;


var builder = WebApplication

var app = builder.Build();

app.MapGet("/status",() => {
    var status = new StatusMessage("All is good.", System.DateTimeOffset.MaxValue.Now);
    return status;
});

app.MapPost("/status",(StatusRequest req) => {
    return req;
});

app.Run();