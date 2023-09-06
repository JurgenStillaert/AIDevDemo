// HomeController.cs

using Crops.Models;  // Importing the Models namespace
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace Crops.Controllers
{
    public class HomeController : Controller
    {
        // In-memory storage for demo purposes
        static List<CropChangeRequest> changeRequests = new List<CropChangeRequest>();

        // Display the form and list of change requests
        public IActionResult Index()
        {
            return View(changeRequests);
        }

        // Handle form submission
        [HttpPost]
        public IActionResult SubmitChangeRequest(CropChangeRequest request)
        {
            request.ModificationDate = DateTime.Now;
            request.Id = changeRequests.Count + 1;  // Generating an Id based on the list count
            changeRequests.Add(request);
            return RedirectToAction("Index");
        }
    }
}
