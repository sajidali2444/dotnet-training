
using DotnetAPI.DTO;
using DotnetAPI.Entities;
using DotnetAPI.Request;
using Microsoft.AspNetCore.Mvc;

namespace DotnetAPI.Controllers;



public class CitiesController : ApiBaseController
{
    AppDBContext _db;
    public CitiesController(AppDBContext context)
    {
        _db = context;
    }
    // GET
    //[HttpGet("GetAll")]
    public IActionResult Index()
    {
        var cities = _db.Cities.ToList();

        return Ok(cities);
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
    public IActionResult Create(City city)
    {
        _db.Cities.Add(city);
        _db.SaveChanges();
        return Ok(city);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetCityById(int id)
    {
        // var city = _db.Cities.FirstOrDefault(w => w.Id == id);
        //
        // return Ok(city);
        // var city = _db.Cities.Where(w => w.Id == id)
        //     .Select(s => new City()
        //     {
        //         Id = s.Id,
        //         Name = s.Name
        //     })
        //     .ToList();
        //
        // return Ok(city);
        
        var city = _db.Cities.FirstOrDefault(w => w.Id == id);
        var cityDTO = new CityDTO()
        {
            CityId = city.Id,
            CityName = city.Name
        };
        return Ok(cityDTO);
    }

    [HttpPatch]
    [Route("{id}")]
    public IActionResult Edit(CityRequest city)
    {
        
        
        return Ok("Update Property");
    }


    public class UserModel
    {
        public string FirstName { get; set; }
    }
}