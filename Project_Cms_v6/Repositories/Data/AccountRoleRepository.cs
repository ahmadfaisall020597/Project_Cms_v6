using Project_Cms_v6.Context;
using Project_Cms_v6.Models;

namespace Project_Cms_v6.Repositories.Data
{
    public class AccountRoleRepository : GeneralRepository<AppDbContext, AccountRoles, int>
    {
        public AccountRoleRepository(AppDbContext context) : base(context)
        {

        }
    }
}
