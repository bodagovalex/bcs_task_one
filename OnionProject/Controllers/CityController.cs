using Microsoft.AspNetCore.Mvc;
using Onion.Domain.Interfaces;

namespace OnionProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        ICityRepository cityRepository;

        public CityController(ICityRepository r)
        {
            cityRepository = r;

        }

        [HttpGet("")]
        public ActionResult GetCityList()
        {
            return Json(cityRepository.GetCityList());
        }

        protected override void Dispose(bool disposing)
        {
            cityRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
