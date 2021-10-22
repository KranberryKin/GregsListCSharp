using System.Collections.Generic;
using System.Threading.Tasks;
using CodeWorks.Auth0Provider;
using GregsListCSharp.Models;
using GregsListCSharp.Services;
using Microsoft.AspNetCore.Mvc;

namespace GregsListCSharp.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

  public class CarsController : ControllerBase
  {
    private readonly CarsService _cs;
    public CarsController(CarsService cs)
    {
      _cs = cs;
    }

    [HttpGet]

    public ActionResult<List<Car>> getCars()
    {
        try
      {
        var cars = _cs.getCars();
        return Ok(cars);
      }
        catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

      [HttpGet("{carId}")]

      public ActionResult<Car> getCarById(int carId)
    {
        try
      {
        var car = _cs.getCars(carId);
        return Ok(car);
      }
        catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]

    public async Task<ActionResult<Car>> createCar([FromBody] Car carData)
    {
      try
      {
           Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
           carData.CreatorId = userInfo.Id;
           var car = _cs.createCar(carData);
           return Ok(car);
      }
      catch (System.Exception e)
      {
          return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Car> editCar(int carId)
    {
      try
      {
        var car = _cs.editCar(carId);
           return Ok(car);
      }
      catch (System.Exception e)
      {
          return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<Car> Delete(int id){
      try
      {
          _cs.DeleteCar(id);
           return Ok("Car Deleted");
      }
      catch (System.Exception e)
      {
          return BadRequest(e.Message);
      }
    }
  }
}