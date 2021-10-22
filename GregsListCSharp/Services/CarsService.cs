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
      // FIXME Call to repository!
      return null;
    }
/// <summary>
/// Gets a single Car by it's Id
/// </summary>
/// <param name="carId"></param>
/// <returns></returns>
    public Car getCars(int carId)
    {
      // FIXME Call to repository!
      return null;
    }

    public Car createCar(Car carData)
    {
      // FIXME Call to repository!
      return null;
    }

    public Car editCar(int carId)
    {
      // FIXME Call to repository!
      return null;
    }

    internal void DeleteCar(int id)
    {
      // FIXME Call to repository!
    }
  }
}