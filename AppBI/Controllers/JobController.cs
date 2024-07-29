using AppBI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppBI.Controllers
{
    public class JobController : Controller
    {
        private static List<JobListing> jobListings = new List<JobListing>
        {
            new JobListing { Id = 1, Title = "Software Developer", Location = "New York", Description = "Develop and maintain software applications.", PostedDate = DateTime.Now },
            new JobListing { Id = 2, Title = "HR Manager", Location = "San Francisco", Description = "Manage HR activities and recruitment.", PostedDate = DateTime.Now }
        };

        public IActionResult Index()
        {
            return View(jobListings);
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(JobApplication application)
        {
            if (ModelState.IsValid)
            {
                // Save the application to the database or process it
                TempData["SuccessMessage"] = "Your application has been submitted successfully!";
                return RedirectToAction("Index");
            }

            return View(application);
        }
    }
}
