using Microsoft.AspNetCore.Mvc;
using gregslistcsharp.Models;
using gregslistcsharp.Services;

namespace gregslistcsharp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class HousesController : ControllerBase
  {
      private readonly HousesService _hs;
      public HousesController(HousesService hs)
      {
        _hs = hs;
      }
      [HttpGet]
      public ActionResult<IEnumerable<House>> Get()
      {
        try
        {
             List<House> houses = _hs.Get();
             return Ok(houses);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
            
        }
      }
      [HttpGet("{id}")]
      public ActionResult<House> Get(string id)
      {
        try
        {
             House house = _hs.Get(id);
             return Ok(house);
        }
        catch (Exception e)
        {
            
            return BadRequest(e.Message);
        }
      }
      [HttpPost]
      public ActionResult<House> Create([FromBody] House newHouse)
      {
        try
        {
             House house = _hs.Create(newHouse);
             return Ok(house);
        }
        catch (Exception e)
        {
            
            return BadRequest(e.Message);
        }
      }
      [HttpDelete("{id}")]
      public ActionResult<String> Remove(string id)
      {
        try
        {
             _hs.Remove(id);
             return Ok("there was a terrible fire");
        }
        catch (Exception e)
        {
            
            return BadRequest(e.Message);
        }
      }
      [HttpPut("{id}")]
      public ActionResult<House> Create([FromBody] House updatedHouse, string id)
      {
        try
        {
             updatedHouse.Id = id;
             House house = _hs.Update(updatedHouse);
             return Ok(updatedHouse);
        }
        catch (Exception e)
        {
            
            return BadRequest(e.Message);
        }
      }
  }
}