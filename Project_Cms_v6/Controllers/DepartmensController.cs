using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Cms_v6.Base;
using Project_Cms_v6.Models;
using Project_Cms_v6.Repositories.Data;

namespace Project_Cms_v6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmensController : BaseController<Departments, DepartementRepository, int>
    {
        public DepartmensController(DepartementRepository departementRepository) : base(departementRepository)
        {

        }
    }
}
