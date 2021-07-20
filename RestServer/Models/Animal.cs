using System.ComponentModel.DataAnnotations;

namespace RestServer.Models
{
  public class Animal
  {
    public int Id {get; set;}
    [Required]
    public string Name {get; set;}
    [Required]
    public int Age {get; set;}
    [Required]
    public string Type {get; set;}
    [Required]
    public string Sex {get; set;}
    [Required]
    public bool Available {get; set;}
    [Required]
    public int PicHeight {get; set;}
    [Required]
    public int PicWidth {get; set;}

  }
}