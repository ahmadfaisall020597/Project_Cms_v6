using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Cms_v6.Base;
using Project_Cms_v6.Models;
using Project_Cms_v6.Repositories.Data;
using Project_Cms_v6.Repositories.Interface;
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
        [HttpGet]
        [Route("Employees")]
        public ActionResult GetAllEmployees() 
        {
            var get = employeesRepository.GetAllEmployees();
            if (get.Count() != 0)
            {
                return StatusCode(200,
                    new
                    {
                        status = HttpStatusCode.OK,
                        message = get.Count() + "Data Ditemukan",
                        Data = get
                    });
            }
            else
            {
                return StatusCode(404,
                    new
                    {
                        status = HttpStatusCode.NotFound,
                        message = get.Count() + "Data tidak ditemukan",
                        Data = get
                    });
            }
        }
    }
}
