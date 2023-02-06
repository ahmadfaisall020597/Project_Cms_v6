using Project_Cms_v6.Context;
using Project_Cms_v6.Models;

namespace Project_Cms_v6.Repositories.Data
{
    public class RoleRepository : GeneralRepository<AppDbContext, Roles, int>
    {
        public RoleRepository(AppDbContext context) : base(context)
        {

        }
    }
}
