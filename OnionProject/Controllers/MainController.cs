using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Onion.Domain.Interfaces;
using System.Linq;

namespace OnionProject.Controllers
{
    public class MainController : Controller
    {
        ICityRepository cityRepo;

        public MainController(ICityRepository rep)
        {
            cityRepo = rep;
        }
        public ActionResult Index()
        {
            var modelList = new SelectList(cityRepo.GetCityList().ToList(), "CityID", "Name");
            return View(modelList);
        }
    }
}