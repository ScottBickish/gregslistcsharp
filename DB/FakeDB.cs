using gregslistcsharp.Models;

namespace gregslistcsharp.DB
{
  public static class FakeDB
  {
    public static List<House>? Houses {get; set;} = new List<House>(){
      new House(3, 2, 2, "https://www.architecturalrecord.com/ext/resources/Issues/2021/02-February/Golden-Valley-Midcentury-Modern-House-01-B.jpg?1611944303", 2017, 399000, "this is a good house!!"),
      new House(3, 3, 2, "https://www.architecturalrecord.com/ext/resources/Issues/2021/02-February/Golden-Valley-Midcentury-Modern-House-01-B.jpg?1611944303", 2000, 299000, "weird i have the same house but different data... imposter!")
      

    };
  }
}