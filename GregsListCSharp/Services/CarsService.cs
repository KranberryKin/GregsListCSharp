using System;
using System.Collections.Generic;
using GregsListCSharp.Data;
using GregsListCSharp.Models;

namespace GregsListCSharp.Services
{
  public class CarsService
  {
    private readonly FakeDb _db;

    public CarsService(FakeDb db)
    {
      _db = db;
    }
/// <summary>
/// Gets all Cars
/// </summary>
/// <returns></returns>
    public List<Car> getCars()
    {
      return _db.Cars;
    }
/// <summary>
/// Gets a single Car by it's Id
/// </summary>
/// <param name="carId"></param>
/// <returns></returns>
    public Car getCars(int carId)
    {
      return _db.Cars.Find(c => c.Id == carId);
    }

    public Car createCar(Car carData)
    {
      carData.Id = _db.GeanerateId();
      _db.Cars.Add(carData);
      return carData;
    }

    public Car editCar(int carId)
    {
      var car = _db.Cars.Find(c => c.Id == carId);
      return null;
    }
  }
}