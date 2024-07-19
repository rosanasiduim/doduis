using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/foo", Foo);

app.Run();

static Results<ContentHttpResult, BadRequest> Foo([FromQuery] bool condition)
{
    Results<ContentHttpResult, BadRequest> result = condition
        ? TypedResults.Text("Ok", statusCode: StatusCodes.Status200OK)
        : TypedResults.Text("Bad", statusCode: StatusCodes.Status400BadRequest);

    return result;
}
