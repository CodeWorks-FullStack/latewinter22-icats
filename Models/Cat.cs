namespace Icats.Models
{
  public class Cat : Virtual<int>
  {
    public string Name { get; set; }
    public string Color { get; set; }
    public int Lives { get; set; }
  }
}