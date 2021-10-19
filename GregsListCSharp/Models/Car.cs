using System.ComponentModel.DataAnnotations;

namespace GregsListCSharp.Models
{
  public class Car
  {
    public int Id {get; set;}
    [Required]
    public string Make {get; set;}
    public string Model {get; set;}
    
  }
}