using System.ComponentModel.DataAnnotations;

namespace GregsListCSharp.Models
{
  public class Car
  {
    public int Id {get; set;}
    [Required]
    public string CreatorId {get; set;}
    [Required]
    public string Make {get; set;}
    [Required]
    public string Model {get; set;}
    [Required]
    public int Year {get; set;}
    [Required]
    public int Price {get; set;}
    [Required]
    public string ImgUrl {get; set;}
    public Profile Creator {get; set;}
    public string Description {get; set;}
  }
}