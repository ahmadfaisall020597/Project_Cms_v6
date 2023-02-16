﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Cms_v6.Models
{
    public class AccountRoles
    {
        [ForeignKey("Roles")]
        public int RoleId { get; set; }
        public virtual Roles Roles { get; set; }
        [ForeignKey("Accounts")]
        public string AccountNIK { get; set; }
        public virtual Accounts Accounts { get; set; }
    }
}
