using System;
using System.Collections.Generic;
using Icats.Interfaces;
using Icats.Models;

namespace Icats.Repositories
{
  public class CatsRepository : IRepository<Cat, int>
  {
    public Cat Create(Cat data)
    {
      throw new NotImplementedException();
    }

    public string Delete(int id)
    {
      throw new NotImplementedException();
    }

    public Cat Edit(Cat data)
    {
      throw new NotImplementedException();
    }

    public List<Cat> GetAll()
    {
      throw new NotImplementedException();
    }

    public Cat GetById(string id)
    {
      throw new NotImplementedException();
    }
  }
}