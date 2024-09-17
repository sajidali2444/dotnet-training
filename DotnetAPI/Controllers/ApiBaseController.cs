using Microsoft.AspNetCore.Mvc;

namespace DotnetAPI.Controllers;


[ApiController]
[Route("[controller]")]
public class ApiBaseController : ControllerBase
{
    public string DisplayName { get; } = "Dotnet API Project";
    private string Name = "Sajid";
    protected string Email = "Sajid";
}