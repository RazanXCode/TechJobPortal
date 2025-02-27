using Microsoft.AspNetCore.Mvc;
using TechJobPortal.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components.Routing;

//---------------------------//

namespace TechJobPortal.Controllers
{


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



        // 🟢 READ: Display all Jobs
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


    [HttpPost]
    public IActionResult Edit(int id, JobListing updatedJob)
    {
    var job = _JobListing.Find(j => j.Id == id);
    if (job == null)
    {
        return NotFound();
    }

    job.JobType = updatedJob.JobType;
    return RedirectToAction("Details", new { id = job.Id });
    }

    }
}

