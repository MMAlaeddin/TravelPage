using System;
using System.Collections.Generic;

namespace Log.Models
{
  public class Place
  {
    public string CityCountry { get; set; }
    public int Year { get; set; }
    public string Landmark { get; set; }
    public string Notes { get; set; }
    private static List<Place> _instances = new List<Place> {};

    public Place(string cityCountry, int year, string landmark, string notes)
    {
      CityCountry = cityCountry;
      Year = year;
      Landmark = landmark;
      Notes = notes;
      _instances.Add(this);
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
  }
}