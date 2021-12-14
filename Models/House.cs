
namespace gregslistcsharp.Models 
{
public class House
{
     public string? Id {get; set;}
     public int Bedrooms {get; set;}
     public int Bathrooms {get; set;}
     public int Levels {get; set;}
     public string ImgUrl {get; set;}
     public int Year {get; set;}
     public int Price {get; set;}
     public string? Description {get; set;}

     public House(int bedrooms, int bathrooms, int levels, string? imgUrl, int year, int price, string? description)
     {
       Id = Guid.NewGuid().ToString();
       Bedrooms = bedrooms;
       Bathrooms = bathrooms;
       Levels = levels;
       ImgUrl = imgUrl;
       Year = year;
       Price = price;
       Description = description;
     }
     
}
}