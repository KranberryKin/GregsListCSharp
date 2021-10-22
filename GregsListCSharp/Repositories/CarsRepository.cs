using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using GregsListCSharp.Models;

namespace GregsListCSharp.Repositories
{
  public class CarsRepository
  {
  private readonly IDbConnection _db;

    public CarsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal Car GetById(int carId)
    {
      string sql = "SELECT * FROM cars WHERE id = @carId;";
      return _db.QueryFirstOrDefault<Car>(sql, new { carId });
    }

    internal List<Car> GetAll()
    {
      string sql = "SELECT * FROM cars;";
      return _db.Query<Car>(sql).ToList();
    }

    internal Car CreateCar(Car carData)
    {
      throw new NotImplementedException();
    }

    internal Car Put(int carId)
    {
      throw new NotImplementedException();
    }

    internal void Delete(int carId)
    {
      throw new NotImplementedException();
    }
  }
}