using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Onion.Domain.Interfaces;
using OnionProject.Models;
using Onion.Infrastructure.Data;

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
