using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vestcom.Job;

namespace UE2.Controllers
{
    [Produces("application/json")]
    [Route("api/jobs")]
    public class JobsController : Controller
    {
        [HttpGet("GetJobs", Name = "GetJobs")]
        public IActionResult Get()
        {
            var jobDefinitions = JobDefinitionView.GetAllJobDefinitions().ToList();
            var result = jobDefinitions.Select(j => new { j.JobName, j.JobDefinitionId, j.JobStartDate, j.CustomerId, j.CustomerName});

            return new ObjectResult(result);
        }
    }
}