using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Log.Models;

namespace Log.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
      {
        Place.ClearAll();
      }
    
    [TestMethod]
    public void PlaceConstructor_CreatesPlaceInstance_Place()
    {
      Place myPlace = new Place("test", 1111,"test","test");
      Assert.AreEqual(typeof(Place), myPlace.GetType());
    }
    [TestMethod]
    public void GetId_PlaceInstantiatedWithIdAndGetterReturns_Int()
    {
      string cityCountry = "test";
      int year = 1111;
      string landmark = "test";
      string notes = "test";
      Place myPlace = new Place(cityCountry, year, landmark, notes);
      int result = myPlace.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      string cityCountry01 = "test";
      int year01 = 1111;
      string landmark01 = "test";
      string notes01 = "test";
      string cityCountry02 = "test";
      int year02 = 1111;
      string landmark02 = "test";
      string notes02 = "test";
      Place myPlace1 = new Place(cityCountry01, year01, landmark01, notes01);
      Place myPlace2 = new Place(cityCountry02, year02, landmark02, notes02);
      Place result = Place.Find(2);
      Assert.AreEqual(myPlace2, result);
    }
  }
}