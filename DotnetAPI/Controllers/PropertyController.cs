
using Microsoft.AspNetCore.Mvc;

namespace DotnetAPI.Controllers;



public class PropertyController : ApiBaseController
{
    // GET
    //[HttpGet("GetAll")]
    public IActionResult Index()
    {
        //return NotFound("kuch nahi mila bahi ko");
        //object or instance
        var user = new UserModel();
        user.FirstName = "Sajid Ali";
        //return Ok(new {users= user,displayName = DisplayName, email = Email});
        return Ok("Default Get Index Method");
    }

    // [HttpGet("GetById")]
    [Route("{id}")]//decorator or attribute 
    public IActionResult GetById(int id)
    {
        //return NotFound("kuch nahi mila bahi ko");
        //object or instance
        var user = new UserModel();
        user.FirstName = "Sajid Ali";
        //return Ok(new {users= user,displayName = DisplayName, email = Email,Id=id});
        return Ok("Get By Id Get Method");
    }


    [HttpPost("")]
    public IActionResult Create()
    {
        //return NotFound("kuch nahi mila bahi ko");
        //object or instance
        var user = new UserModel();
        user.FirstName = "Sajid Ali";
        return Ok("Create Property end point Post");
    }

    [HttpPatch]
    [Route("{id}")]
    public IActionResult Edit(int id)
    {
        //return NotFound("kuch nahi mila bahi ko");
        //object or instance

        var user = new UserModel();
        user.FirstName = "Sajid Ali";
        return Ok("Update Property");
    }


    public class UserModel
    {
        public string FirstName { get; set; }
    }
}