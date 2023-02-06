using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Cms_v6.Base;
using Project_Cms_v6.Models;
using Project_Cms_v6.Repositories.Data;
using Project_Cms_v6.ViewModels;
using System.Net;

namespace Project_Cms_v6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : BaseController<Employees, EmployeesRepository, string>
    {
        private readonly EmployeesRepository employeesRepository;
        public EmployeesController(EmployeesRepository employeesRepository) : base(employeesRepository)
        {
            this.employeesRepository = employeesRepository;
        }

        [HttpPost]
        [Route("Register")]
        public ActionResult Register([FromBody] RegisterVM registerEmployee)
        {
            var response = employeesRepository.RegisterInsert(registerEmployee);
            if (response >= 1)
            {
                return StatusCode(200, new
                {
                    Status = HttpStatusCode.Created,
                    Message = "Data employee successfully registered",
                    Data = response
                });
            }
            else
            {
                return StatusCode(400, new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = "Internal server error",
                    Data = response
                });
            }
        }
    }
}
