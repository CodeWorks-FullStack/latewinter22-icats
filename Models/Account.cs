using System;
using Icats.Interfaces;

namespace Icats.Models
{

  public class Profile : IRepoItem<string>
  {
    public string Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public string Name { get; set; }
    public string Picture { get; set; }


  }
  public class Account : Profile
  {
    public string Email { get; set; }
    public string StreetAdress { get; set; }
    public int CreditCardNumber { get; set; }
    public int Longitude { get; set; }
    public int Latitude { get; set; }
  }
}