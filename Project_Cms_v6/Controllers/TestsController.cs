using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Cms_v6.Models;
using Project_Cms_v6.Repositories.Data;
using Project_Cms_v6.ViewModels;
using System.Net;

namespace Project_Cms_v6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly EmployeesRepository employeesRepository;
        public TestsController(EmployeesRepository employeesRepository)
        {
            this.employeesRepository = employeesRepository;
        }

        [HttpPost("Test")]
        public ActionResult Register(RegisterVM loginVM)
        {
            return StatusCode(200, new
            {
                Status = HttpStatusCode.Created,
                Message = "Data employee successfully registered",
                Data = 1
            });
        }
    }
}
