
using Microsoft.AspNetCore.Mvc;
using PlacesYouHaveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouHaveBeen.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Place> placeList = Place.GetAllPlaces();

      return View(placeList);
    }
    [HttpGet("/add")]
    public ActionResult Add()
    {
      return View();
    }

    [HttpPost("/addedPlace")]
    public ActionResult AddedPlace()
    {
      string placeName = Request.Form["place-name"];
      string dayFrom = Request.Form["from"].ToString();
      string dayTo = Request.Form["to"].ToString();
      string description = Request.Form["diary"];
      int rating = int.Parse(Request.Form["rating"]);

      Place newPlace = new Place(placeName, dayFrom, dayTo, description, rating);
      return View(newPlace);
    }


  }
}
