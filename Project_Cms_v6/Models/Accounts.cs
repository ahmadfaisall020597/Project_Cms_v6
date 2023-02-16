using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Cms_v6.Models
{
    public class Accounts
    {
        [Key]
        public string NIK { get; set; }
        public string Password { get; set; }
        [ForeignKey("NIK")]
        public virtual Employees Employees { get; set; }
    }
}
