using System;
using System.ComponentModel.DataAnnotations;

namespace Project_Cms_v6.Models
{
    public class Departments
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager_Id { get; set; }
    }
}
