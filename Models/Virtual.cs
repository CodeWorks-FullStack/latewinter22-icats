using System;
using Icats.Interfaces;

namespace Icats.Models
{
  public class Virtual<T> : IRepoItem<T>
  {
    public T Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string CreatorId { get; set; }
  }
}