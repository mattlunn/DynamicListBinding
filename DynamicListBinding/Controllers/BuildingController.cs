using DynamicListBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicListBinding.Controllers
{
    public class BuildingController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            var building = new Building();

            for (var i = 0; i < 2;i++)
            {
                building.Rooms.Add(new Room());
            }

            return View(building);
        }

        [HttpPost]
        public ActionResult Create([Bind] Building building)
        {
            return View(building);
        }

        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
        public ActionResult AddRoom()
        {
            var building = new Building();
            building.Rooms.Add(new Room());

            return View(building);
        }
    }
}