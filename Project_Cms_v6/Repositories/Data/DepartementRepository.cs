using Project_Cms_v6.Context;
using Project_Cms_v6.Models;

namespace Project_Cms_v6.Repositories.Data
{
    public class DepartementRepository : GeneralRepository<AppDbContext, Departments, int>
    {
        public  DepartementRepository(AppDbContext context) : base(context)
        {
             
        }
    }
}
