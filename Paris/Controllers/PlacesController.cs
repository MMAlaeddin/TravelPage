using Microsoft.AspNetCore.Mvc;
using Log.Models;
using System.Collections.Generic;

namespace Log.Controllers
{
  public class PlacesController : Controller
  {
    [HttpPost("/visits")]
    public ActionResult Create(string cityCountry, int year, string landmark, string notes)
    {
      Place newPlace = new Place(cityCountry, year, landmark, notes);
      return RedirectToAction("Index", newPlace);
    }
    [HttpGet("/visits/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/visits")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }
    [HttpGet("/visits/{id}")]
    public ActionResult Show(int Id)
    {
      Place foundPlace = Place.Find(Id);
      return View(foundPlace);
    }
  }
}