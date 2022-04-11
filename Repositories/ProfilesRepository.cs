using System.Collections.Generic;
using Icats.Interfaces;
using Icats.Models;

namespace Icats.Repositories
{
  public class ProfilesRepository : IRepository<Profile, string>
  {
    public Profile Create(Profile data)
    {
      throw new System.NotImplementedException();
    }

    public string Delete(string id)
    {
      throw new System.NotImplementedException();
    }

    public Profile Edit(Profile data)
    {
      throw new System.NotImplementedException();
    }

    public List<Profile> GetAll()
    {
      throw new System.NotImplementedException();
    }

    public Profile GetById(string id)
    {
      throw new System.NotImplementedException();
    }
  }
}