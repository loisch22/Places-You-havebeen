
using System.Collections.Generic;

namespace PlacesYouHaveBeen.Models
{
  public class Place
  {
    private string _placeName;
    private string _from;
    private string _to;
    private string _description;
    private int _rating;
    private static List<Place> places = new List<Place> ();

    public Place (string placeName, string dayFrom, string dayTo, string description, int rating)
    {
      _placeName = placeName;
      _from = dayFrom;
      _to = dayTo;
      _description = description;
      _rating = rating;
      places.Add(this);
    }
    public string GetPlaceName()
    {
      return _placeName;
    }
    public void SetPlaceName(string placeName)
    {
      _placeName = placeName;
    }
    public string GetFrom()
    {
      return _from;
    }
    public void SetFrom(string dayFrom)
    {
      _from = dayFrom;
    }
    public string GetTo()
    {
      return _to;
    }
    public void SetTo(string dayTo)
    {
      _to = dayTo;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string description)
    {
      _description = description;
    }
    public int GetRating()
    {
      return _rating;
    }
    public void SetRating(int rating)
    {
      _rating = rating;
    }
    public static List<Place> GetAllPlaces()
    {
      return places;
    }
  }
}
