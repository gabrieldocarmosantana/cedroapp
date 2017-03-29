using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cedro.Application.Interfaces;
using Cedro.Domain.Entities;
using Cedro.UI.Models;

namespace Cedro.UI.Controllers
{
    public class HomeController : Controller
    {

        private readonly IRestaurantAppService _restaurantAppService;

        public HomeController(IRestaurantAppService restaurantAppService)
        {
            _restaurantAppService = restaurantAppService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }

}