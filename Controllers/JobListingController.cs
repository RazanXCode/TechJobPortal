using Microsoft.AspNetCore.Mvc;
using TechJobPortal.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components.Routing;

//---------------------------//

namespace TechJobPortal.Controllers
{
    //Create a Controller named JobController with two actions:
    // ● Index → Displays a list of job listings.
    // ● Details → Displays details of a selected job.

    public class JobListingController : Controller
    {


        // Simulate a database 
        public List<JobListing> _JobListing = new List<JobListing>
        {
            new JobListing { Id = 1, Title = "Software Engineer", CompanyName = "TechCorp", Location = "Riyadh", JobType = JobType.FullTime, PostedDate = DateTime.UtcNow },
            new JobListing { Id = 2, Title = "Data Analyst", CompanyName = "DataWorks", Location = "Jeddah", JobType = JobType.Remote, PostedDate = DateTime.UtcNow },
             new JobListing { Id = 3, Title = "Data scintest", CompanyName = "Elm", Location = "Jeddah", JobType = JobType.Remote, PostedDate = DateTime.UtcNow },
              new JobListing { Id = 4, Title = "Data Enginner", CompanyName = "DataWorks", Location = "Jeddah", JobType = JobType.Remote, PostedDate = DateTime.UtcNow },
               new JobListing { Id = 5, Title = "QA Enginner", CompanyName = "Elm", Location = "Jeddah", JobType = JobType.Remote, PostedDate = DateTime.UtcNow }
        };



        // 🟢 READ: Display all products
        public IActionResult Index()
        {
            return View(_JobListing);
        }

        // Details Action: Displays details of a selected job
        public IActionResult Details(int id)
        {
            var job = _JobListing.Find(j => j.Id == id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);

        }
    }
}

// using System;
// using System.Collections.Generic;
// using Microsoft.AspNetCore.Mvc;

// public class JobController : Controller
// {
//     // Sample job listings (in a real app, data would come from a database)
//     private static readonly List<JobListing> jobListings = new List<JobListing>
//     {
//         new JobListing { Id = 1, Title = "Software Engineer", CompanyName = "TechCorp", Location = "Riyadh", JobType = JobType.FullTime, PostedDate = DateTime.UtcNow },
//         new JobListing { Id = 2, Title = "Data Analyst", CompanyName = "DataWorks", Location = "Jeddah", JobType = JobType.Remote, PostedDate = DateTime.UtcNow }
//     };

//     // Index Action: Displays a list of job listings
//     public IActionResult Index()
//     {
//         return View(jobListings);
//     }

//     // Details Action: Displays details of a selected job
//     public IActionResult Details(int id)
//     {
//         var job = jobListings.Find(j => j.Id == id);
//         if (job == null)
//         {
//             return NotFound();
//         }
//         return View(job);
//     }
// }