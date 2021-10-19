using System;
using System.Collections.Generic;
using GregsListCSharp.Models;

namespace GregsListCSharp.Data {
public class FakeDb{
  private Random _random = new Random();
  public List<Car> Cars = new List<Car>();

  public int GeanerateId()
  {
    return _random.Next(100000, 10000000);
  }
}
}