using JobCompass.Data;
using Microsoft.AspNetCore.Mvc;

namespace JobCompass.Controllers
{
    public class JobsController : BaseApiController
    {
        private List<Job> jobs = new List<Job>
        {
            new Job { Id = 1, Position = "Software Developer", Location = "New York", Seniority = "Junior", SalaryRange = "50k-60k", Benefits = "Health, Dental, Vision", Description = "Develop and maintain software applications" },
            new Job { Id = 2, Position = "Data Scientist", Location = "Los Angeles", Seniority = "Senior", SalaryRange = "80k-90k", Benefits = "Health, Dental, Vision, 401k", Description = "Analyze and interpret complex data" },
            new Job { Id = 3, Position = "System Administrator", Location = "Chicago", Seniority = "Mid", SalaryRange = "60k-70k", Benefits = "Health, Dental", Description = "Maintain and upgrade system networks" },
            new Job { Id = 4, Position = "Product Manager", Location = "Seattle", Seniority = "Senior", SalaryRange = "100k-120k", Benefits = "Health, Dental, Vision, 401k, Stock options", Description = "Define product vision and strategy" },
            new Job { Id = 5, Position = "UX Designer", Location = "San Francisco", Seniority = "Mid", SalaryRange = "70k-80k", Benefits = "Health, Dental, Vision", Description = "Design user-friendly interfaces" },
            new Job { Id = 6, Position = "Database Administrator", Location = "Austin", Seniority = "Junior", SalaryRange = "55k-65k", Benefits = "Health, Dental, Vision", Description = "Maintain and optimize database systems" },
            new Job { Id = 7, Position = "DevOps Engineer", Location = "Boston", Seniority = "Mid", SalaryRange = "75k-85k", Benefits = "Health, Dental, Vision, 401k", Description = "Implement and maintain CI/CD pipelines" },
            new Job { Id = 8, Position = "Project Manager", Location = "Dallas", Seniority = "Senior", SalaryRange = "90k-100k", Benefits = "Health, Dental, Vision, 401k", Description = "Manage project timelines and resources" },
            new Job { Id = 9, Position = "Quality Assurance Engineer", Location = "Phoenix", Seniority = "Junior", SalaryRange = "50k-60k", Benefits = "Health, Dental, Vision", Description = "Test and ensure quality of software applications" },
            new Job { Id = 10, Position = "Security Analyst", Location = "San Jose", Seniority = "Mid", SalaryRange = "70k-80k", Benefits = "Health, Dental, Vision, 401k", Description = "Monitor and manage security threats" },
        };

        [HttpGet]
        public ActionResult<IEnumerable<Job>> GetJobs(string? position, string? location, string? seniority, string? salaryRange)
        {
            var result = jobs.AsQueryable();

            if (!string.IsNullOrEmpty(position))
            {
                result = result.Where(job => job.Position.Contains(position));
            }

            if (!string.IsNullOrEmpty(location))
            {
                result = result.Where(job => job.Location.Contains(location));
            }

            if (!string.IsNullOrEmpty(seniority))
            {
                result = result.Where(job => job.Seniority.Contains(seniority));
            }

            if (!string.IsNullOrEmpty(salaryRange))
            {
                result = result.Where(job => job.SalaryRange.Contains(salaryRange));
            }

            return Ok(result.ToList());
        }


    }
}
