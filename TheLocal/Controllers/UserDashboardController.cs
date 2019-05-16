using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheLocal.Data;
using TheLocal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.IdentityModel.Protocols;
using System.Data.SqlClient;
using System.Configuration;

namespace TheLocal.Views.Home
{
    public class UserDashboardController : Controller
        
    {
        private ApplicationDbContext dbContext;

        public UserDashboardController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        //=====SESSION=====//
        public IActionResult AddLocations(int ID, string UserID, string LocationName, string LocationDescription, string LocationType, decimal Latitude, decimal Longitude)
        {
            LocationsModel l = new LocationsModel();

            l.UserID = HttpContext.Session.GetString("userid");
            l.Latitude = Latitude;
            l.Longitude = Longitude;
            l.LocationType = LocationType;
            l.LocationName = LocationName;
            l.LocationDescription = LocationDescription;
            
            dbContext.Locations.Add(l);
            
            dbContext.SaveChanges();

           //redirect to action user dashboard page.
            return RedirectToAction("UserDashboard", "UserDashboard");
        }

        public IActionResult UserDashboard()
        {
            var loggedInUser = dbContext.Users.Where(u => string.Equals(u.Email, User.Identity.Name ?? "")).FirstOrDefault();
            if (loggedInUser != null)
            {
                HttpContext.Session.SetString("userid", loggedInUser.Id);
            }

            ViewBag.dropdownItem = new List<string>();
            ViewBag.dropdownItem.Add("Bars/Alcohol");
            ViewBag.dropdownItem.Add("Beach");
            ViewBag.dropdownItem.Add("Food");
            ViewBag.dropdownItem.Add("Music");
            ViewBag.dropdownItem.Add("Theatre");
            ViewBag.Locations = dbContext.Locations.ToList();

            ViewBag.UserLocations = dbContext.Locations.Where(l => l.UserID == loggedInUser.Id).ToList();

            return View();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int ID)
        {
            //LocationsModel l = new LocationsModel();
            LocationsModel Location = dbContext.Locations.Find(ID);
            
            dbContext.Locations.Remove(Location);
            //dbcontext.savechanges()
            dbContext.SaveChanges();
            return RedirectToAction("UserDashboard", "UserDashboard");
        }

        //===== POPULATE VIEW SPOTS WITH ALL MARKERS =====//
        public IActionResult GetMarkers()
        {
            //===== Retrieves all markers in DB =====//
            List<LocationsModel> markers = dbContext.Locations.ToList();
            return Json(markers);
        }

        //===== POPULATE YOUR MAP WITH YOUR MARKERS =====//
        public IActionResult GetUserMarkers()
        {
            var loggedInUser = dbContext.Users.Where(u => string.Equals(u.Email, User.Identity.Name ?? "")).FirstOrDefault();
            if (loggedInUser != null)
            {
                HttpContext.Session.SetString("userid", loggedInUser.Id);
            }
            List<LocationsModel> userMarkers = dbContext.Locations.Where(l => l.UserID == loggedInUser.Id).ToList();
            return Json(userMarkers);
        }
        public IActionResult PopulateViewSpots()
        {
            ViewBag.Locations = dbContext.Locations.ToList();
            return View();
        }
    }
}