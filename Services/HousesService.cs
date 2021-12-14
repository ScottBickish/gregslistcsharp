using gregslistcsharp.DB;
using gregslistcsharp.Models;

namespace gregslistcsharp.Services
{
  public class HousesService
  {
    internal List<House> Get()
    {
      return FakeDB.Houses;
    }
    internal House Get(string id)
    {
      House found = FakeDB.Houses.Find(h => h.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }
    internal House Create(House newHouse)
    {
      FakeDB.Houses.Add(newHouse);
      return newHouse;
    }
    internal void Remove(string id)
    {
      House house = Get(id);
      FakeDB.Houses.Remove(house);
    }
    internal House Update(House updatedHouse)
    {
      House oldHouse = Get(updatedHouse.Id);
      oldHouse.Bedrooms = updatedHouse.Bedrooms != 0 ? updatedHouse.Bedrooms : oldHouse.Bedrooms;
      oldHouse.Bathrooms = updatedHouse.Bathrooms != 0 ? updatedHouse.Bathrooms : oldHouse.Bathrooms;
      oldHouse.Levels = updatedHouse.Levels != 0 ? updatedHouse.Levels : oldHouse.Levels;
      oldHouse.ImgUrl = updatedHouse.ImgUrl != null ? updatedHouse.ImgUrl : oldHouse.ImgUrl;
      oldHouse.Year = updatedHouse.Year != 0 ? updatedHouse.Year : oldHouse.Year;
      oldHouse.Price = updatedHouse.Price != 0 ? updatedHouse.Price : oldHouse.Price;
      oldHouse.Description = updatedHouse.Description != null ? updatedHouse.Description : oldHouse.Description;
      return oldHouse;
    }
  }
}