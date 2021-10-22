using System;
using System.Collections.Generic;
using System.Data;
using GregsListCSharp.Data;
using GregsListCSharp.Models;
using GregsListCSharp.Repositories;

namespace GregsListCSharp.Services
{
  public class CarsService
  {
    private readonly CarsRepository _cr;

    public CarsService(CarsRepository cr)
    {
      _cr = cr;
    }

    /// <summary>
    /// Gets all Cars
    /// </summary>
    /// <returns></returns>
    public List<Car> getCars()
    {
      return _cr.GetAll();
    }
/// <summary>
/// Gets a single Car by it's Id
/// </summary>
/// <param name="carId"></param>
/// <returns></returns>
    public Car getCars(int carId)
    {
      var foundCar = _cr.GetById(carId);
      if (foundCar == null)
      {
        throw new Exception("Can't find Car");
      }
      return foundCar;
    }
/// <summary>
/// Creates a Car
/// </summary>
/// <param name="carData"></param>
/// <returns></returns>
    public Car createCar(Car carData)
    {
      return _cr.CreateCar(carData);
    }
/// <summary>
/// Updates A Car
/// </summary>
/// <param name="carId"></param>
/// <returns></returns>
    public Car editCar(int carId)
    {
      return _cr.Put(carId);
    }
/// <summary>
/// Removes a Car
/// </summary>
/// <param name="id"></param>
    internal void DeleteCar(int carId)
    {
      _cr.Delete(carId);
    }
  }
}