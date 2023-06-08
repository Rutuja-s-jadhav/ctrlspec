using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ctrlspec.Models;

using ctrlspec.Repos;

namespace ctrlspec.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Project_InfoController : ControllerBase
    {
        private readonly IProject_Info _dbContext;

        public Project_InfoController(IProject_Info dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpPost]
        [Route("addProjectInfo")]
        public async Task<IActionResult> AddProjectInfo(Project_Info project)
        {
            
           await _dbContext.Add_Project_Info(project);
           if(project != null)
           {
            return Ok("Success");

        }
        else if(project!=project)
        {
            return Ok("Already Exists");
        }
        return Ok(project);
        }

        [HttpGet]
        [Route("[controller]/{projectNumber:double}")]
   
        public async Task<IActionResult> GetProjectInfo(double projectNumber)
        {
            try
            {
                var result = await _dbContext.Get_Project_Info(projectNumber);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch(Exception e)
            {
                return BadRequest("Error in Controller method GetEmployeesByID"+ e);
            }
        }

    }

    
}