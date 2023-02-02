using System;
using System.ComponentModel.DataAnnotations;

namespace Project_Cms_v6.Models
{
    public class Roles
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
