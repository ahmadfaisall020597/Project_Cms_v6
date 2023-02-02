using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Cms_v6.Models
{
    public class AccountRoles
    {
        public int Id { get; set; }
        [ForeignKey("Roles")]
        public int RoleId { get; set; }
        public Roles Roles { get; set; }
        [ForeignKey("Accounts")]
        public string AccountNIK { get; set; }
        public Accounts Accounts { get; set; }
    }
}
