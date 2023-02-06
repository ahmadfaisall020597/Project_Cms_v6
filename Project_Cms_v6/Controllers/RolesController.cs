using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Cms_v6.Base;
using Project_Cms_v6.Models;
using Project_Cms_v6.Repositories.Data;

namespace Project_Cms_v6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : BaseController<Roles, RoleRepository, int>
    {
        public RolesController(RoleRepository roleRepository) : base(roleRepository) 
        {

        }
    }
}
