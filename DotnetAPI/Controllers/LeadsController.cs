using Microsoft.AspNetCore.Mvc;

namespace DotnetAPI.Controllers;


public class LeadsController : ApiBaseController
{
    // GET
    public IActionResult Index()
    {
        return Ok($"Lead get method {DisplayName}");
    }
}